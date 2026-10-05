using BotLauncher.Models.Telegram;
using BotLauncher.Services.Telegram;
using BotLauncher.Shared.Services;
using LiteDB;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot.Types.Enums;

namespace BotLauncher.Controls.Telegram.Groups.TabSendSettings
{
    public partial class ManualTabControl : UserControl
    {
        #region Поля и сервисы

        private readonly TelegramBotService _telegramBot;
        private readonly TelegramTemplatesService _templatesService;
        private readonly LiteDbSettingsStorage _settingsStorage;

        private long? _currentChatId = null;
        private CancellationTokenSource? _cts;
        private readonly System.Windows.Forms.Timer _uiTimer;

        private enum SendState { Idle, WaitingDelay, Sending, GracePeriod, WaitingAutoDelete }
        private SendState _currentState = SendState.Idle;

        private int _delaySecondsRemaining = 0;
        private int _autoDeleteSecondsRemaining = 0;
        private int _gracePeriodSeconds = 0;

        private bool _hasUnsavedChanges = false;

        private int? _sentMessage1Id = null;
        private int? _sentMessage2Id = null;
        private List<int> _diceMessageIds = new();
        private int? _lastSentMessageId = null;
        private int? _lastMessageIdInChat = null;

        private string _sessionTemplateText = "";
        private string _sessionCustomText = "";
        private bool _sessionHasTemplate = false;
        private bool _sessionHasCustomText = false;

        private int _savedDelayMinutes = 0;
        private int _savedDelaySeconds = 0;
        private int _savedAutoDeleteMinutes = 0;
        private int _savedAutoDeleteSeconds = 0;

        #endregion

        #region Конструктор

        public ManualTabControl(TelegramBotService bot, TelegramTemplatesService templates, LiteDbSettingsStorage storage)
        {
            InitializeComponent();
            _telegramBot = bot ?? throw new ArgumentNullException(nameof(bot));
            _templatesService = templates ?? throw new ArgumentNullException(nameof(templates));
            _settingsStorage = storage ?? throw new ArgumentNullException(nameof(storage));

            _uiTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            _uiTimer.Tick += UiTimer_Tick;

            btnSendManual.Click += BtnSendManual_Click;
            btnSaveManual.Click += BtnSaveManual_Click;

            SubscribeToControlEvents();
            SubscribeToCheckBoxDependencies();
            SubscribeToCancelSelectionHandlers();
            SubscribeToFocusHandlers();
            SetupComboBoxes();

            InitializeTooltips();

            RefreshTemplatesList();
            LoadSettingsForCurrentGroup();
            CheckForActiveSession();
        }

        #endregion

        #region Инициализация и настройки UI

        private void SetupComboBoxes()
        {
            var allComboBoxes = new[]
            {
                cmbManualTemplate, cmbManualPinTarget, cmbManualAnimatedEmoji,
                cmbManualEmojiApplyTo, cmbManualAnimatedEffect, cmbManualEffectApplyTo,
                cmbManualNotifySuccess1, cmbManualNotifySuccess2,
                cmbManualNotifyComplete1, cmbManualNotifyComplete2,
                cmbManualNotifyError1, cmbManualNotifyError2
            };

            foreach (var combo in allComboBoxes)
            {
                combo.DropDownAutoWidth = true;
                combo.MaxDropDownItems = 8;
            }
        }

        private void InitializeTooltips()
        {
            toolTip1.SetToolTip(cmbManualTemplate,
                "Выберите шаблон сообщения из списка сохраненных.\n" +
                "Шаблоны создаются во вкладке 'Шаблоны'.\n" +
                "Можно использовать вместе с пользовательским сообщением.\n\n" +
                "💡 Поддерживаемые HTML теги:\n" +
                "<b>жирный</b>, <i>курсив</i>, <u>подчеркнутый</u>\n" +
                "<a href=\"ссылка\">текст ссылки</a>\n" +
                "<blockquote>цитата</blockquote>");

            toolTip1.SetToolTip(txtManualCustomText,
                "Введите текст сообщения вручную.\n" +
                "Поддерживается до 4096 символов.\n" +
                "Можно использовать вместе с шаблоном.\n\n" +
                "💡 Поддерживаемые теги:\n" +
                "{date} - текущая дата\n" +
                "{time} - текущее время\n" +
                "{datetime} - дата и время\n" +
                "{day} - день недели");

            toolTip1.SetToolTip(chkManualDelay,
                "️ Задержка перед отправкой\n" +
                "Откладывает отправку сообщения на указанное время.\n" +
                "Полезно для имитации естественного поведения.\n" +
                "Работает: везде (группы, каналы, личные сообщения)");

            toolTip1.SetToolTip(chkManualAutoDelete,
                "🗑️ Автоудаление после отправки\n" +
                "Автоматически удаляет сообщение через указанное время.\n" +
                "Полезно для временных объявлений.\n" +
                "Работает: везде, где бот может удалять сообщения");

            toolTip1.SetToolTip(chkManualNotifySuccess,
                "📩 Уведомление об успешной отправке\n" +
                "Показывает уведомление после успешной отправки.\n" +
                "Можно выбрать до 2 способов уведомления.");

            toolTip1.SetToolTip(chkManualNotifyComplete,
                "✅ Уведомление о завершении сессии\n" +
                "Показывает уведомление когда все сообщения отправлены.\n" +
                "Полезно при больших задержках между сообщениями.");

            toolTip1.SetToolTip(chkManualNotifyError,
                "⚠️ Уведомление об ошибках\n" +
                "Показывает уведомление если отправка не удалась.\n" +
                "Рекомендуется включить для контроля.");

            toolTip1.SetToolTip(chkManualSendTemplateFirst,
                "🔀 Порядок отправки\n" +
                "✓ Включено: сначала шаблон, потом текст\n" +
                " Выключено: сначала текст, потом шаблон\n" +
                "Работает только если выбраны и шаблон, и текст.");

            toolTip1.SetToolTip(chkManualSilentSend,
                "🔇 Тихая отправка (без звука)\n" +
                "Сообщение придет без звукового уведомления у получателей.\n" +
                "⚠️ Внимание: Не работает при отправке медиафайлов.\n" +
                "Работает: группы, супергруппы, каналы.");

            toolTip1.SetToolTip(chkManualDisablePreview,
                "🔗 Отключить предпросмотр ссылок\n" +
                "Ссылки в тексте не будут показывать картинку или описание сайта.\n" +
                "Полезно для экономии места и чистоты сообщения.\n" +
                "Работает: везде.");

            toolTip1.SetToolTip(chkManualHideSpoiler,
                "🎭 Скрыть содержимое как спойлер\n" +
                "Текст будет скрыт под плашкой 'нажмите чтобы увидеть'.\n" +
                "Полезно для сюрпризов и скрытой информации.\n" +
                "Работает: везде (Telegram 7.0+)");

            toolTip1.SetToolTip(chkManualDeletePrevious,
                "🗑️ Удалить предыдущее сообщение бота\n" +
                "Перед отправкой нового удаляет последнее сообщение бота.\n" +
                "Полезно для обновления информации.\n" +
                "Работает: где бот имеет право удалять сообщения");

            toolTip1.SetToolTip(chkManualReplyToLast,
                "💬 Ответить на последнее сообщение (Reply)\n" +
                "Бот ответит на последнее сообщение в чате.\n" +
                "Создает эффект диалога.\n" +
                "Работает: группы, супергруппы (не в каналах)");

            toolTip1.SetToolTip(chkManualPinMessage,
                "📌 Закрепить сообщение\n" +
                "Закрепляет отправленное сообщение вверху чата.\n" +
                "Требуются права администратора с правом закрепления.\n" +
                "Работает: группы, супергруппы, каналы");

            toolTip1.SetToolTip(chkManualAnimatedEmoji,
                "🎲 Анимированный смайлик (Dice)\n" +
                "Отправляет анимированный эмодзи (кубик, баскетбол и т.д.).\n" +
                "Можно отправить до/после/между сообщениями.\n" +
                "Работает: везде");

            toolTip1.SetToolTip(chkManualAnimatedEffect,
                "✨ Анимированный эффект (Реакция)\n" +
                "Добавляет реакцию под сообщение (лайк, огонь, сердце).\n" +
                "Выглядит как двойной тап в мобильном приложении.\n" +
                "Работает: супергруппы, каналы (требует прав)");

            toolTip1.SetToolTip(chkManualProtectContent,
                " Защитить от копирования и пересылки\n" +
                "Запрещает пересылать сообщение и копировать текст.\n" +
                "Полезно для защиты контента.\n" +
                "Работает: личные сообщения, группы, каналы");

            toolTip1.SetToolTip(chkManualConfirm,
                "❓ Запрашивать подтверждение\n" +
                "Показывает диалог подтверждения перед отправкой.\n" +
                "Защищает от случайной отправки.\n" +
                "Рекомендуется для важных сообщений.");

            toolTip1.SetToolTip(btnSaveManual,
                "💾 Сохранить текущие настройки\n" +
                "Сохраняет все выбранные параметры для этой группы.\n" +
                "Настройки загрузятся автоматически при следующем выборе группы.");

            toolTip1.SetToolTip(btnSendManual,
                " Отправить сообщение сейчас\n" +
                "Начинает отправку с учетом всех настроек.\n" +
                "Если включена задержка — начнется обратный отсчет.");
        }

