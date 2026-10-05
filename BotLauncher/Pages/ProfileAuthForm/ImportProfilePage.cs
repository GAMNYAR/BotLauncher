using BotLauncher.Controls;
using BotLauncher.Models.Profile;
using BotLauncher.Services.Telegram;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ProfileAuthWindow = global::BotLauncher.ProfileAuthForm;

namespace BotLauncher.Pages.ProfileAuthForm
{
    public partial class ImportProfilePage : UserControl
    {
        private readonly TelegramProfileManager profileManager;
        private readonly RememberedProfileService rememberedProfileService;
        private string selectedFilePath = string.Empty;
        private DropZoneOverlay? dropZoneOverlay;

        public ImportProfilePage()
        {
            InitializeComponent();
            profileManager = new TelegramProfileManager();
            rememberedProfileService = new RememberedProfileService();

            // Подписка на события, которых нет в Designer.cs
            this.Load += ImportProfilePage_Load;
            txtFilePath.TextChanged += TxtFilePath_TextChanged;
            txtPassword.TextChanged += TxtPassword_TextChanged;
            txtPassword.KeyDown += TxtPassword_KeyDown;
        }

        private void ImportProfilePage_Load(object? sender, EventArgs e)
        {
            InitializePage();
        }

        private void InitializePage()
        {
            selectedFilePath = string.Empty;
            txtFilePath.Clear();
            txtPassword.Clear();
            txtPassword.PasswordChar = '●';
            chkRememberMe.Checked = false;

            HideFileError();
            HidePasswordError();

            InitializeTooltips();

            // Включаем Drag & Drop
            this.AllowDrop = true;
        }

        private void InitializeTooltips()
        {
            uiToolTip1.SetToolTip(txtFilePath, "Путь к файлу профиля .blp");
            uiToolTip1.SetToolTip(btnSelectFile, "Выбрать файл профиля через проводник");
            uiToolTip1.SetToolTip(txtPassword, "Пароль от профиля для расшифровки");
            uiToolTip1.SetToolTip(btnShowPassword, "Показать/скрыть пароль");
            uiToolTip1.SetToolTip(chkRememberMe, "Если галочка стоит, то при повторном входе не нужно будет выбирать профиль и писать пароль");
            uiToolTip1.SetToolTip(btnImport, "Импортировать профиль в программу");
            uiToolTip1.SetToolTip(btnBack, "Вернуться на главную страницу");
            uiToolTip1.SetToolTip(btnCancel, "Отменить импорт и очистить поля");
            uiToolTip1.SetToolTip(btnInfo, "Автозапуск этого профиля без пароля при следующем входе");
        }

        private void ShowFileError(string message)
        {
            picFileError.Visible = true;
            uiToolTip1.SetToolTip(picFileError, message);
        }

        private void HideFileError()
        {
            picFileError.Visible = false;
        }

        private void ShowPasswordError(string message)
        {
            picPasswordError.Visible = true;
            uiToolTip1.SetToolTip(picPasswordError, message);
        }

        private void HidePasswordError()
        {
            picPasswordError.Visible = false;
        }

