using BotLauncher.Controls.Base;
using BotLauncher.Models.Telegram;
using BotLauncher.Services.Telegram;
using BotLauncher.Shared.Services;
using BotLauncher.Controls.Telegram.Groups.TabSendSettings;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot.Types.Enums;

namespace BotLauncher.Controls.Telegram.Groups
{
    public partial class TelegramGroupsControl : BaseControl
    {
        private readonly TelegramGroupsService groupsService = null!;
        private readonly TelegramBotService telegramBot = null!;
        private readonly TelegramTemplatesService templatesService = null!;
        private readonly TelegramManualSender manualSender = null!;
        private readonly TelegramAutoSender autoSender = null!;

        // ИСПРАВЛЕНО: Добавлено хранилище настроек для передачи в ManualTabControl
        private readonly LiteDbSettingsStorage _settingsStorage = new LiteDbSettingsStorage();

        private long? _selectedChatId = null;
        private Dictionary<long, CancellationTokenSource> _groupSessions = new();
        private Dictionary<long, bool> _groupSessionActive = new();

        private Dictionary<string, Control> _designerPlaceholders = new();
        private Dictionary<string, UserControl> _tabModeControls = new();

        public TelegramGroupsControl()
        {
            InitializeComponent();

            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                SetDefaultState();
                return;
            }

            try
            {
                SetOnlineStatus();

                groupsService = AppServices.TelegramGroups!;
                telegramBot = AppServices.TelegramBot!;
                templatesService = new TelegramTemplatesService();

                manualSender = new TelegramManualSender(telegramBot, templatesService);
                autoSender = new TelegramAutoSender(telegramBot, templatesService, manualSender);

                telegramBot.BotConnected += OnBotConnected;
                telegramBot.BotDisconnected += OnBotDisconnected;

                groupsService.GroupAdded += OnGroupAdded;
                groupsService.GroupUpdated += OnGroupUpdated;
                groupsService.GroupRemoved += OnGroupRemoved;
                groupsService.GroupMigrated += OnGroupMigrated;
                groupsService.GroupsCleared += OnGroupsCleared;

                if (btnAddConnectedChat != null) btnAddConnectedChat.Click += BtnAddConnectedChat_Click;

                LoadConnectedChats();

                InitializeTabControl();
                InitializeTabModes();
                SetDefaultState();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Ошибка в конструкторе TelegramGroupsControl: {ex.Message}");
                SetDefaultState();
            }
        }

        #region TabControl & Modes Initialization

        private void InitializeTabControl()
        {
            if (TabControl == null) return;

            TabControl.SelectedIndexChanged += UITabControl1_SelectedIndexChanged;

            foreach (TabPage tab in TabControl.TabPages)
            {
                tab.UseVisualStyleBackColor = false;
            }

            if (TabControl.TabPages.Count > 0)
            {
                TabControl.SelectedIndex = 0;
            }
        }

        private void InitializeTabModes()
        {
            if (TabControl == null) return;

            foreach (TabPage tab in TabControl.TabPages)
            {
                var placeholder = tab.Controls.Cast<Control>()
                    .FirstOrDefault(c => c.Name.Contains("Placeholder"));

                if (placeholder != null)
                {
                    _designerPlaceholders[tab.Name] = placeholder;
                    placeholder.Visible = true;
                    placeholder.BringToFront();
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine(
                        $"[TelegramGroupsControl] Заглушка не найдена в табе {tab.Name}");
                }

                // ИСПРАВЛЕНО: Передаем необходимые сервисы в конструктор ManualTabControl
                UserControl modeControl = tab.Name switch
                {
                    "tabHome" => new HomeTabControl(),
                    "tabAuto" => new AutoTabControl(),
                    "tabDelayed" => new DelayedTabControl(),
                    "tabPeriodic" => new PeriodicTabControl(),
                    "tabSchedule" => new ScheduleTabControl(),
                    "tabEvent" => new EventTabControl(),
                    "tabPriority" => new PriorityTabControl(),
                    "tabManual" => new ManualTabControl(telegramBot, templatesService, _settingsStorage),
                    _ => new UserControl()
                };

                modeControl.Name = $"ctrl_{tab.Name}";
                modeControl.Dock = DockStyle.Fill;
                modeControl.Visible = false;

                tab.Controls.Add(modeControl);
                _tabModeControls[tab.Name] = modeControl;
            }
        }

