using Org.BouncyCastle.Asn1.Cmp;
using Sunny.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BotLauncher.Controls.Telegram.Groups.TabSendSettings
{
    public partial class ScenarioCardControl : UserControl
    {
        // Свойство для хранения JSON сценария
        public string ScenarioJson { get; set; } = string.Empty;

        // Событие для уведомления об удалении
        public event Action<ScenarioCardControl>? DeleteRequested;

        // Событие для уведомления о редактировании
        public event Action<ScenarioCardControl>? EditRequested;

        public ScenarioCardControl()
        {
            InitializeComponent();

            // Подписываемся на кнопки
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        /// <summary>
        /// Устанавливает данные карточки
        /// </summary>
        public void SetData(string scenarioJson)
        {
            ScenarioJson = scenarioJson;
            lblInfo.Text = $"Размер: {scenarioJson.Length} символов";
            lblStatus.Text = "Статус: ✅ Готов к работе";
        }

        private void BtnEdit_Click(object? sender, EventArgs e)
        {
            EditRequested?.Invoke(this);
            // TODO: Позже здесь откроем редактор с загруженным JSON
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить этот сценарий?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteRequested?.Invoke(this);
            }
        }
    }
}