        private void BtnSelectFile_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите файл профиля";
            openFileDialog.Filter = "Файлы профиля (*.blp)|*.blp|Все файлы (*.*)|*.*";
            openFileDialog.DefaultExt = "blp";
            openFileDialog.CheckFileExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                txtFilePath.Text = selectedFilePath;
                HideFileError();
                txtPassword.Focus();
            }
        }

        private void BtnImport_Click(object? sender, EventArgs e)
        {
            if (FindForm() is not ProfileAuthWindow authForm)
            {
                MessageBox.Show("Ошибка навигации.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HideFileError();
            HidePasswordError();

            if (string.IsNullOrWhiteSpace(selectedFilePath))
            {
                ShowFileError("Выберите файл профиля");
                MessageBox.Show("Пожалуйста, выберите файл профиля.", "Файл не выбран", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSelectFile.Focus();
                return;
            }

            if (!File.Exists(selectedFilePath))
            {
                ShowFileError("Файл не найден");
                MessageBox.Show($"Файл не найден:\n{selectedFilePath}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFilePath.Focus();
                return;
            }

            string password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(password))
            {
                ShowPasswordError("Введите пароль");
                MessageBox.Show("Пожалуйста, введите пароль.", "Пароль не введён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (password.Length < 5)
            {
                ShowPasswordError("Минимум 5 символов");
                MessageBox.Show("Пароль должен содержать минимум 5 символов.", "Слишком короткий пароль", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            string dataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string selectedFileName = Path.GetFileName(selectedFilePath);
            string fullPathInData = Path.Combine(dataFolder, selectedFileName);

            string normalizedSelected = Path.GetFullPath(selectedFilePath).ToLowerInvariant();
            string normalizedInData = Path.GetFullPath(fullPathInData).ToLowerInvariant();

            if (normalizedSelected == normalizedInData || normalizedSelected.StartsWith(dataFolder.ToLowerInvariant() + "\\"))
            {
                MessageBox.Show("Этот профиль уже находится в папке Data.", "Профиль уже импортирован", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Если галочка стоит - запоминаем профиль
                if (chkRememberMe.Checked)
                {
                    try
                    {
                        string profileName = Path.GetFileNameWithoutExtension(selectedFileName);
                        rememberedProfileService.RememberProfile(
                            Path.Combine("Data", selectedFileName),
                            profileName,
                            password
                        );
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"[ImportProfilePage] Ошибка сохранения: {ex.Message}");
                    }
                }

                authForm.ShowPage(new ProfileListPage());
                return;
            }

            bool passwordValid = profileManager.VerifyPassword(selectedFilePath, password);

            if (!passwordValid)
            {
                ShowPasswordError("Неверный пароль");
                MessageBox.Show("Неверный пароль.", "Ошибка пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            if (File.Exists(fullPathInData))
            {
                string sourceHash = profileManager.GetFileHash(selectedFilePath);
                string existingHash = profileManager.GetFileHash(fullPathInData);

                if (sourceHash == existingHash)
                {
                    MessageBox.Show("Этот профиль уже импортирован.", "Профиль уже импортирован", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Если галочка стоит - запоминаем профиль
                    if (chkRememberMe.Checked)
                    {
                        try
                        {
                            rememberedProfileService.RememberProfile(
                                Path.Combine("Data", selectedFileName),
                                Path.GetFileNameWithoutExtension(selectedFileName),
                                password
                            );
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"[ImportProfilePage] Ошибка сохранения: {ex.Message}");
                        }
                    }

                    authForm.ShowPage(new ProfileListPage());
                    return;
                }

                DialogResult userChoice = MessageBox.Show(
                    $"Файл \"{selectedFileName}\" уже существует.\n\n" +
                    "• ДА — Заменить\n" +
                    "• НЕТ — Создать копию\n" +
                    "• ОТМЕНА — Прервать",
                    "Файл уже существует",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (userChoice == DialogResult.Cancel) return;

                if (userChoice == DialogResult.Yes)
                {
                    try { File.Delete(fullPathInData); }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Не удалось удалить файл:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            try
            {
                if (!Directory.Exists(dataFolder))
                    Directory.CreateDirectory(dataFolder);

                string destinationPath = fullPathInData;

                if (File.Exists(destinationPath))
                {
                    int counter = 1;
                    string nameWithoutExt = Path.GetFileNameWithoutExtension(selectedFileName);
                    string extension = Path.GetExtension(selectedFileName);

                    do
                    {
                        destinationPath = Path.Combine(dataFolder, $"{nameWithoutExt}_{counter}{extension}");
                        counter++;
                    } while (File.Exists(destinationPath));
                }

                File.Copy(selectedFilePath, destinationPath, false);

                // =========================================================
                // Успешный импорт!
                // =========================================================

                // Если галочка "Запомнить меня" стоит - сохраняем для авто-входа
                if (chkRememberMe.Checked)
                {
                    try
                    {
                        string profileName = Path.GetFileNameWithoutExtension(destinationPath);
                        rememberedProfileService.RememberProfile(
                            Path.Combine("Data", Path.GetFileName(destinationPath)),
                            profileName,
                            password
                        );

                        MessageBox.Show(
                            $"Профиль успешно импортирован!\n\n" +
                            $"{Path.GetFileName(destinationPath)}\n\n" +
                            "✓ Авто-вход включен",
                            "Импорт завершён",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"[ImportProfilePage] Ошибка сохранения: {ex.Message}");

                        MessageBox.Show(
                            $"Профиль успешно импортирован!\n\n" +
                            $"{Path.GetFileName(destinationPath)}\n\n" +
                            "⚠️ Не удалось включить авто-вход",
                            "Импорт завершён",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(
                        $"Профиль успешно импортирован!\n\n" +
                        $"{Path.GetFileName(destinationPath)}",
                        "Импорт завершён",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                // Показываем список профилей
                authForm.ShowPage(new ProfileListPage());
            }
            catch (IOException ioEx)
            {
                ShowFileError("Ошибка копирования");
                MessageBox.Show($"Не удалось скопировать файл:\n{ioEx.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка импорта:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnShowPassword_Click(object? sender, EventArgs e)
        {
            txtPassword.PasswordChar = txtPassword.PasswordChar == '\0' ? '●' : '\0';
        }

        private void TxtFilePath_TextChanged(object? sender, EventArgs e) => HideFileError();

        private void TxtPassword_TextChanged(object? sender, EventArgs e) => HidePasswordError();

        private void TxtPassword_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnImport_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // =========================================================
        // Назад (просто возврат)
        // =========================================================
        private void BtnBack_Click(object? sender, EventArgs e)
        {
            if (FindForm() is ProfileAuthWindow authForm)
                authForm.ShowWelcomePage();
        }

        // =========================================================
        // Отмена (очистка полей + возврат)
        // =========================================================
        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            // 1. Очищаем все данные
            selectedFilePath = string.Empty;
            txtFilePath.Clear();
            txtPassword.Clear();
            chkRememberMe.Checked = false;

            // 2. Скрываем ошибки
            HideFileError();
            HidePasswordError();

            // 3. Возвращаемся на главную страницу
            if (FindForm() is ProfileAuthWindow authForm)
                authForm.ShowWelcomePage();
        }

        // =========================================================
        // Drag & Drop
        // =========================================================

        protected override void OnDragEnter(DragEventArgs e)
        {
            base.OnDragEnter(e);

            if (e.Data == null)
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Length > 0)
                {
                    if (files[0].EndsWith(".blp", StringComparison.OrdinalIgnoreCase))
                    {
                        e.Effect = DragDropEffects.Copy;
                        ShowDropZoneOverlay();
                        return;
                    }
                }
            }

            e.Effect = DragDropEffects.None;
        }

        protected override void OnDragOver(DragEventArgs e)
        {
            base.OnDragOver(e);

            if (e.Data == null)
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Length > 0)
                {
                    if (files[0].EndsWith(".blp", StringComparison.OrdinalIgnoreCase))
                    {
                        e.Effect = DragDropEffects.Copy;
                        return;
                    }
                }
            }

            e.Effect = DragDropEffects.None;
        }

        protected override void OnDragLeave(EventArgs e)
        {
            base.OnDragLeave(e);
            HideDropZoneOverlay();
        }

        protected override void OnDragDrop(DragEventArgs e)
        {
            base.OnDragDrop(e);
            HideDropZoneOverlay();

            if (e.Data == null) return;
            if (e.Data.GetData(DataFormats.FileDrop) is not string[] files) return;
            if (files.Length == 0) return;

            string filePath = files[0];

            if (!filePath.EndsWith(".blp", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Неверный формат файла.\nПеретащите файл .blp", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedFilePath = filePath;
            txtFilePath.Text = filePath;
            HideFileError();
            txtPassword.Focus();

            MessageBox.Show($"Файл загружен:\n{Path.GetFileName(filePath)}\n\nВведите пароль.", "Файл принят", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // =========================================================
        // Показ/скрытие DropZoneOverlay
        // =========================================================

        private void ShowDropZoneOverlay()
        {
            if (dropZoneOverlay == null)
            {
                dropZoneOverlay = new DropZoneOverlay();
                dropZoneOverlay.Dock = DockStyle.Fill;
                this.Controls.Add(dropZoneOverlay);
            }

            dropZoneOverlay.Visible = true;
            dropZoneOverlay.BringToFront();
            dropZoneOverlay.Invalidate();
        }

        private void HideDropZoneOverlay()
        {
            if (dropZoneOverlay != null)
            {
                dropZoneOverlay.Visible = false;
            }
        }
    }
}