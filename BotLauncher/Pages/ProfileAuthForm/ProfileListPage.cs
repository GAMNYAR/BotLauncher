using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BotLauncher.Controls;
using BotLauncher.Services.Telegram;
using ProfileAuthWindow = global::BotLauncher.ProfileAuthForm;

namespace BotLauncher.Pages.ProfileAuthForm
{
    public partial class ProfileListPage : UserControl
    {
        private readonly TelegramProfileManager profileManager;
        private readonly string dataFolder;

        public ProfileListPage()
        {
            InitializeComponent();

            profileManager = new TelegramProfileManager();
            dataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

            this.Load += ProfileListPage_Load;
            this.Resize += ProfileListPage_Resize;
            btnRefresh.Click += BtnRefresh_Click;
            btnBack.Click += BtnBack_Click;
            btnCreateProfile.Click += BtnCreateProfile_Click;
            btnImportProfile.Click += BtnImportProfile_Click;

            // =========================================================
            // РАСТЯГИВАНИЕ КАРТОЧЕК ПО ШИРИНЕ
            // =========================================================
            if (scrollPanel != null && tableLayoutPanelProfiles != null)
            {
                scrollPanel.Resize += (s, e) => UpdateTableWidth();
                // Устанавливаем ширину сразу при загрузке
                this.Load += (s, e) => UpdateTableWidth();
            }
            // =========================================================
        }

        private void ProfileListPage_Load(object? sender, EventArgs e)
        {
            InitializeTooltips();
            LoadProfiles();
        }

        private void ProfileListPage_Resize(object? sender, EventArgs e)
        {
            UpdateCardWidths();
        }

        // =========================================================
        // Обновление ширины таблицы (чтобы карточки растягивались)
        // =========================================================
        private void UpdateTableWidth()
        {
            if (scrollPanel != null && tableLayoutPanelProfiles != null)
            {
                // Устанавливаем ширину таблицы равной ширине панели минус небольшие отступы
                tableLayoutPanelProfiles.Width = scrollPanel.ClientSize.Width - 20;
            }
        }

        private void UpdateCardWidths()
        {
            if (tableLayoutPanelProfiles == null) return;

            foreach (Control control in tableLayoutPanelProfiles.Controls)
            {
                if (control is ProfileCardControl card)
                {
                    card.Invalidate();
                }
            }
        }