        public void RefreshTemplatesList()
        {
            string currentSelection = cmbManualTemplate.Text;
            cmbManualTemplate.Items.Clear();
            cmbManualTemplate.Items.Add("");

            try
            {
                var templates = _templatesService.GetAll();
                foreach (var template in templates)
                {
                    cmbManualTemplate.Items.Add(template.Name);
                }

                if (!string.IsNullOrEmpty(currentSelection) && cmbManualTemplate.Items.Contains(currentSelection))
                {
                    cmbManualTemplate.Text = currentSelection;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Ошибка обновления шаблонов: {ex.Message}");
            }

            cmbManualTemplate.Watermark = "Выберите шаблон сообщения";
        }

        private void SubscribeToControlEvents()
        {
            cmbManualTemplate.SelectedIndexChanged += (s, e) => MarkAsChanged();
            cmbManualTemplate.DropDown += (s, e) => RefreshTemplatesList();
            txtManualCustomText.TextChanged += (s, e) => MarkAsChanged();

            cmbManualPinTarget.SelectedIndexChanged += (s, e) => MarkAsChanged();
            cmbManualAnimatedEmoji.SelectedIndexChanged += (s, e) => MarkAsChanged();
            cmbManualEmojiApplyTo.SelectedIndexChanged += (s, e) => MarkAsChanged();
            cmbManualAnimatedEffect.SelectedIndexChanged += (s, e) => MarkAsChanged();
            cmbManualEffectApplyTo.SelectedIndexChanged += (s, e) => MarkAsChanged();

            cmbManualNotifySuccess1.SelectedIndexChanged += (s, e) => MarkAsChanged();
            cmbManualNotifySuccess2.SelectedIndexChanged += (s, e) => MarkAsChanged();
            cmbManualNotifyComplete1.SelectedIndexChanged += (s, e) => MarkAsChanged();
            cmbManualNotifyComplete2.SelectedIndexChanged += (s, e) => MarkAsChanged();
            cmbManualNotifyError1.SelectedIndexChanged += (s, e) => MarkAsChanged();
            cmbManualNotifyError2.SelectedIndexChanged += (s, e) => MarkAsChanged();

            nudManualDelaySeconds.ValueChanged += (s, e) => MarkAsChanged();
            nudManualDelayMinutes.ValueChanged += (s, e) => MarkAsChanged();
            nudManualAutoDeleteSeconds.ValueChanged += (s, e) => MarkAsChanged();
            nudManualAutoDeleteMinutes.ValueChanged += (s, e) => MarkAsChanged();
        }

        private void SubscribeToCancelSelectionHandlers()
        {
            var handlers = new (Sunny.UI.UIComboBox combo, string watermark)[]
            {
                (cmbManualPinTarget, "Выберите что закрепить"),
                (cmbManualEmojiApplyTo, "Применить на"),
                (cmbManualEffectApplyTo, "Применить на"),
                (cmbManualNotifySuccess1, "Куда отправить"),
                (cmbManualNotifySuccess2, "Куда отправить"),
                (cmbManualNotifyComplete1, "Куда отправить"),
                (cmbManualNotifyComplete2, "Куда отправить"),
                (cmbManualNotifyError1, "Куда отправить"),
                (cmbManualNotifyError2, "Куда отправить"),
                (cmbManualAnimatedEmoji, "Выберите смайлик"),
                (cmbManualAnimatedEffect, "Выберите эффект"),
                (cmbManualTemplate, "Выберите шаблон сообщения")
            };

            foreach (var (combo, watermark) in handlers)
            {
                combo.SelectedIndexChanged += (s, e) =>
                {
                    if (combo.Text == "Отменить выбор")
                    {
                        combo.Text = "";
                        combo.Watermark = watermark;
                    }
                };
            }
        }

        private void SubscribeToFocusHandlers()
        {
            pnlManualContent.Click += (s, e) => { this.ActiveControl = null; };
            grpManual.Click += (s, e) => { this.ActiveControl = null; };
            pnlManualInner.Click += (s, e) => { this.ActiveControl = null; };
            txtManualCustomText.Leave += (s, e) => { };
        }

        private void SubscribeToCheckBoxDependencies()
        {
            chkManualDelay.CheckedChanged += (s, e) =>
            {
                nudManualDelaySeconds.Enabled = chkManualDelay.Checked;
                nudManualDelayMinutes.Enabled = chkManualDelay.Checked;
                if (!chkManualDelay.Checked) { nudManualDelaySeconds.Value = 0; nudManualDelayMinutes.Value = 0; }
                MarkAsChanged();
            };

            chkManualAutoDelete.CheckedChanged += (s, e) =>
            {
                nudManualAutoDeleteSeconds.Enabled = chkManualAutoDelete.Checked;
                nudManualAutoDeleteMinutes.Enabled = chkManualAutoDelete.Checked;
                if (!chkManualAutoDelete.Checked) { nudManualAutoDeleteSeconds.Value = 0; nudManualAutoDeleteMinutes.Value = 0; }
                MarkAsChanged();
            };

            chkManualPinMessage.CheckedChanged += (s, e) => { cmbManualPinTarget.Enabled = chkManualPinMessage.Checked; MarkAsChanged(); };
            chkManualAnimatedEmoji.CheckedChanged += (s, e) => { cmbManualAnimatedEmoji.Enabled = cmbManualEmojiApplyTo.Enabled = chkManualAnimatedEmoji.Checked; MarkAsChanged(); };
            chkManualAnimatedEffect.CheckedChanged += (s, e) => { cmbManualAnimatedEffect.Enabled = cmbManualEffectApplyTo.Enabled = chkManualAnimatedEffect.Checked; MarkAsChanged(); };
            chkManualNotifySuccess.CheckedChanged += (s, e) => { cmbManualNotifySuccess1.Enabled = cmbManualNotifySuccess2.Enabled = chkManualNotifySuccess.Checked; MarkAsChanged(); };
            chkManualNotifyComplete.CheckedChanged += (s, e) => { cmbManualNotifyComplete1.Enabled = cmbManualNotifyComplete2.Enabled = chkManualNotifyComplete.Checked; MarkAsChanged(); };
            chkManualNotifyError.CheckedChanged += (s, e) => { cmbManualNotifyError1.Enabled = cmbManualNotifyError2.Enabled = chkManualNotifyError.Checked; MarkAsChanged(); };

            chkManualConfirm.CheckedChanged += (s, e) => MarkAsChanged();
            chkManualSendTemplateFirst.CheckedChanged += (s, e) => MarkAsChanged();
            chkManualSilentSend.CheckedChanged += (s, e) => MarkAsChanged();
            chkManualDisablePreview.CheckedChanged += (s, e) => MarkAsChanged();
            chkManualProtectContent.CheckedChanged += (s, e) => MarkAsChanged();
            chkManualDeletePrevious.CheckedChanged += (s, e) => MarkAsChanged();
            chkManualHideSpoiler.CheckedChanged += (s, e) => MarkAsChanged();
            chkManualReplyToLast.CheckedChanged += (s, e) => MarkAsChanged();
        }

        private void MarkAsChanged() { if (_currentState != SendState.Idle) return; _hasUnsavedChanges = true; UpdateSaveButtonState(); }
        private void UpdateSaveButtonState() { btnSaveManual.Enabled = _hasUnsavedChanges && _currentState == SendState.Idle; }

        #endregion

        #region Переключение группы и Загрузка настроек

        public bool TrySwitchGroup(long newChatId)
        {
            if (_hasUnsavedChanges && _currentState == SendState.Idle)
            {
                if (MessageBox.Show("У вас есть несохранённые изменения. Потерять их и переключить группу?", "Несохранённые изменения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                    return false;
            }
            _currentChatId = newChatId;
            _hasUnsavedChanges = false;
            LoadSettingsForCurrentGroup();
            CheckForActiveSession();
            return true;
        }

        public void SetCurrentGroup(long chatId) { _currentChatId = chatId; LoadSettingsForCurrentGroup(); CheckForActiveSession(); }

        private void LoadSettingsForCurrentGroup()
        {
            if (_currentChatId == null) return;
            var settings = _settingsStorage.LoadManualSettings(_currentChatId.Value);

            RefreshTemplatesList();

            if (settings == null)
            {
                cmbManualTemplate.Text = ""; txtManualCustomText.Text = "";
                chkManualDelay.Checked = false; nudManualDelaySeconds.Value = 0; nudManualDelayMinutes.Value = 0;
                chkManualAutoDelete.Checked = false; nudManualAutoDeleteSeconds.Value = 0; nudManualAutoDeleteMinutes.Value = 0;
                chkManualSendTemplateFirst.Checked = false; chkManualSilentSend.Checked = false; chkManualDisablePreview.Checked = false;
                chkManualProtectContent.Checked = false; chkManualDeletePrevious.Checked = false; chkManualHideSpoiler.Checked = false;
                chkManualReplyToLast.Checked = false;
                chkManualPinMessage.Checked = false; cmbManualPinTarget.Text = "";
                chkManualAnimatedEmoji.Checked = false; cmbManualAnimatedEmoji.Text = ""; cmbManualEmojiApplyTo.Text = "";
                chkManualAnimatedEffect.Checked = false; cmbManualAnimatedEffect.Text = ""; cmbManualEffectApplyTo.Text = "";
                chkManualNotifySuccess.Checked = false; cmbManualNotifySuccess1.Text = ""; cmbManualNotifySuccess2.Text = "";
                chkManualNotifyComplete.Checked = false; cmbManualNotifyComplete1.Text = ""; cmbManualNotifyComplete2.Text = "";
                chkManualNotifyError.Checked = false; cmbManualNotifyError1.Text = ""; cmbManualNotifyError2.Text = "";
                chkManualConfirm.Checked = false;
            }
            else
            {
                cmbManualTemplate.Text = settings.SelectedTemplateName ?? "";
                txtManualCustomText.Text = settings.CustomText ?? "";

                chkManualDelay.Checked = settings.DelaySeconds > 0;
                nudManualDelayMinutes.Value = settings.DelaySeconds / 60;
                nudManualDelaySeconds.Value = settings.DelaySeconds % 60;
                nudManualDelaySeconds.Enabled = nudManualDelayMinutes.Enabled = chkManualDelay.Checked;

                chkManualAutoDelete.Checked = settings.AutoDeleteSeconds > 0;
                nudManualAutoDeleteMinutes.Value = settings.AutoDeleteSeconds / 60;
                nudManualAutoDeleteSeconds.Value = settings.AutoDeleteSeconds % 60;
                nudManualAutoDeleteSeconds.Enabled = nudManualAutoDeleteMinutes.Enabled = chkManualAutoDelete.Checked;

                chkManualSendTemplateFirst.Checked = settings.SendTemplateFirst;
                chkManualSilentSend.Checked = settings.SilentSend;
                chkManualDisablePreview.Checked = settings.DisablePreview;
                chkManualProtectContent.Checked = settings.ProtectContent;
                chkManualDeletePrevious.Checked = settings.DeletePrevious;
                chkManualHideSpoiler.Checked = settings.HideSpoiler;
                chkManualReplyToLast.Checked = settings.ReplyToLast;

                chkManualPinMessage.Checked = settings.PinEnabled;
                cmbManualPinTarget.Text = settings.PinTarget ?? "";
                cmbManualPinTarget.Enabled = settings.PinEnabled;

                chkManualAnimatedEmoji.Checked = settings.AnimatedEmojiEnabled;
                cmbManualAnimatedEmoji.Text = settings.AnimatedEmoji ?? "";
                cmbManualEmojiApplyTo.Text = settings.EmojiApplyTo ?? "";
                cmbManualAnimatedEmoji.Enabled = chkManualAnimatedEmoji.Checked;
                cmbManualEmojiApplyTo.Enabled = chkManualAnimatedEmoji.Checked;

                chkManualAnimatedEffect.Checked = settings.AnimatedEffectEnabled;
                cmbManualAnimatedEffect.Text = settings.AnimatedEffect ?? "";
                cmbManualEffectApplyTo.Text = settings.EffectApplyTo ?? "";
                cmbManualAnimatedEffect.Enabled = chkManualAnimatedEffect.Checked;
                cmbManualEffectApplyTo.Enabled = chkManualAnimatedEffect.Checked;

                chkManualNotifySuccess.Checked = settings.NotifySuccess;
                cmbManualNotifySuccess1.Text = settings.NotifySuccessTarget1 ?? "";
                cmbManualNotifySuccess2.Text = settings.NotifySuccessTarget2 ?? "";
                cmbManualNotifySuccess1.Enabled = cmbManualNotifySuccess2.Enabled = settings.NotifySuccess;

                chkManualNotifyComplete.Checked = settings.NotifyComplete;
                cmbManualNotifyComplete1.Text = settings.NotifyCompleteTarget1 ?? "";
                cmbManualNotifyComplete2.Text = settings.NotifyCompleteTarget2 ?? "";
                cmbManualNotifyComplete1.Enabled = cmbManualNotifyComplete2.Enabled = settings.NotifyComplete;

                chkManualNotifyError.Checked = settings.NotifyError;
                cmbManualNotifyError1.Text = settings.NotifyErrorTarget1 ?? "";
                cmbManualNotifyError2.Text = settings.NotifyErrorTarget2 ?? "";
                cmbManualNotifyError1.Enabled = cmbManualNotifyError2.Enabled = settings.NotifyError;

                chkManualConfirm.Checked = settings.RequestConfirm;
            }

            _hasUnsavedChanges = false;
            UpdateSaveButtonState();
            RefreshHistoryUI();
        }

        private void BtnSaveManual_Click(object? sender, EventArgs e)
        {
            if (_currentChatId == null) { MessageBox.Show("Сначала выберите группу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            int totalDelaySeconds = (int)nudManualDelayMinutes.Value * 60 + (int)nudManualDelaySeconds.Value;
            int totalAutoDeleteSeconds = (int)nudManualAutoDeleteMinutes.Value * 60 + (int)nudManualAutoDeleteSeconds.Value;

            var settings = new ManualSendSettings
            {
                ChatId = _currentChatId.Value,
                SelectedTemplateName = cmbManualTemplate.Text,
                CustomText = txtManualCustomText.Text,
                DelaySeconds = chkManualDelay.Checked ? totalDelaySeconds : 0,
                AutoDeleteSeconds = chkManualAutoDelete.Checked ? totalAutoDeleteSeconds : 0,
                SendTemplateFirst = chkManualSendTemplateFirst.Checked,
                SilentSend = chkManualSilentSend.Checked,
                DisablePreview = chkManualDisablePreview.Checked,
                ProtectContent = chkManualProtectContent.Checked,
                DeletePrevious = chkManualDeletePrevious.Checked,
                HideSpoiler = chkManualHideSpoiler.Checked,
                ReplyToLast = chkManualReplyToLast.Checked,
                PinEnabled = chkManualPinMessage.Checked,
                PinTarget = cmbManualPinTarget.Text,
                AnimatedEmoji = cmbManualAnimatedEmoji.Text,
                EmojiApplyTo = cmbManualEmojiApplyTo.Text,
                AnimatedEffect = cmbManualAnimatedEffect.Text,
                EffectApplyTo = cmbManualEffectApplyTo.Text,
                AnimatedEmojiEnabled = chkManualAnimatedEmoji.Checked,
                AnimatedEffectEnabled = chkManualAnimatedEffect.Checked,
                NotifySuccess = chkManualNotifySuccess.Checked,
                NotifySuccessTarget1 = cmbManualNotifySuccess1.Text,
                NotifySuccessTarget2 = cmbManualNotifySuccess2.Text,
                NotifyComplete = chkManualNotifyComplete.Checked,
                NotifyCompleteTarget1 = cmbManualNotifyComplete1.Text,
                NotifyCompleteTarget2 = cmbManualNotifyComplete2.Text,
                NotifyError = chkManualNotifyError.Checked,
                NotifyErrorTarget1 = cmbManualNotifyError1.Text,
                NotifyErrorTarget2 = cmbManualNotifyError2.Text,
                RequestConfirm = chkManualConfirm.Checked
            };

            _settingsStorage.SaveManualSettings(settings);
            _hasUnsavedChanges = false;
            UpdateSaveButtonState();
            MessageBox.Show("Настройки успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Кнопка "Отправить сейчас" и Фаза отправки

        private async void BtnSendManual_Click(object? sender, EventArgs e)
        {
            if (_currentState != SendState.Idle) { await CancelCurrentOperationAsync(); return; }

            bool hasTemplate = !string.IsNullOrWhiteSpace(cmbManualTemplate.Text);
            bool hasCustomText = !string.IsNullOrWhiteSpace(txtManualCustomText.Text);

            if (!hasTemplate && !hasCustomText) { MessageBox.Show("Выберите шаблон или введите текст сообщения!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (chkManualConfirm.Checked && MessageBox.Show("Вы уверены, что хотите отправить сообщение?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            _sessionHasTemplate = hasTemplate;
            _sessionHasCustomText = hasCustomText;
            _sessionTemplateText = hasTemplate ? cmbManualTemplate.Text : "";
            _sessionCustomText = hasCustomText ? txtManualCustomText.Text : "";

            _savedDelayMinutes = (int)nudManualDelayMinutes.Value;
            _savedDelaySeconds = (int)nudManualDelaySeconds.Value;
            _savedAutoDeleteMinutes = (int)nudManualAutoDeleteMinutes.Value;
            _savedAutoDeleteSeconds = (int)nudManualAutoDeleteSeconds.Value;

            SetUIState(false);
            _cts = new CancellationTokenSource();
            _sentMessage1Id = null; _sentMessage2Id = null; _diceMessageIds.Clear();

            AddHistoryRecord("▶️", "Начат сеанс отправки");

            try
            {
                if (chkManualDelay.Checked)
                {
                    _delaySecondsRemaining = (int)nudManualDelayMinutes.Value * 60 + (int)nudManualDelaySeconds.Value;
                    if (_delaySecondsRemaining > 0)
                    {
                        _currentState = SendState.WaitingDelay;
                        _uiTimer.Start();
                        btnSendManual.Text = "Отмена";
                        AddHistoryRecord("⏳", $"Задержка {_delaySecondsRemaining} секунд...");
                        SaveActiveSession();
                        return;
                    }
                }
                await ExecuteSendPhaseAsync();
            }
            catch (OperationCanceledException) { AddHistoryRecord("❌", "Отменено пользователем"); ResetUIState(); }
            catch (Exception ex) { MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); AddHistoryRecord("❌", $"Ошибка: {ex.Message}"); NotifyUser("Error", $"Ошибка отправки: {ex.Message}"); ResetUIState(); }
        }

        private async Task ExecuteSendPhaseAsync()
        {
            _currentState = SendState.Sending;
            btnSendManual.Text = "Отправка...";
            AddHistoryRecord("", "Начало отправки сообщений...");

            if (chkManualReplyToLast.Checked && _currentChatId.HasValue)
            {
                try
                {
                    _lastMessageIdInChat = await _telegramBot.GetLastMessageIdAsync(_currentChatId!.Value, _cts?.Token ?? CancellationToken.None);
                    if (_lastMessageIdInChat.HasValue)
                    {
                        AddHistoryRecord("", $"Найдено последнее сообщение ID: {_lastMessageIdInChat!.Value}");
                    }
                    else
                    {
                        AddHistoryRecord("⚠️", "Не удалось найти последнее сообщение в чате");
                    }
                }
                catch (Exception ex)
                {
                    AddHistoryRecord("⚠️", $"Ошибка получения последнего сообщения: {ex.Message}");
                    _lastMessageIdInChat = null;
                }
            }
            else
            {
                _lastMessageIdInChat = null;
            }

            if (chkManualDeletePrevious.Checked && _currentChatId.HasValue && _lastSentMessageId.HasValue)
            {
                try { await _telegramBot.DeleteMessageAsync(_currentChatId!.Value, _lastSentMessageId!.Value); AddHistoryRecord("🗑", "Удалено предыдущее сообщение бота"); _lastSentMessageId = null; }
                catch (Exception ex) { AddHistoryRecord("⚠️", $"Не удалось удалить предыдущее: {ex.Message}"); }
            }

            bool sendTemplateFirst = chkManualSendTemplateFirst.Checked;

            string? templateText = _sessionHasTemplate ? GetTemplateText(cmbManualTemplate.Text) : null;
            List<string>? templateAttachments = _sessionHasTemplate ? GetTemplateAttachments(cmbManualTemplate.Text) : null;

            LogToDebug($"[DEBUG] _sessionHasTemplate: {_sessionHasTemplate}");
            LogToDebug($"[DEBUG] _sessionHasCustomText: {_sessionHasCustomText}");
            LogToDebug($"[DEBUG] sendTemplateFirst: {sendTemplateFirst}");
            LogToDebug($"[DEBUG] cmbManualTemplate.Text: '{cmbManualTemplate.Text}'");
            LogToDebug($"[DEBUG] templateAttachments is null: {templateAttachments == null}");

            if (templateAttachments != null)
            {
                LogToDebug($"[DEBUG] templateAttachments count: {templateAttachments.Count}");
                foreach (var path in templateAttachments)
                {
                    LogToDebug($"[DEBUG] Attachment path: '{path}' (Exists: {System.IO.File.Exists(path)})");
                }
            }
            else
            {
                LogToDebug("[DEBUG] ⚠️ Вложения ОТСУТСТВУЮТ (null)!");
            }

            string? customText = _sessionHasCustomText ? txtManualCustomText.Text : null;

            if (chkManualAnimatedEmoji.Checked && cmbManualEmojiApplyTo.Text == "Перед всеми сообщениями") await SendDiceMessagesAsync(null);

            string firstText = sendTemplateFirst ? (templateText ?? customText ?? "") : (customText ?? templateText ?? "");

            // ✅ ИСПРАВЛЕНО: Правильное распределение вложений
            List<string>? firstAttachments = null;
            List<string>? secondAttachments = null;

            if (templateAttachments != null)
            {
                if (_sessionHasTemplate && !_sessionHasCustomText)
                {
                    firstAttachments = templateAttachments;
                    LogToDebug("[DEBUG] ✅ Вложения назначены на ПЕРВОЕ сообщение (только шаблон)");
                }
                else if (_sessionHasTemplate && _sessionHasCustomText)
                {
                    if (sendTemplateFirst)
                    {
                        firstAttachments = templateAttachments;
                        LogToDebug("[DEBUG] ✅ Вложения назначены на ПЕРВОЕ сообщение (шаблон первый)");
                    }
                    else
                    {
                        secondAttachments = templateAttachments;
                        LogToDebug("[DEBUG] ✅ Вложения назначены на ВТОРОЕ сообщение (шаблон второй)");
                    }
                }
            }

            LogToDebug($"[DEBUG] firstAttachments is null: {firstAttachments == null}, count: {firstAttachments?.Count ?? 0}");
            LogToDebug($"[DEBUG] secondAttachments is null: {secondAttachments == null}, count: {secondAttachments?.Count ?? 0}");

            try
            {
                _sentMessage1Id = await SendMessageAsync(_currentChatId!.Value, firstText, firstAttachments);
                if (_sentMessage1Id.HasValue) AddHistoryRecord("✅", $"Отправлен: {Truncate(firstText, 25)}");
                else throw new Exception("Не удалось получить ID отправленного сообщения");
            }
            catch (Exception ex) { AddHistoryRecord("❌", $"Ошибка отправки первого сообщения: {ex.Message}"); NotifyUser("Error", $"Ошибка отправки: {ex.Message}"); ResetUIState(); return; }

            // ✅ ЗАКРЕПЛЕНИЕ ПЕРВОГО СООБЩЕНИЯ
            if (chkManualPinMessage.Checked && _sentMessage1Id.HasValue)
            {
                string target = cmbManualPinTarget.Text;
                bool shouldPinFirst = false;

                // ✅ ИСПРАВЛЕНО: Правильное определение типа первого сообщения
                bool firstIsActuallyTemplate = _sessionHasTemplate && (!_sessionHasCustomText || sendTemplateFirst);
                bool firstIsActuallyText = _sessionHasCustomText && (!_sessionHasTemplate || !sendTemplateFirst);

                if (target.Contains("только текст") && firstIsActuallyText)
                    shouldPinFirst = true;
                else if (target.Contains("только шаблон") && firstIsActuallyTemplate)
                    shouldPinFirst = true;
                else if (target.Contains("оба"))
                    shouldPinFirst = true;

                if (shouldPinFirst)
                {
                    try
                    {
                        await _telegramBot.PinChatMessageAsync(_currentChatId!.Value, _sentMessage1Id!.Value, _cts?.Token ?? CancellationToken.None);
                        AddHistoryRecord("📌", $"Закреплено первое сообщение ({(firstIsActuallyTemplate ? "шаблон" : "текст")})");
                    }
                    catch (Exception ex)
                    {
                        AddHistoryRecord("️", $"Ошибка закрепления первого сообщения: {ex.Message}");
                    }
                }
            }

            if (chkManualAnimatedEmoji.Checked)
            {
                string applyTo = cmbManualEmojiApplyTo.Text;
                bool firstIsActuallyTemplate = _sessionHasTemplate && (!_sessionHasCustomText || sendTemplateFirst);
                bool firstIsActuallyText = _sessionHasCustomText && (!_sessionHasTemplate || !sendTemplateFirst);

                if ((applyTo == "После шаблона" && firstIsActuallyTemplate) || (applyTo == "После пользовательского сообщения" && firstIsActuallyText) || applyTo == "После каждого сообщения")
                    await SendDiceMessagesAsync(_sentMessage1Id);
            }

            if (chkManualAnimatedEffect.Checked)
            {
                string effect = cmbManualAnimatedEffect.Text;
                string applyTo = cmbManualEffectApplyTo.Text;
                if (!string.IsNullOrEmpty(effect) && effect != "Отменить выбор" && !string.IsNullOrEmpty(applyTo) && applyTo != "Отменить выбор")
                {
                    string reactionEmoji = effect.Split(' ')[0];
                    bool shouldApplyReaction = false;
                    bool firstIsActuallyTemplate = _sessionHasTemplate && (!_sessionHasCustomText || sendTemplateFirst);
                    bool firstIsActuallyText = _sessionHasCustomText && (!_sessionHasTemplate || !sendTemplateFirst);

                    if (applyTo == "Только на шаблон" && firstIsActuallyTemplate)
                        shouldApplyReaction = true;
                    else if (applyTo == "Только на текст" && firstIsActuallyText)
                        shouldApplyReaction = true;
                    else if (applyTo == "На оба")
                        shouldApplyReaction = true;

                    if (shouldApplyReaction)
                    {
                        try
                        {
                            bool success = await _telegramBot.SetMessageReactionAsync(_currentChatId!.Value, _sentMessage1Id!.Value, reactionEmoji, _cts?.Token ?? CancellationToken.None);
                            if (success) AddHistoryRecord("⭐", $"Применена реакция {reactionEmoji} к первому сообщению");
                        }
                        catch (Exception ex) { AddHistoryRecord("️", $"Ошибка применения реакции: {ex.Message}"); }
                    }
                }
            }

            if (_sessionHasTemplate && _sessionHasCustomText)
            {
                string secondText = sendTemplateFirst ? customText! : templateText!;
                bool secondIsTemplate = !sendTemplateFirst;
                await Task.Delay(500, _cts?.Token ?? CancellationToken.None);

                try
                {
                    _sentMessage2Id = await SendMessageAsync(_currentChatId!.Value, secondText, secondAttachments);
                    if (_sentMessage2Id.HasValue) AddHistoryRecord("✅", $"Отправлен: {Truncate(secondText, 25)}");
                }
                catch (Exception ex) { AddHistoryRecord("❌", $"Ошибка отправки второго сообщения: {ex.Message}"); }

                // ✅ ЗАКРЕПЛЕНИЕ ВТОРОГО СООБЩЕНИЯ
                if (chkManualPinMessage.Checked && _sentMessage2Id.HasValue)
                {
                    string target = cmbManualPinTarget.Text;
                    bool shouldPinSecond = false;

                    // ✅ ИСПРАВЛЕНО: Правильное определение типа второго сообщения
                    bool secondIsActuallyTemplate = _sessionHasTemplate && (!_sessionHasCustomText || !sendTemplateFirst);
                    bool secondIsActuallyText = _sessionHasCustomText && (!_sessionHasTemplate || sendTemplateFirst);

                    if (target.Contains("только текст") && secondIsActuallyText)
                        shouldPinSecond = true;
                    else if (target.Contains("только шаблон") && secondIsActuallyTemplate)
                        shouldPinSecond = true;
                    else if (target.Contains("оба"))
                        shouldPinSecond = true;

                    if (shouldPinSecond)
                    {
                        try
                        {
                            await _telegramBot.PinChatMessageAsync(_currentChatId!.Value, _sentMessage2Id!.Value, _cts?.Token ?? CancellationToken.None);
                            AddHistoryRecord("📌", $"Закреплено второе сообщение ({(secondIsActuallyTemplate ? "шаблон" : "текст")})");
                        }
                        catch (Exception ex)
                        {
                            AddHistoryRecord("⚠️", $"Ошибка закрепления второго сообщения: {ex.Message}");
                        }
                    }
                }

                if (chkManualAnimatedEmoji.Checked)
                {
                    string applyTo = cmbManualEmojiApplyTo.Text;
                    bool secondIsActuallyTemplate = _sessionHasTemplate && (!_sessionHasCustomText || !sendTemplateFirst);
                    bool secondIsActuallyText = _sessionHasCustomText && (!_sessionHasTemplate || sendTemplateFirst);

                    if ((applyTo == "После шаблона" && secondIsActuallyTemplate) || (applyTo == "После пользовательского сообщения" && secondIsActuallyText) || applyTo == "После каждого сообщения")
                        await SendDiceMessagesAsync(_sentMessage2Id);
                }

                if (chkManualAnimatedEffect.Checked)
                {
                    string effect = cmbManualAnimatedEffect.Text;
                    string applyTo = cmbManualEffectApplyTo.Text;
                    if (!string.IsNullOrEmpty(effect) && effect != "Отменить выбор" && !string.IsNullOrEmpty(applyTo) && applyTo != "Отменить выбор")
                    {
                        string reactionEmoji = effect.Split(' ')[0];
                        bool shouldApplyReaction = false;
                        bool secondIsActuallyTemplate = _sessionHasTemplate && (!_sessionHasCustomText || !sendTemplateFirst);
                        bool secondIsActuallyText = _sessionHasCustomText && (!_sessionHasTemplate || sendTemplateFirst);

                        if (applyTo == "Только на шаблон" && secondIsActuallyTemplate)
                            shouldApplyReaction = true;
                        else if (applyTo == "Только на текст" && secondIsActuallyText)
                            shouldApplyReaction = true;
                        else if (applyTo == "На оба")
                            shouldApplyReaction = true;

                        if (shouldApplyReaction)
                        {
                            try
                            {
                                bool success = await _telegramBot.SetMessageReactionAsync(_currentChatId!.Value, _sentMessage2Id!.Value, reactionEmoji, _cts?.Token ?? CancellationToken.None);
                                if (success) AddHistoryRecord("⭐", $"Применена реакция {reactionEmoji} ко второму сообщению");
                            }
                            catch (Exception ex) { AddHistoryRecord("⚠️", $"Ошибка применения реакции: {ex.Message}"); }
                        }
                    }
                }
            }

            if (chkManualAnimatedEmoji.Checked && cmbManualEmojiApplyTo.Text == "После всех сообщений") await SendDiceMessagesAsync(null);

            AddHistoryRecord("✅", "Сообщение успешно отправлено");
            NotifyUser("Success", "Сообщение успешно отправлено!");

            _lastSentMessageId = _sentMessage2Id ?? _sentMessage1Id;

            if (chkManualAutoDelete.Checked)
            {
                _autoDeleteSecondsRemaining = (int)nudManualAutoDeleteMinutes.Value * 60 + (int)nudManualAutoDeleteSeconds.Value;
                if (_autoDeleteSecondsRemaining > 0)
                {
                    _currentState = SendState.WaitingAutoDelete;
                    _uiTimer.Start();
                    btnSendManual.Text = "Отмена";
                    AddHistoryRecord("⏳", $"Автоудаление через {_autoDeleteSecondsRemaining} секунд...");
                    SavePendingDeletions();
                    SaveActiveSession();
                    return;
                }
            }

            if (!chkManualDelay.Checked && !chkManualAutoDelete.Checked)
            {
                _currentState = SendState.GracePeriod;
                _gracePeriodSeconds = 5;
                _uiTimer.Start();
                btnSendManual.Text = $"Отмена ({_gracePeriodSeconds} сек)";
                AddHistoryRecord("⏳", "5 секунд на отмену...");
                SaveActiveSession();
                return;
            }
            FinishSession();
        }

        #endregion

        #region Отправка сообщений и Эффекты

        private string GetTemplateText(string templateName)
        {
            if (string.IsNullOrWhiteSpace(templateName)) return "";
            try
            {
                var template = _templatesService.GetAll().FirstOrDefault(t => t.Name == templateName);
                if (template?.Message != null)
                {
                    return ProcessTemplateTags(template.Message);
                }
                return $"[Шаблон: {templateName}]";
            }
            catch { return $"[Шаблон: {templateName}]"; }
        }

        private List<string>? GetTemplateAttachments(string templateName)
        {
            if (string.IsNullOrWhiteSpace(templateName)) return null;
            try
            {
                var template = _templatesService.GetAll().FirstOrDefault(t => t.Name == templateName);
                if (template?.Attachments != null)
                {
                    LogToDebug($"[DEBUG GetTemplateAttachments] Найдено {template.Attachments.Count} вложений для шаблона '{templateName}'");
                }
                else
                {
                    LogToDebug($"[DEBUG GetTemplateAttachments] Вложения null для шаблона '{templateName}'");
                }
                return template?.Attachments;
            }
            catch { return null; }
        }

        private string ProcessTemplateTags(string text)
        {
            if (string.IsNullOrEmpty(text)) return text;

            text = text.Replace("{date}", DateTime.Now.ToString("dd.MM.yyyy"));
            text = text.Replace("{time}", DateTime.Now.ToString("HH:mm"));
            text = text.Replace("{datetime}", DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
            text = text.Replace("{day}", DateTime.Now.ToString("dddd", new System.Globalization.CultureInfo("ru-RU")));

            return text;
        }

        private async Task<int?> SendMessageAsync(long chatId, string text, List<string>? attachments = null)
        {
            int? replyToMessageId = chkManualReplyToLast.Checked ? _lastMessageIdInChat : null;

            ParseMode? parseMode = ParseMode.Html;

            LogToDebug($"[DEBUG SendMessageAsync] attachments is null: {attachments == null}, count: {attachments?.Count ?? 0}");

            if (attachments != null && attachments.Count > 0)
            {
                LogToDebug($"[DEBUG SendMessageAsync] Вызываем SendMediaAsync...");
                return await _telegramBot.SendMediaAsync(
                    chatId,
                    text,
                    attachments,
                    chkManualSilentSend.Checked,
                    chkManualDisablePreview.Checked,
                    chkManualHideSpoiler.Checked,
                    chkManualProtectContent.Checked,
                    replyToMessageId,
                    parseMode
                );
            }

            LogToDebug($"[DEBUG SendMessageAsync] Вызываем SendMessageAsync (только текст)...");
            return await _telegramBot.SendMessageAsync(
                chatId,
                text,
                chkManualSilentSend.Checked,
                chkManualDisablePreview.Checked,
                chkManualHideSpoiler.Checked,
                chkManualProtectContent.Checked,
                replyToMessageId,
                parseMode
            );
        }

        private async Task SendDiceMessagesAsync(int? afterMessageId)
        {
            if (!chkManualAnimatedEmoji.Checked) return;
            string emoji = cmbManualAnimatedEmoji.Text;
            if (string.IsNullOrEmpty(emoji) || emoji == "Отменить выбор") return;

            string diceEmoji = emoji switch { "Кубик" => "🎲", "Мяч баскетбольный" => "🏀", "Слот-машина" => "", "Дартс" => "🎯", _ => "🎲" };

            try
            {
                var msgId = await _telegramBot.SendDiceAsync(_currentChatId!.Value, diceEmoji, _cts?.Token ?? CancellationToken.None);
                if (msgId.HasValue) { _diceMessageIds.Add(msgId.Value); AddHistoryRecord("🎲", $"Отправлен смайлик: {emoji}"); }
                else AddHistoryRecord("⚠️", $"Смайлик {emoji} не отправлен");
            }
            catch (Exception ex) { AddHistoryRecord("⚠️", $"Ошибка отправки смайлика: {ex.Message}"); }
        }

        private async Task ApplyEffectsAsync()
        {
            if (!chkManualAnimatedEffect.Checked) return;
            string effect = cmbManualAnimatedEffect.Text;
            string applyTo = cmbManualEffectApplyTo.Text;

            if (string.IsNullOrEmpty(effect) || effect == "Отменить выбор" || string.IsNullOrEmpty(applyTo) || applyTo == "Отменить выбор") return;

            string reactionEmoji = effect.Split(' ')[0];

            var targets = new List<(int messageId, string type)>();

            if (applyTo == "Только на шаблон")
            {
                if (IsFirstTemplate() && _sentMessage1Id.HasValue) targets.Add((_sentMessage1Id.Value, "шаблон"));
                else if (!IsFirstTemplate() && _sentMessage2Id.HasValue) targets.Add((_sentMessage2Id.Value, "шаблон"));
            }
            else if (applyTo == "Только на текст")
            {
                if (!IsFirstTemplate() && _sentMessage1Id.HasValue) targets.Add((_sentMessage1Id.Value, "текст"));
                else if (IsFirstTemplate() && _sentMessage2Id.HasValue) targets.Add((_sentMessage2Id.Value, "текст"));
            }
            else if (applyTo == "На оба")
            {
                if (_sentMessage1Id.HasValue) targets.Add((_sentMessage1Id.Value, IsFirstTemplate() ? "шаблон" : "текст"));
                if (_sentMessage2Id.HasValue) targets.Add((_sentMessage2Id.Value, IsFirstTemplate() ? "текст" : "шаблон"));
            }

            foreach (var (msgId, type) in targets)
            {
                try
                {
                    bool success = await _telegramBot.SetMessageReactionAsync(_currentChatId!.Value, msgId, reactionEmoji, _cts?.Token ?? CancellationToken.None);
                    if (success) AddHistoryRecord("⭐", $"Применена реакция {reactionEmoji} к {type}");
                    else AddHistoryRecord("⚠️", $"Не удалось применить реакцию к {type}");
                }
                catch (Exception ex) { AddHistoryRecord("⚠️", $"Ошибка применения реакции: {ex.Message}"); }
            }
        }

        private bool IsFirstTemplate() => chkManualSendTemplateFirst.Checked ? _sessionHasTemplate : _sessionHasCustomText;

        private async Task HandlePinningAsync()
        {
            if (!chkManualPinMessage.Checked || _currentChatId == null) return;
            string target = cmbManualPinTarget.Text;
            if (string.IsNullOrEmpty(target) || target == "Отменить выбор") return;

            try
            {
                int? messageIdToPin = null;
                if (target.Contains("только текст"))
                {
                    if (_sessionHasCustomText) messageIdToPin = (IsFirstTemplate() == false && _sentMessage1Id.HasValue) ? _sentMessage1Id.Value : (IsFirstTemplate() == true && _sentMessage2Id.HasValue) ? _sentMessage2Id.Value : null;
                }
                else if (target.Contains("только шаблон"))
                {
                    if (_sessionHasTemplate) messageIdToPin = (IsFirstTemplate() && _sentMessage1Id.HasValue) ? _sentMessage1Id.Value : (!IsFirstTemplate() && _sentMessage2Id.HasValue) ? _sentMessage2Id.Value : null;
                }
                else if (target.Contains("оба"))
                {
                    bool templateFirst = target.Contains("сначала шаблон");
                    if (templateFirst) messageIdToPin = (_sessionHasCustomText && (!IsFirstTemplate() && _sentMessage1Id.HasValue)) ? _sentMessage1Id.Value : (IsFirstTemplate() && _sentMessage2Id.HasValue) ? _sentMessage2Id.Value : _sentMessage1Id;
                    else messageIdToPin = (_sessionHasTemplate && (IsFirstTemplate() && _sentMessage1Id.HasValue)) ? _sentMessage1Id.Value : (!IsFirstTemplate() && _sentMessage2Id.HasValue) ? _sentMessage2Id.Value : _sentMessage1Id;
                }

                if (messageIdToPin.HasValue) { await _telegramBot.PinChatMessageAsync(_currentChatId!.Value, messageIdToPin!.Value, _cts?.Token ?? CancellationToken.None); AddHistoryRecord("📌", $"Закреплено: {target}"); }
                else AddHistoryRecord("⚠️", $"Не найдено сообщение для закрепления: {target}");
            }
            catch (Exception ex) { AddHistoryRecord("⚠️", $"Ошибка закрепления: {ex.Message}"); }
        }

        #endregion

        #region Таймер, Отмена и Завершение

        private async void UiTimer_Tick(object? sender, EventArgs e)
        {
            if (_currentState == SendState.WaitingDelay)
            {
                _delaySecondsRemaining--; UpdateDelayDisplay(); btnSendManual.Text = "Отмена"; UpdateActiveSessionRemaining(_delaySecondsRemaining);
                if (_delaySecondsRemaining <= 0) { _uiTimer.Stop(); AddHistoryRecord("⏳", "Задержка завершена"); await ExecuteSendPhaseAsync(); }
            }
            else if (_currentState == SendState.WaitingAutoDelete)
            {
                _autoDeleteSecondsRemaining--; UpdateAutoDeleteDisplay(); btnSendManual.Text = "Отмена"; UpdateActiveSessionRemaining(_autoDeleteSecondsRemaining);
                if (_autoDeleteSecondsRemaining <= 0) { _uiTimer.Stop(); await ExecuteAutoDeletePhaseAsync(); }
            }
            else if (_currentState == SendState.GracePeriod)
            {
                _gracePeriodSeconds--; btnSendManual.Text = $"Отмена ({_gracePeriodSeconds} сек)"; UpdateActiveSessionRemaining(_gracePeriodSeconds);
                if (_gracePeriodSeconds <= 0) { _uiTimer.Stop(); AddHistoryRecord("🏁", "Сеанс завершён (время вышло)"); FinishSession(); }
            }
        }

        private void UpdateDelayDisplay() { nudManualDelayMinutes.Value = _delaySecondsRemaining / 60; nudManualDelaySeconds.Value = _delaySecondsRemaining % 60; }
        private void UpdateAutoDeleteDisplay() { nudManualAutoDeleteMinutes.Value = _autoDeleteSecondsRemaining / 60; nudManualAutoDeleteSeconds.Value = _autoDeleteSecondsRemaining % 60; }

        private async Task ExecuteAutoDeletePhaseAsync()
        {
            _currentState = SendState.Sending; btnSendManual.Text = "Удаление..."; AddHistoryRecord("🗑", "Автоудаление сообщений...");
            try
            {
                if (_sentMessage1Id.HasValue) await DeleteMessageAsync(_sentMessage1Id.Value);
                if (_sentMessage2Id.HasValue) await DeleteMessageAsync(_sentMessage2Id.Value);
                foreach (var diceId in _diceMessageIds) await DeleteMessageAsync(diceId);
                AddHistoryRecord("✅", "Сообщения автоудалены"); RemovePendingDeletions();
            }
            catch (Exception ex) { AddHistoryRecord("❌", $"Ошибка автоудаления: {ex.Message}"); }
            finally { RemoveActiveSession(); FinishSession(); }
        }

        private async Task CancelCurrentOperationAsync()
        {
            _cts?.Cancel(); _uiTimer.Stop(); AddHistoryRecord("❌", "Отменено пользователем");
            try
            {
                if (_sentMessage1Id.HasValue) await DeleteMessageAsync(_sentMessage1Id.Value);
                if (_sentMessage2Id.HasValue) await DeleteMessageAsync(_sentMessage2Id.Value);
                foreach (var diceId in _diceMessageIds) await DeleteMessageAsync(diceId);
                if (_sentMessage1Id.HasValue || _sentMessage2Id.HasValue) AddHistoryRecord("🗑", "Отправленные сообщения удалены");
            }
            catch (Exception ex) { AddHistoryRecord("⚠️", $"Ошибка удаления при отмене: {ex.Message}"); }
            RemovePendingDeletions(); RemoveActiveSession(); NotifyUser("Cancelled", "Операция отменена пользователем"); ResetUIState();
        }

        private async Task DeleteMessageAsync(int messageId) => await _telegramBot.DeleteMessageAsync(_currentChatId!.Value, messageId);

        private void FinishSession() { RemoveActiveSession(); ResetUIState(); AddHistoryRecord("🏁", "Сеанс завершён"); }

        private void ResetUIState()
        {
            _currentState = SendState.Idle; _uiTimer.Stop(); SetUIState(true); btnSendManual.Text = "Отправить сейчас";
            nudManualDelayMinutes.Value = _savedDelayMinutes; nudManualDelaySeconds.Value = _savedDelaySeconds;
            nudManualAutoDeleteMinutes.Value = _savedAutoDeleteMinutes; nudManualAutoDeleteSeconds.Value = _savedAutoDeleteSeconds;
        }

        private void SetUIState(bool enabled)
        {
            cmbManualTemplate.Enabled = enabled; txtManualCustomText.Enabled = enabled;
            chkManualDelay.Enabled = chkManualAutoDelete.Enabled = chkManualSendTemplateFirst.Enabled = chkManualSilentSend.Enabled = chkManualDisablePreview.Enabled = chkManualProtectContent.Enabled = chkManualDeletePrevious.Enabled = chkManualHideSpoiler.Enabled = chkManualReplyToLast.Enabled = enabled;
            chkManualPinMessage.Enabled = enabled; cmbManualPinTarget.Enabled = enabled && chkManualPinMessage.Checked;
            chkManualAnimatedEmoji.Enabled = enabled; cmbManualAnimatedEmoji.Enabled = cmbManualEmojiApplyTo.Enabled = enabled && chkManualAnimatedEmoji.Checked;
            chkManualAnimatedEffect.Enabled = enabled; cmbManualAnimatedEffect.Enabled = cmbManualEffectApplyTo.Enabled = enabled && chkManualAnimatedEffect.Checked;
            chkManualNotifySuccess.Enabled = enabled; cmbManualNotifySuccess1.Enabled = cmbManualNotifySuccess2.Enabled = enabled && chkManualNotifySuccess.Checked;
            chkManualNotifyComplete.Enabled = enabled; cmbManualNotifyComplete1.Enabled = cmbManualNotifyComplete2.Enabled = enabled && chkManualNotifyComplete.Checked;
            chkManualNotifyError.Enabled = enabled; cmbManualNotifyError1.Enabled = cmbManualNotifyError2.Enabled = enabled && chkManualNotifyError.Checked;
            chkManualConfirm.Enabled = enabled;

            nudManualDelaySeconds.Enabled = nudManualDelayMinutes.Enabled = enabled && chkManualDelay.Checked;
            nudManualAutoDeleteSeconds.Enabled = nudManualAutoDeleteMinutes.Enabled = enabled && chkManualAutoDelete.Checked;

            btnSaveManual.Enabled = _hasUnsavedChanges && _currentState == SendState.Idle;

            if (_currentState == SendState.WaitingDelay || _currentState == SendState.WaitingAutoDelete) btnSendManual.Text = "Отмена";
            else if (_currentState == SendState.GracePeriod) btnSendManual.Text = $"Отмена ({_gracePeriodSeconds} сек)";
            else if (_currentState == SendState.Sending) btnSendManual.Text = "Отправка...";
            else btnSendManual.Text = "Отправить сейчас";
        }

        #endregion

        #region История, Уведомления и Сессии

        private void AddHistoryRecord(string icon, string message)
        {
            if (_currentChatId == null) return;
            _settingsStorage.SaveSendHistory(new SendHistoryRecord { ChatId = _currentChatId.Value, Timestamp = DateTime.Now, Icon = icon, Message = message, TemplateText = _sessionTemplateText, CustomText = _sessionCustomText });
            RefreshHistoryUI();
        }

        private void RefreshHistoryUI()
        {
            if (InvokeRequired) { Invoke(new Action(RefreshHistoryUI)); return; }
            flpManualHistory.Controls.Clear();
            if (_currentChatId == null) return;

            foreach (var record in _settingsStorage.GetSendHistory(_currentChatId.Value).OrderByDescending(r => r.Timestamp).Take(50))
            {
                var panel = new Panel { Size = new Size(flpManualHistory.Width - 20, 30), Margin = new Padding(2), BackColor = Color.FromArgb(42, 46, 57) };
                var lbl = new Label { Text = $"[{record.Timestamp:HH:mm:ss}] {record.Icon} {record.Message}", Location = new Point(5, 5), Size = new Size(panel.Width - 80, 20), ForeColor = record.Icon == "❌" ? Color.OrangeRed : (record.Icon == "✅" ? Color.Lime : Color.White), Font = new Font("Segoe UI", 8.5F) };
                var btnDelete = new Button { Text = "", Location = new Point(panel.Width - 35, 3), Size = new Size(30, 24), FlatStyle = FlatStyle.Flat, BackColor = Color.Transparent, ForeColor = Color.Gray };
                btnDelete.FlatAppearance.BorderSize = 0;
                btnDelete.Click += (s, e) => { _settingsStorage.DeleteSendHistory(record.Id); RefreshHistoryUI(); };
                panel.Controls.Add(lbl); panel.Controls.Add(btnDelete);
                flpManualHistory.Controls.Add(panel);
            }
        }

        private void NotifyUser(string type, string message)
        {
            List<string> targets = new();
            if (type == "Success" && chkManualNotifySuccess.Checked) { if (!string.IsNullOrEmpty(cmbManualNotifySuccess1.Text)) targets.Add(cmbManualNotifySuccess1.Text); if (!string.IsNullOrEmpty(cmbManualNotifySuccess2.Text)) targets.Add(cmbManualNotifySuccess2.Text); }
            else if (type == "Complete" && chkManualNotifyComplete.Checked) { if (!string.IsNullOrEmpty(cmbManualNotifyComplete1.Text)) targets.Add(cmbManualNotifyComplete1.Text); if (!string.IsNullOrEmpty(cmbManualNotifyComplete2.Text)) targets.Add(cmbManualNotifyComplete2.Text); }
            else if (type == "Error" && chkManualNotifyError.Checked) { if (!string.IsNullOrEmpty(cmbManualNotifyError1.Text)) targets.Add(cmbManualNotifyError1.Text); if (!string.IsNullOrEmpty(cmbManualNotifyError2.Text)) targets.Add(cmbManualNotifyError2.Text); }

            foreach (var target in targets)
            {
                if (target == "В личные сообщения") MessageBox.Show("Функция 'В личные сообщения' в разработке", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (target == "В приложении") ShowAppNotification(message);
            }
        }

        private void ShowAppNotification(string message)
        {
            var form = new Form { Text = "Уведомление Bot Launcher", Size = new Size(400, 150), StartPosition = FormStartPosition.CenterParent, FormBorderStyle = FormBorderStyle.FixedDialog, MaximizeBox = false, MinimizeBox = false, BackColor = Color.FromArgb(35, 39, 48) };
            var lbl = new Label { Text = message, Location = new Point(20, 20), Size = new Size(360, 60), ForeColor = Color.White, Font = new Font("Segoe UI", 10F) };
            var btnOk = new Button { Text = "OK", Location = new Point(150, 80), Size = new Size(100, 30), DialogResult = DialogResult.OK, BackColor = Color.BlueViolet, ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
            btnOk.FlatAppearance.BorderSize = 0;
            form.Controls.Add(lbl); form.Controls.Add(btnOk); form.AcceptButton = btnOk;
            form.ShowDialog();
        }

        private void SaveActiveSession()
        {
            if (_currentChatId == null) return;
            _settingsStorage.SaveActiveSession(new ActiveSession { ChatId = _currentChatId.Value, State = _currentState.ToString(), RemainingSeconds = _currentState switch { SendState.WaitingDelay => _delaySecondsRemaining, SendState.WaitingAutoDelete => _autoDeleteSecondsRemaining, SendState.GracePeriod => _gracePeriodSeconds, _ => 0 }, SentMessage1Id = _sentMessage1Id, SentMessage2Id = _sentMessage2Id, DiceMessageIds = _diceMessageIds, HasTemplate = _sessionHasTemplate, HasCustomText = _sessionHasCustomText, TemplateText = _sessionTemplateText, CustomText = _sessionCustomText });
            AddHistoryRecord("💾", "Сеанс сохранён в базу");
        }

        private void UpdateActiveSessionRemaining(int seconds) { if (_currentChatId != null) _settingsStorage.UpdateActiveSessionRemaining(_currentChatId.Value, seconds); }
        private void RemoveActiveSession() { if (_currentChatId != null) _settingsStorage.RemoveActiveSession(_currentChatId.Value); }

        private void SavePendingDeletions()
        {
            if (_currentChatId == null) return;
            var deleteAt = DateTime.Now.AddSeconds(_autoDeleteSecondsRemaining);
            if (_sentMessage1Id.HasValue) _settingsStorage.SavePendingDeletion(new PendingDeletion { ChatId = _currentChatId.Value, MessageId = _sentMessage1Id.Value, DeleteAt = deleteAt });
            if (_sentMessage2Id.HasValue) _settingsStorage.SavePendingDeletion(new PendingDeletion { ChatId = _currentChatId.Value, MessageId = _sentMessage2Id.Value, DeleteAt = deleteAt });
            foreach (var diceId in _diceMessageIds) _settingsStorage.SavePendingDeletion(new PendingDeletion { ChatId = _currentChatId.Value, MessageId = diceId, DeleteAt = deleteAt });
        }

        private void RemovePendingDeletions() { if (_currentChatId != null) _settingsStorage.RemovePendingDeletions(_currentChatId.Value); }

        private void CheckForActiveSession()
        {
            if (_currentChatId == null) return;
            var session = _settingsStorage.LoadActiveSession(_currentChatId.Value);
            if (session == null) return;

            _sessionHasTemplate = session.HasTemplate; _sessionHasCustomText = session.HasCustomText;
            _sessionTemplateText = session.TemplateText ?? ""; _sessionCustomText = session.CustomText ?? "";
            _sentMessage1Id = session.SentMessage1Id; _sentMessage2Id = session.SentMessage2Id;
            _diceMessageIds = session.DiceMessageIds ?? new List<int>();

            AddHistoryRecord("🔄", "Программа перезапущена");
            AddHistoryRecord("🔍", $"Найдена активная сессия (осталось {session.RemainingSeconds} сек)");

            SetUIState(false); _cts = new CancellationTokenSource();

            if (Enum.TryParse<SendState>(session.State, out var state))
            {
                _currentState = state;
                switch (state)
                {
                    case SendState.WaitingDelay: _delaySecondsRemaining = session.RemainingSeconds; UpdateDelayDisplay(); btnSendManual.Text = "Отмена"; AddHistoryRecord("♻️", "Сеанс восстановлен (задержка)"); _uiTimer.Start(); break;
                    case SendState.WaitingAutoDelete: _autoDeleteSecondsRemaining = session.RemainingSeconds; UpdateAutoDeleteDisplay(); btnSendManual.Text = "Отмена"; AddHistoryRecord("♻️", "Сеанс восстановлен (автоудаление)"); _uiTimer.Start(); break;
                    case SendState.GracePeriod: _gracePeriodSeconds = session.RemainingSeconds; btnSendManual.Text = $"Отмена ({_gracePeriodSeconds} сек)"; AddHistoryRecord("♻️", "Сеанс восстановлен (5 сек на отмену)"); _uiTimer.Start(); break;
                    case SendState.Sending: btnSendManual.Text = "Отправка..."; AddHistoryRecord("⚠️", "Отправка прервана перезапуском"); ResetUIState(); break;
                }
            }
        }

        #endregion

        #region Вспомогательные методы

        private void LogToDebug(string message)
        {
            try
            {
                string logPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bot_debug.log");
                System.IO.File.AppendAllText(logPath, $"[{DateTime.Now:HH:mm:ss.fff}] [UI] {message}{Environment.NewLine}");
            }
            catch { }
        }

        private string Truncate(string text, int maxLength) => string.IsNullOrEmpty(text) ? "" : (text.Length > maxLength ? text.Substring(0, maxLength) + "..." : text);

        #endregion
    }
}