        private void UpdateTabVisibility()
        {
            bool hasGroup = _selectedChatId.HasValue;

            foreach (TabPage tab in TabControl.TabPages)
            {
                var tabName = tab.Name;

                if (_designerPlaceholders.TryGetValue(tabName, out var placeholder) &&
                    _tabModeControls.TryGetValue(tabName, out var modeControl))
                {
                    if (hasGroup)
                    {
                        placeholder.Visible = false;
                        placeholder.SendToBack();

                        modeControl.Visible = true;
                        modeControl.BringToFront();
                    }
                    else
                    {
                        modeControl.Visible = false;
                        modeControl.SendToBack();

                        placeholder.Visible = true;
                        placeholder.BringToFront();
                    }
                }
            }

            if (hasGroup && TabControl != null)
            {
                var homeTab = TabControl.TabPages.Cast<TabPage>().FirstOrDefault(t => t.Name == "tabHome");
                if (homeTab != null)
                {
                    TabControl.SelectedTab = homeTab;
                }
            }

            TabControl?.Refresh();
        }

        private void UITabControl1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (TabControl.SelectedTab == null) return;

            string selectedTabName = TabControl.SelectedTab.Name;
            Log($"Переключена вкладка: {selectedTabName}");
        }

        private void Log(string msg)
        {
            try
            {
                System.IO.File.AppendAllText(
                    System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bot_debug.log"),
                    $"[{DateTime.Now:HH:mm:ss}] [UI] {msg}\n");
            }
            catch { }
        }
        #endregion

        #region Session Management per Group
        private bool IsGroupSessionActive(long chatId)
        {
            return _groupSessionActive.TryGetValue(chatId, out bool active) && active;
        }

        private void SetGroupSessionActive(long chatId, bool active)
        {
            _groupSessionActive[chatId] = active;
            UpdateGroupSessionUI(chatId, active);
        }

        private void UpdateGroupSessionUI(long chatId, bool isActive)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateGroupSessionUI(chatId, isActive)));
                return;
            }

            var card = flpConnectedChats.Controls.OfType<ChatCardControl>()
                .FirstOrDefault(c => c.GetGroup()?.ChatId == chatId);

            if (card != null)
            {
                card.SetSessionStatus(isActive);
            }

            if (isActive && _selectedChatId == chatId)
            {
                avatarPanel.RectColor = Color.Lime;
                avatarPanel.Invalidate();
            }
            else if (!isActive && _selectedChatId == chatId)
            {
                avatarPanel.RectColor = Color.Red;
                avatarPanel.Invalidate();
            }
        }

        private CancellationTokenSource? GetGroupCancellationToken(long chatId)
        {
            return _groupSessions.TryGetValue(chatId, out var cts) ? cts : null;
        }

        private void CreateGroupCancellationToken(long chatId)
        {
            _groupSessions[chatId] = new CancellationTokenSource();
        }

        private void CancelGroupSession(long chatId)
        {
            if (_groupSessions.TryGetValue(chatId, out var cts))
            {
                cts.Cancel();
            }
        }

        private void ClearGroupSession(long chatId)
        {
            if (_groupSessions.TryGetValue(chatId, out var cts))
            {
                cts.Dispose();
                _groupSessions.Remove(chatId);
            }
            _groupSessionActive.Remove(chatId);
        }
        #endregion

        #region Status & Avatar
        public void SetOnlineStatus() { if (InvokeRequired) { Invoke(SetOnlineStatus); return; } avatarPanel.RectColor = Color.Lime; avatarPanel.Invalidate(); }
        public void SetOfflineStatus() { if (InvokeRequired) { Invoke(SetOfflineStatus); return; } avatarPanel.RectColor = Color.Gray; avatarPanel.Invalidate(); }
        public void SetDoNotDisturbStatus() { if (InvokeRequired) { Invoke(SetDoNotDisturbStatus); return; } avatarPanel.RectColor = Color.Red; avatarPanel.Invalidate(); }
        public void SetStatusColor(Color color) { if (InvokeRequired) { Invoke(() => SetStatusColor(color)); return; } avatarPanel.RectColor = color; avatarPanel.Invalidate(); }

        private void SetDefaultState()
        {
            if (avatarPanel != null)
            {
                avatarPanel.BackgroundImage = Properties.Resources.robot_solid;
                avatarPanel.BackgroundImageLayout = ImageLayout.Stretch;
                avatarPanel.RectColor = Color.Transparent;
                avatarPanel.Invalidate();
            }
            lblChannelName.Text = "Выберите группу или канал";
            lblChannelName.ForeColor = Color.FromArgb(156, 163, 175);
            lblChannelNickname.Text = "@username";
            lblGroupTypeValue.Text = "-";
            lblGroupId.Text = "ID: -";
            lblParticipantsValue.Text = "-";
            lblStatusValue.Text = "Не выбрано";
            lblStatusValue.ForeColor = Color.Gray;

            UpdateTabVisibility();
        }

        public static Bitmap? CropToCircle(Image? sourceImage)
        {
            if (sourceImage == null) return null;
            int size = 95;
            Bitmap bitmap = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.Clear(Color.Transparent);
                using (GraphicsPath path = new GraphicsPath())
                {
                    int padding = 3;
                    int diameter = size - padding * 2;
                    path.AddEllipse(padding, padding, diameter, diameter);
                    g.SetClip(path);
                    g.DrawImage(sourceImage, padding, padding, diameter, diameter);
                }
            }
            return bitmap;
        }
        #endregion

        #region Bot Connection & Chats
        private void OnBotConnected() { if (InvokeRequired) { Invoke(OnBotConnected); return; } SetOnlineStatus(); if (telegramBot.BotInfo != null) groupsService.SetActiveBot(telegramBot.BotInfo.Id); LoadConnectedChats(); }
        private void OnBotDisconnected() { if (InvokeRequired) { Invoke(OnBotDisconnected); return; } SetOfflineStatus(); groupsService.DeactivateBot(); ClearConnectedChats(); autoSender.StopAll(); }

        private void ClearConnectedChats()
        {
            if (InvokeRequired) { Invoke(ClearConnectedChats); return; }
            flpConnectedChats.SuspendLayout();
            try { flpConnectedChats.Controls.Clear(); UpdateConnectedChatsCount(); }
            finally { flpConnectedChats.ResumeLayout(); }
        }

        private void LoadConnectedChats()
        {
            if (InvokeRequired) { Invoke(LoadConnectedChats); return; }
            flpConnectedChats.SuspendLayout();
            try
            {
                flpConnectedChats.Controls.Clear();
                if (!telegramBot.IsConnected) { UpdateConnectedChatsCount(); return; }
                if (telegramBot.BotInfo != null && groupsService.ActiveBotId == 0) groupsService.SetActiveBot(telegramBot.BotInfo.Id);
                foreach (var group in groupsService.GetGroups()) AddChatCard(group);
                UpdateConnectedChatsCount();
            }
            finally { flpConnectedChats.ResumeLayout(); }
        }

        private void OnGroupAdded(TelegramGroup group) { if (InvokeRequired) { Invoke(() => OnGroupAdded(group)); return; } if (!telegramBot.IsConnected) return; AddChatCard(group); UpdateConnectedChatsCount(); }
        private void OnGroupUpdated(TelegramGroup group) { if (InvokeRequired) { Invoke(() => OnGroupUpdated(group)); return; } if (!telegramBot.IsConnected) return; AddChatCard(group); }
        private void OnGroupMigrated(long oldChatId, long newChatId) { if (InvokeRequired) { Invoke(() => OnGroupMigrated(oldChatId, newChatId)); return; } LoadConnectedChats(); }

        private void AddChatCard(TelegramGroup group)
        {
            if (!telegramBot.IsConnected) return;
            var existingCard = flpConnectedChats.Controls.OfType<ChatCardControl>().FirstOrDefault(c => c.GetGroup()?.ChatId == group.ChatId);
            if (existingCard != null) { existingCard.SetData(group); return; }
            var newCard = new ChatCardControl(telegramBot);
            newCard.SetData(group);
            newCard.DeleteRequested += OnChatDeleteRequested;
            newCard.ChatSelected += OnChatSelected;
            newCard.MoveUpRequested += OnChatMoveUpRequested;
            newCard.MoveDownRequested += OnChatMoveDownRequested;
            flpConnectedChats.Controls.Add(newCard);
        }

        private void OnChatMoveUpRequested(TelegramGroup group) { if (InvokeRequired) { Invoke(() => OnChatMoveUpRequested(group)); return; } MoveCard(group, -1); }
        private void OnChatMoveDownRequested(TelegramGroup group) { if (InvokeRequired) { Invoke(() => OnChatMoveDownRequested(group)); return; } MoveCard(group, 1); }

        private void MoveCard(TelegramGroup group, int direction)
        {
            var cards = flpConnectedChats.Controls.OfType<ChatCardControl>().ToList();
            var currentCard = cards.FirstOrDefault(c => c.GetGroup()?.ChatId == group.ChatId);
            int currentIndex = cards.IndexOf(currentCard!);
            int newIndex = currentIndex + direction;
            if (currentCard != null && newIndex >= 0 && newIndex < cards.Count)
                flpConnectedChats.Controls.SetChildIndex(currentCard, newIndex);
        }

        private void OnChatSelected(TelegramGroup group)
        {
            if (InvokeRequired) { Invoke(() => OnChatSelected(group)); return; }

            if (_selectedChatId == group.ChatId)
            {
                _selectedChatId = null;
                foreach (var card in flpConnectedChats.Controls.OfType<ChatCardControl>()) card.SetSelected(false);
                SetDefaultState();
                return;
            }

            // Проверяем можно ли переключиться (через ManualTabControl)
            if (_tabModeControls.TryGetValue("tabManual", out var manualControl))
            {
                if (manualControl is ManualTabControl manualTab)
                {
                    if (!manualTab.TrySwitchGroup(group.ChatId))
                        return; // Пользователь отменил переключение
                }
            }

            _selectedChatId = group.ChatId;
            foreach (var card in flpConnectedChats.Controls.OfType<ChatCardControl>()) card.SetSelected(false);
            var selectedCard = flpConnectedChats.Controls.OfType<ChatCardControl>().FirstOrDefault(c => c.GetGroup()?.ChatId == group.ChatId);
            selectedCard?.SetSelected(true);

            ShowGroupInfo(group);
            UpdateTabVisibility();
        }

        private async void ShowGroupInfo(TelegramGroup group)
        {
            if (group == null) { SetDefaultState(); return; }
            lblChannelName.Text = string.IsNullOrWhiteSpace(group.Title) ? "Без названия" : group.Title;
            lblChannelName.ForeColor = Color.White;
            lblChannelNickname.Text = string.IsNullOrWhiteSpace(group.Username) ? "@username" : $"@{group.Username.TrimStart('@')}";
            lblGroupTypeValue.Text = group.Type;
            lblGroupId.Text = $"ID: {group.ChatId}";
            lblParticipantsValue.Text = group.Members <= 0 ? "—" : group.Members.ToString("N0");
            lblStatusValue.Text = group.ChatStatus;
            lblStatusValue.ForeColor = (group.ChatStatus == "Подключено" || group.ChatStatus == "Активен") ? Color.Lime : Color.Gray;

            if (avatarPanel != null)
            {
                if (IsGroupSessionActive(group.ChatId))
                {
                    avatarPanel.RectColor = Color.Lime;
                }
                else
                {
                    avatarPanel.RectColor = Color.Red;
                }
                avatarPanel.Invalidate();
            }
            await LoadChatAvatarAsync(group.ChatId);
        }

        private async Task LoadChatAvatarAsync(long chatId)
        {
            try
            {
                var oldImage = avatarPanel.BackgroundImage;
                avatarPanel.BackgroundImage = Properties.Resources.robot_solid;
                avatarPanel.BackgroundImageLayout = ImageLayout.Stretch;
                oldImage?.Dispose();
                byte[]? photoBytes = await telegramBot.GetChatPhotoAsync(chatId);
                if (photoBytes != null && photoBytes.Length > 0)
                {
                    using var stream = new MemoryStream(photoBytes);
                    using Image? avatar = Image.FromStream(stream);
                    if (avatar != null)
                    {
                        Bitmap? circularAvatar = CropToCircle(avatar);
                        if (circularAvatar != null)
                        {
                            var prevBg = avatarPanel.BackgroundImage;
                            avatarPanel.BackgroundImage = circularAvatar;
                            prevBg?.Dispose();
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine($"Ошибка загрузки аватарки: {ex.Message}"); }
        }

        private void OnChatDeleteRequested(TelegramGroup group)
        {
            if (InvokeRequired) { Invoke(() => OnChatDeleteRequested(group)); return; }
            if (group == null) return;
            autoSender.StopAutoSend(group.ChatId);
            var result = MessageBox.Show($"Удалить \"{group.Title}\"?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                groupsService.RemoveGroup(group.ChatId);
                ClearGroupSession(group.ChatId);
                if (_selectedChatId == group.ChatId)
                {
                    _selectedChatId = null;
                    SetDefaultState();
                }
            }
        }

        private void OnGroupRemoved(long chatId)
        {
            if (InvokeRequired) { Invoke(() => OnGroupRemoved(chatId)); return; }
            autoSender.StopAutoSend(chatId);
            ClearGroupSession(chatId);
            var cardToRemove = flpConnectedChats.Controls.OfType<ChatCardControl>().FirstOrDefault(c => c.GetGroup()?.ChatId == chatId);
            if (cardToRemove != null) { flpConnectedChats.Controls.Remove(cardToRemove); cardToRemove.Dispose(); }
            UpdateConnectedChatsCount();
            if (_selectedChatId == chatId)
            {
                _selectedChatId = null;
                SetDefaultState();
            }
        }

        private void OnGroupsCleared()
        {
            if (InvokeRequired) { Invoke(OnGroupsCleared); return; }
            ClearConnectedChats();
            _selectedChatId = null;
            foreach (var chatId in _groupSessions.Keys.ToList()) ClearGroupSession(chatId);
            autoSender.StopAll();
            SetDefaultState();
        }

        private void UpdateConnectedChatsCount() { lblConnectedChatsCount.Text = $"Всего групп: {flpConnectedChats.Controls.Count}"; }
        #endregion

        #region Add Group Dialog
        private async void BtnAddConnectedChat_Click(object? sender, EventArgs e)
        {
            if (!telegramBot.IsConnected) { MessageBox.Show("Бот не подключен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            using var inputForm = new Form { Text = "Добавить группу или канал", Size = new Size(450, 200), FormBorderStyle = FormBorderStyle.FixedDialog, StartPosition = FormStartPosition.CenterParent, MaximizeBox = false, MinimizeBox = false, BackColor = Color.FromArgb(27, 29, 36) };
            var lblInstruction = new Label { Text = "Введите @username:\n(например: @telegram)", Location = new Point(10, 10), Size = new Size(410, 40), ForeColor = Color.White, Font = new Font("Segoe UI", 9F) };
            var txtUsername = new TextBox { Location = new Point(10, 55), Size = new Size(410, 25), Font = new Font("Segoe UI", 10F), BackColor = Color.FromArgb(42, 46, 57), ForeColor = Color.White, BorderStyle = BorderStyle.FixedSingle };
            var btnOk = new Button { Text = "Добавить", Location = new Point(240, 100), Size = new Size(90, 30), DialogResult = DialogResult.OK, BackColor = Color.FromArgb(124, 58, 237), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            btnOk.FlatAppearance.BorderSize = 0;
            var btnCancel = new Button { Text = "Отмена", Location = new Point(335, 100), Size = new Size(90, 30), DialogResult = DialogResult.Cancel, BackColor = Color.FromArgb(58, 63, 75), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 9F) };
            btnCancel.FlatAppearance.BorderSize = 0;
            inputForm.Controls.AddRange(new Control[] { lblInstruction, txtUsername, btnOk, btnCancel });
            inputForm.AcceptButton = btnOk;
            inputForm.CancelButton = btnCancel;
            if (inputForm.ShowDialog(this) != DialogResult.OK) return;

            string username = txtUsername.Text.Trim();
            if (string.IsNullOrWhiteSpace(username)) { MessageBox.Show("Введите @username!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (!username.StartsWith("@")) username = "@" + username;

            string originalText = btnAddConnectedChat.Text;
            btnAddConnectedChat.Text = "Проверка...";
            btnAddConnectedChat.Enabled = false;

            try
            {
                var chatInfo = await telegramBot.GetChatByUsernameAsync(username);
                if (chatInfo == null) { MessageBox.Show($"Чат {username} не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                string chatType = chatInfo.Type switch { ChatType.Group => "Группа", ChatType.Supergroup => "Супергруппа", ChatType.Channel => "Канал", ChatType.Private => "Личный чат", _ => chatInfo.Type.ToString() };
                string title = string.IsNullOrWhiteSpace(chatInfo.Title) ? username : chatInfo.Title;
                int members = 0;
                try { members = await telegramBot.GetMembersCountAsync(chatInfo.Id); } catch { }
                string botRole = "Участник";
                try { botRole = await telegramBot.GetBotRoleAsync(chatInfo.Id); } catch { }

                var newGroup = new TelegramGroup { BotId = telegramBot.BotInfo?.Id ?? 0, ChatId = chatInfo.Id, Title = title, Username = chatInfo.Username ?? "", Type = chatType, Members = members, BotRole = botRole, ChatStatus = "Активен", Enabled = true, Selected = true, AddedDate = DateTime.Now, InviteLink = "" };

                if (groupsService.AddOrUpdateGroup(newGroup))
                    MessageBox.Show($"Группа добавлена!\n\nНазвание: {newGroup.Title}\nТип: {newGroup.Type}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Группа уже добавлена!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { btnAddConnectedChat.Enabled = true; btnAddConnectedChat.Text = originalText; }
        }
        #endregion

        #region Cleanup
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null) components.Dispose();
                telegramBot.BotConnected -= OnBotConnected;
                telegramBot.BotDisconnected -= OnBotDisconnected;
                groupsService.GroupAdded -= OnGroupAdded;
                groupsService.GroupUpdated -= OnGroupUpdated;
                groupsService.GroupRemoved -= OnGroupRemoved;
                groupsService.GroupMigrated -= OnGroupMigrated;
                groupsService.GroupsCleared -= OnGroupsCleared;

                foreach (var chatId in _groupSessions.Keys.ToList()) ClearGroupSession(chatId);

                autoSender?.Dispose();

                _designerPlaceholders.Clear();

                foreach (var control in _tabModeControls.Values)
                {
                    control.Dispose();
                }
                _tabModeControls.Clear();
            }
            base.Dispose(disposing);
        }
        #endregion
    }
}