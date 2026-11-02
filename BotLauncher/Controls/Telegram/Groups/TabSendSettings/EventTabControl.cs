using BotLauncher.Forms;
using Sunny.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BotLauncher.Controls.Telegram.Groups.TabSendSettings
{
    public partial class EventTabControl : UserControl
    {
        // Поле для отслеживания несохраненных изменений
        private bool _hasUnsavedChanges = false;

        public EventTabControl()
        {
            InitializeComponent();

            // Явно подписываем кнопку, если в дизайнере это не сделано
            if (btnAddRule != null)
            {
                btnAddRule.Click += BtnAddRule_Click;
            }
        }

        private void BtnAddRule_Click(object? sender, EventArgs e)
        {
            // Открываем форму с визуальным редактором (WebView2 + LiteGraph)
            using var form = new AddTriggerRuleForm();

            if (form.ShowDialog(this) == DialogResult.OK && form.HasScenario)
            {
                // Создаем карточку правила, используя наш новый UserControl
                var card = CreateRuleCard(form.ScenarioJson);

                flpTriggersList.Controls.Add(card);
                MarkAsChanged();
            }
        }

        private ScenarioCardControl CreateRuleCard(string scenarioJson)
        {
            // Создаем экземпляр нашей красивой карточки
            var card = new ScenarioCardControl();

            // Передаем в нее данные (JSON и размеры)
            card.SetData(scenarioJson);

            // Подписываемся на события, которые карточка будет генерировать
            card.DeleteRequested += OnScenarioCardDeleteRequested;
            card.EditRequested += OnScenarioCardEditRequested;

            return card;
        }

        private void OnScenarioCardDeleteRequested(ScenarioCardControl card)
        {
            // Удаляем карточку из списка и освобождаем ресурсы
            flpTriggersList.Controls.Remove(card);
            card.Dispose();
            MarkAsChanged();
        }

        private void OnScenarioCardEditRequested(ScenarioCardControl card)
        {
            // TODO: Здесь позже мы откроем редактор и передадим ему card.ScenarioJson для загрузки
            MessageBox.Show(
                $"Редактирование сценария ({card.ScenarioJson.Length} символов)\n\nЭта функция будет добавлена позже!",
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        #region Управление состоянием изменений

        /// <summary>
        /// Вызывается при любом изменении настроек, требующем сохранения
        /// </summary>
        private void MarkAsChanged()
        {
            _hasUnsavedChanges = true;
            // Если нужно активировать кнопку сохранения в главном окне, раскомментируй:
            // if (btnSaveEvent != null) btnSaveEvent.Enabled = true;
        }

        /// <summary>
        /// Вызывается после успешного сохранения настроек
        /// </summary>
        public void MarkAsSaved()
        {
            _hasUnsavedChanges = false;
            // if (btnSaveEvent != null) btnSaveEvent.Enabled = false;
        }

        /// <summary>
        /// Позволяет главному окну проверить, есть ли несохраненные данные перед сменой группы
        /// </summary>
        public bool HasUnsavedChanges => _hasUnsavedChanges;

        #endregion
    }
}