using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BotLauncher.Properties;

namespace BotLauncher.Controls.Telegram.Templates
{
    public partial class AttachmentCardControl : UserControl
    {
        private string filePath = string.Empty;
        private Action<string>? onRemove;

        public AttachmentCardControl()
        {
            InitializeComponent();
            this.Size = new Size(150, 130);
            SetupRemoveButton();
        }

        private void SetupRemoveButton()
        {
            // Устанавливаем обычную иконку по умолчанию
            btnRemove.BackgroundImage = Resources.icon_close_hover;
            btnRemove.BackgroundImageLayout = ImageLayout.Zoom;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Cursor = Cursors.Hand;

            // При наведении - показываем hover иконку
            btnRemove.MouseEnter += (s, e) =>
            {
                btnRemove.BackgroundImage = Resources.icon_close_hover;
            };

            // Когда убираем мышь - возвращаем обычную
            btnRemove.MouseLeave += (s, e) =>
            {
                btnRemove.BackgroundImage = Resources.icon_close_hover;
            };

            // При нажатии - показываем pressed иконку
            btnRemove.MouseDown += (s, e) =>
            {
                btnRemove.BackgroundImage = Resources.icon_close_pressed;
            };

            // Когда отпускаем (но курсор ещё на кнопке) - возвращаем hover
            btnRemove.MouseUp += (s, e) =>
            {
                btnRemove.BackgroundImage = Resources.icon_close_hover;
            };
        }

        public void SetData(string filePath, Action<string> onRemove)
        {
            this.filePath = filePath;
            this.onRemove = onRemove;

            var fileName = Path.GetFileName(filePath);
            long fileSizeBytes = 0;
            string fileSizeStr = "0 КБ";
            bool isTooLarge = false;

            try
            {
                var fileInfo = new FileInfo(filePath);
                fileSizeBytes = fileInfo.Length;

                // Проверяем размер файла
                if (fileSizeBytes > 2_147_483_648) // 2 ГБ
                {
                    isTooLarge = true;
                    fileSizeStr = $"{fileSizeBytes / (1024 * 1024 * 1024):F1} ГБ";
                }
                else if (fileSizeBytes > 1024 * 1024)
                {
                    fileSizeStr = $"{fileSizeBytes / (1024 * 1024):F1} МБ";
                }
                else
                {
                    fileSizeStr = $"{fileSizeBytes / 1024} КБ";
                }

                var extension = fileInfo.Extension.ToLower();
                bool isImage = extension == ".png" || extension == ".jpg" || extension == ".jpeg" ||
                              extension == ".gif" || extension == ".webp" || extension == ".bmp";
                bool isVideo = extension == ".mp4" || extension == ".avi" || extension == ".mov" ||
                              extension == ".mkv" || extension == ".webm";

                // Сбрасываем цвета
                lblFileName.ForeColor = Color.White;
                lblFileSize.ForeColor = Color.FromArgb(156, 163, 175);

                // Настраиваем отображение в зависимости от типа файла
                if (isImage)
                {
                    try
                    {
                        pictureBox.Visible = true;
                        lblIcon.Visible = false;
                        pictureBox.Image = Image.FromFile(filePath);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.BackColor = Color.FromArgb(31, 34, 42);
                    }
                    catch
                    {
                        pictureBox.Visible = false;
                        lblIcon.Visible = true;
                        lblIcon.Text = "🖼";
                        lblIcon.Font = new Font("Segoe UI Emoji", 36F);
                        lblIcon.ForeColor = Color.White;
                    }
                }
                else if (isVideo)
                {
                    // Для видео показываем иконку Play
                    pictureBox.Visible = false;
                    lblIcon.Visible = true;
                    lblIcon.Text = "▶";
                    lblIcon.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
                    lblIcon.ForeColor = Color.White;
                    lblIcon.BackColor = Color.FromArgb(42, 46, 57);
                    lblIcon.TextAlign = ContentAlignment.MiddleCenter;
                }
                else
                {
                    // Для документов
                    pictureBox.Visible = false;
                    lblIcon.Visible = true;
                    lblIcon.Text = "";
                    lblIcon.Font = new Font("Segoe UI Emoji", 36F);
                    lblIcon.ForeColor = Color.White;
                    lblIcon.BackColor = Color.FromArgb(31, 34, 42);
                    lblIcon.TextAlign = ContentAlignment.MiddleCenter;
                }

                // Устанавливаем текст
                lblFileName.Text = fileName;
                lblFileSize.Text = fileSizeStr;

                // Показываем иконку предупреждения через BackgroundImage
                if (isTooLarge)
                {
                    if (Resources.triangle_exclamation_solid_RED != null)
                    {
                        picWarning.BackgroundImage = Resources.triangle_exclamation_solid_RED;
                        picWarning.BackgroundImageLayout = ImageLayout.Zoom;
                        picWarning.Visible = true;
                        picWarning.BringToFront();
                    }

                    lblFileSize.ForeColor = Color.FromArgb(239, 68, 68);
                    lblFileName.ForeColor = Color.FromArgb(239, 68, 68);
                }
                else
                {
                    picWarning.Visible = false;
                }

                btnRemove.Click += (s, e) => onRemove?.Invoke(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}