        private void InitializeTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnBack, "Вернуться на главный экран");
            toolTip.SetToolTip(btnRefresh, "Обновить список профилей");
            toolTip.SetToolTip(btnCreateProfile, "Создать новый профиль с нуля");
            toolTip.SetToolTip(btnImportProfile, "Импортировать существующий профиль из файла");
        }

        // =========================================================
        // Загрузка профилей
        // =========================================================
        private void LoadProfiles()
        {
            tableLayoutPanelProfiles.SuspendLayout();

            try
            {
                tableLayoutPanelProfiles.Controls.Clear();
                tableLayoutPanelProfiles.RowStyles.Clear();
                tableLayoutPanelProfiles.RowCount = 0;

                if (!Directory.Exists(dataFolder))
                {
                    lblTitle.Text = "Ваши профили";
                    pnlEmptyState.Text = "Папка Data не найдена";
                    tableLayoutPanelProfiles.Visible = false;
                    return;
                }

                string[] files = Directory.GetFiles(dataFolder, "*.blp");

                if (files.Length == 0)
                {
                    lblTitle.Text = "Ваши профили";
                    pnlEmptyState.Text = "Список профилей пуст.\nНажмите \"Создать новый профиль\" или импортируйте существующий.";
                    tableLayoutPanelProfiles.Visible = false;
                    return;
                }

                lblTitle.Text = $"Ваши профили ({files.Length})";
                pnlEmptyState.Text = "";
                tableLayoutPanelProfiles.Visible = true;

                foreach (string file in files)
                {
                    try
                    {
                        string fileName = Path.GetFileNameWithoutExtension(file);
                        DateTime lastModified = File.GetLastWriteTime(file);

                        // Читаем username из незашифрованного заголовка (или вернет @unknown для старых файлов)
                        string username = profileManager.GetBotUsernameFromFile(file);

                        AddProfileCard(fileName, file, lastModified, username);
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Ошибка при загрузке {file}: {ex.Message}");
                    }
                }

                // После добавления всех карточек обновляем ширину
                UpdateTableWidth();
            }
            finally
            {
                tableLayoutPanelProfiles.ResumeLayout();
            }
        }

        // =========================================================
        // Добавление карточки профиля
        // =========================================================
        private void AddProfileCard(string profileName, string filePath, DateTime lastModified, string username)
        {
            ProfileCardControl card = new ProfileCardControl();

            // Передаем данные в карточку
            card.SetData(profileName, filePath, lastModified, username);

            // Подписываемся на все события карточки
            card.OpenRequested += OnOpenRequested;
            card.DeleteRequested += OnDeleteRequested;
            card.MigrateRequested += OnMigrateRequested;

            tableLayoutPanelProfiles.RowCount++;
            tableLayoutPanelProfiles.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelProfiles.Controls.Add(card, 0, tableLayoutPanelProfiles.RowCount - 1);

            card.Dock = DockStyle.Fill;
            card.Margin = new Padding(5);
        }

        // =========================================================
        // Открыть профиль
        // =========================================================
        private void OnOpenRequested(object? sender, string filePath)
        {
            if (FindForm() is ProfileAuthWindow authForm)
            {
                authForm.ShowPage(new PasswordPage(filePath));
            }
        }

        // =========================================================
        // Миграция профиля (Обновление формата файла)
        // =========================================================
        private void OnMigrateRequested(object? sender, string filePath)
        {
            string profileName = Path.GetFileNameWithoutExtension(filePath);

            DialogResult confirmResult = MessageBox.Show(
                $"Обновить формат профиля \"{profileName}\" до версии v.0.2?\n\n" +
                "Это позволит отображать username бота в списке без ввода пароля.\n" +
                "Для обновления потребуется ввести пароль от профиля.",
                "Миграция профиля",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Создаем простое встроенное окно для ввода пароля
                using (Form pwdForm = new Form())
                {
                    pwdForm.Text = "Введите пароль";
                    pwdForm.Size = new Size(320, 160);
                    pwdForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    pwdForm.MaximizeBox = false;
                    pwdForm.MinimizeBox = false;
                    pwdForm.StartPosition = FormStartPosition.CenterParent;

                    // ← ВАЖНО: Получаем родительскую форму и устанавливаем как владельца
                    Form? parentForm = FindForm();
                    if (parentForm != null)
                    {
                        pwdForm.Owner = parentForm;
                        pwdForm.TopMost = true; // ← Делаем окно поверх всех
                    }

                    Label lbl = new Label
                    {
                        Text = $"Пароль для \"{profileName}\":",
                        Dock = DockStyle.Top,
                        Margin = new Padding(15, 15, 15, 5),
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    TextBox txtPassword = new TextBox
                    {
                        PasswordChar = '*',
                        Dock = DockStyle.Top,
                        Margin = new Padding(15, 0, 15, 15),
                        Font = new Font(Font.FontFamily, 10f)
                    };

                    FlowLayoutPanel pnlButtons = new FlowLayoutPanel
                    {
                        Dock = DockStyle.Bottom,
                        FlowDirection = FlowDirection.RightToLeft,
                        Padding = new Padding(15),
                        Height = 50
                    };

                    Button btnOk = new Button { Text = "Обновить", DialogResult = DialogResult.OK, Width = 100 };
                    Button btnCancel = new Button { Text = "Отмена", DialogResult = DialogResult.Cancel, Width = 100, Margin = new Padding(0, 0, 10, 0) };

                    pnlButtons.Controls.Add(btnCancel);
                    pnlButtons.Controls.Add(btnOk);

                    pwdForm.Controls.Add(pnlButtons);
                    pwdForm.Controls.Add(txtPassword);
                    pwdForm.Controls.Add(lbl);

                    pwdForm.AcceptButton = btnOk;
                    pwdForm.CancelButton = btnCancel;

                    // ← Показываем окно с правильным владельцем
                    if (pwdForm.ShowDialog(parentForm) == DialogResult.OK)
                    {
                        string password = txtPassword.Text;

                        if (profileManager.OpenProfile(filePath, password))
                        {
                            if (profileManager.Save())
                            {
                                MessageBox.Show(
                                    $"Профиль \"{profileName}\" успешно обновлён до формата v.0.2!",
                                    "Успех",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                LoadProfiles();
                            }
                            else
                            {
                                MessageBox.Show("Не удалось сохранить профиль в новом формате.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Неверный пароль или файл поврежден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        // =========================================================
        // Удалить профиль
        // =========================================================
        private void OnDeleteRequested(object? sender, string filePath)
        {
            string profileName = Path.GetFileNameWithoutExtension(filePath);

            DialogResult result = MessageBox.Show(
                $"Вы действительно хотите удалить профиль \"{profileName}\"?\n\n" +
                "Это действие нельзя отменить. Все данные будут безвозвратно потеряны.",
                "Удаление профиля",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    File.Delete(filePath);
                    LoadProfiles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось удалить профиль:\n\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // =========================================================
        // Навигация
        // =========================================================
        private void BtnBack_Click(object? sender, EventArgs e)
        {
            if (FindForm() is ProfileAuthWindow authForm)
            {
                authForm.ShowWelcomePage();
            }
        }

        private void BtnCreateProfile_Click(object? sender, EventArgs e)
        {
            if (FindForm() is ProfileAuthWindow authForm)
            {
                authForm.StartProfileCreation();
                authForm.ShowPage(new CreateProfilePage());
            }
        }

        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            LoadProfiles();
        }

        private void BtnImportProfile_Click(object? sender, EventArgs e)
        {
            if (FindForm() is ProfileAuthWindow authForm)
            {
                authForm.ShowPage(new ImportProfilePage());
            }
        }
    }
}