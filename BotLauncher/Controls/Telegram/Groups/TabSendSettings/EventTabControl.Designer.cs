using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BotLauncher.Controls.Telegram.Groups.TabSendSettings
{
    partial class EventTabControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpEvent = new Sunny.UI.UIGroupBox();
            this.pnlEventButtons = new Sunny.UI.UIPanel();
            this.chkEventManualConfirm = new Sunny.UI.UICheckBox();
            this.btnSaveEvent = new Sunny.UI.UIButton();
            this.btnStartEvent = new Sunny.UI.UIButton();
            this.pnlEventInner = new Panel();
            this.pnlEventContent = new Panel();

            // Элементы контента
            this.cmbEventTemplate = new Sunny.UI.UIComboBox();
            this.txtEventCustomText = new Sunny.UI.UITextBox();
            this.lblEventTemplateHint = new Label();
            this.lblRulesTitle = new Label();
            this.flpTriggersList = new FlowLayoutPanel();
            this.btnAddRule = new Sunny.UI.UIButton();
            this.lblEventActions = new Label();
            this.chkAutoPublish = new Sunny.UI.UICheckBox();
            this.chkLogEvent = new Sunny.UI.UICheckBox();
            this.chkSendNotification = new Sunny.UI.UICheckBox();
            this.chkStopOnMatch = new Sunny.UI.UICheckBox();
            this.chkManualSendTemplateFirst = new Sunny.UI.UICheckBox();
            this.chkManualDisablePreview = new Sunny.UI.UICheckBox();
            this.chkManualSilentSend = new Sunny.UI.UICheckBox();
            this.chkManualReplyToLast = new Sunny.UI.UICheckBox();
            this.chkManualHideSpoiler = new Sunny.UI.UICheckBox();
            this.chkManualProtectContent = new Sunny.UI.UICheckBox();
            this.chkManualDeletePrevious = new Sunny.UI.UICheckBox();
            this.chkManualPinMessage = new Sunny.UI.UICheckBox();
            this.cmbManualPinTarget = new Sunny.UI.UIComboBox();
            this.chkManualAnimatedEmoji = new Sunny.UI.UICheckBox();
            this.cmbManualAnimatedEmoji = new Sunny.UI.UIComboBox();
            this.cmbManualEmojiApplyTo = new Sunny.UI.UIComboBox();
            this.chkManualAnimatedEffect = new Sunny.UI.UICheckBox();
            this.cmbManualAnimatedEffect = new Sunny.UI.UIComboBox();
            this.cmbManualEffectApplyTo = new Sunny.UI.UIComboBox();
            this.chkManualNotifySuccess = new Sunny.UI.UICheckBox();
            this.cmbManualNotifySuccess1 = new Sunny.UI.UIComboBox();
            this.lblManualNotifySuccessOr = new Label();
            this.cmbManualNotifySuccess2 = new Sunny.UI.UIComboBox();
            this.chkManualNotifyComplete = new Sunny.UI.UICheckBox();
            this.cmbManualNotifyComplete1 = new Sunny.UI.UIComboBox();
            this.lblManualNotifyCompleteOr = new Label();
            this.cmbManualNotifyComplete2 = new Sunny.UI.UIComboBox();
            this.chkManualNotifyError = new Sunny.UI.UICheckBox();
            this.cmbManualNotifyError1 = new Sunny.UI.UIComboBox();
            this.lblManualNotifyErrorOr = new Label();
            this.cmbManualNotifyError2 = new Sunny.UI.UIComboBox();
            this.grpEventHistory = new Sunny.UI.UIGroupBox();
            this.flpEventHistory = new FlowLayoutPanel();
            this.toolTip1 = new Sunny.UI.UIToolTip(this.components);

            this.grpEvent.SuspendLayout();
            this.pnlEventButtons.SuspendLayout();
            this.pnlEventInner.SuspendLayout();
            this.pnlEventContent.SuspendLayout();
            this.grpEventHistory.SuspendLayout();
            this.SuspendLayout();

            // ==========================================
            // grpEvent (Главный контейнер)
            // ==========================================
            this.grpEvent.BackColor = Color.FromArgb(35, 39, 48);
            this.grpEvent.Controls.Add(this.pnlEventButtons);
            this.grpEvent.Controls.Add(this.pnlEventInner);
            this.grpEvent.Dock = DockStyle.Fill;
            this.grpEvent.FillColor = Color.Transparent;
            this.grpEvent.FillColor2 = Color.Transparent;
            this.grpEvent.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.grpEvent.ForeColor = Color.White;
            this.grpEvent.Location = new Point(0, 0);
            this.grpEvent.Margin = new Padding(4, 5, 4, 5);
            this.grpEvent.MinimumSize = new Size(1, 1);
            this.grpEvent.Name = "grpEvent";
            this.grpEvent.Padding = new Padding(0, 32, 0, 0);
            this.grpEvent.Radius = 15;
            this.grpEvent.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.grpEvent.RectColor = Color.FromArgb(58, 58, 69);
            this.grpEvent.Size = new Size(696, 483);
            this.grpEvent.Style = Sunny.UI.UIStyle.Custom;
            this.grpEvent.TabIndex = 11;
            this.grpEvent.Text = "Настройки события отправки";
            this.grpEvent.TextAlignment = ContentAlignment.MiddleLeft;
            this.grpEvent.TitleInterval = 8;
            this.grpEvent.TitleTop = 14;

            // ==========================================
            // pnlEventButtons (Нижняя панель)
            // ==========================================
            this.pnlEventButtons.Controls.Add(this.chkEventManualConfirm);
            this.pnlEventButtons.Controls.Add(this.btnSaveEvent);
            this.pnlEventButtons.Controls.Add(this.btnStartEvent);
            this.pnlEventButtons.Dock = DockStyle.Bottom;
            this.pnlEventButtons.FillColor = Color.Transparent;
            this.pnlEventButtons.FillColor2 = Color.Transparent;
            this.pnlEventButtons.Font = new Font("Microsoft Sans Serif", 12F);
            this.pnlEventButtons.ForeColor = Color.Transparent;
            this.pnlEventButtons.Location = new Point(0, 438);
            this.pnlEventButtons.Margin = new Padding(4, 5, 4, 5);
            this.pnlEventButtons.MinimumSize = new Size(1, 1);
            this.pnlEventButtons.Name = "pnlEventButtons";
            this.pnlEventButtons.Radius = 0;
            this.pnlEventButtons.RectColor = Color.FromArgb(58, 58, 69);
            this.pnlEventButtons.RectDisableColor = Color.Transparent;
            this.pnlEventButtons.Size = new Size(696, 45);
            this.pnlEventButtons.TabIndex = 21;
            this.pnlEventButtons.Text = null;
            this.pnlEventButtons.TextAlignment = ContentAlignment.MiddleCenter;

            this.chkEventManualConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.chkEventManualConfirm.BackColor = Color.Transparent;
            this.chkEventManualConfirm.CheckBoxColor = Color.BlueViolet;
            this.chkEventManualConfirm.Checked = true;
            this.chkEventManualConfirm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.chkEventManualConfirm.ForeColor = Color.White;
            this.chkEventManualConfirm.Location = new Point(52, 10);
            this.chkEventManualConfirm.MinimumSize = new Size(1, 1);
            this.chkEventManualConfirm.Name = "chkEventManualConfirm";
            this.chkEventManualConfirm.Size = new Size(333, 25);
            this.chkEventManualConfirm.TabIndex = 27;
            this.chkEventManualConfirm.Text = "Запрашивать подтверждение перед началом сеанса";

            this.btnSaveEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnSaveEvent.FillColor = Color.FromArgb(108, 99, 255);
            this.btnSaveEvent.FillColor2 = Color.Transparent;
            this.btnSaveEvent.FillDisableColor = Color.FromArgb(46, 42, 110);
            this.btnSaveEvent.FillHoverColor = Color.FromArgb(139, 133, 255);
            this.btnSaveEvent.FillPressColor = Color.FromArgb(90, 82, 213);
            this.btnSaveEvent.FillSelectedColor = Color.Transparent;
            this.btnSaveEvent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnSaveEvent.ForeDisableColor = Color.White;
            this.btnSaveEvent.Location = new Point(389, 5);
            this.btnSaveEvent.MinimumSize = new Size(1, 1);
            this.btnSaveEvent.Name = "btnSaveEvent";
            this.btnSaveEvent.Radius = 8;
            this.btnSaveEvent.RectColor = Color.Transparent;
            this.btnSaveEvent.RectDisableColor = Color.Transparent;
            this.btnSaveEvent.RectHoverColor = Color.Transparent;
            this.btnSaveEvent.RectPressColor = Color.Transparent;
            this.btnSaveEvent.RectSelectedColor = Color.Transparent;
            this.btnSaveEvent.Size = new Size(150, 35);
            this.btnSaveEvent.Style = Sunny.UI.UIStyle.Custom;
            this.btnSaveEvent.TabIndex = 13;
            this.btnSaveEvent.Text = "Сохранить настройки";

            this.btnStartEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnStartEvent.FillColor = Color.FromArgb(123, 44, 191);
            this.btnStartEvent.FillColor2 = Color.Transparent;
            this.btnStartEvent.FillDisableColor = Color.Transparent;
            this.btnStartEvent.FillHoverColor = Color.FromArgb(157, 78, 221);
            this.btnStartEvent.FillPressColor = Color.FromArgb(90, 24, 154);
            this.btnStartEvent.FillSelectedColor = Color.Transparent;
            this.btnStartEvent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnStartEvent.ForeDisableColor = Color.White;
            this.btnStartEvent.Location = new Point(543, 5);
            this.btnStartEvent.MinimumSize = new Size(1, 1);
            this.btnStartEvent.Name = "btnStartEvent";
            this.btnStartEvent.Radius = 8;
            this.btnStartEvent.RectColor = Color.Transparent;
            this.btnStartEvent.RectDisableColor = Color.Transparent;
            this.btnStartEvent.RectHoverColor = Color.Transparent;
            this.btnStartEvent.RectPressColor = Color.Transparent;
            this.btnStartEvent.RectSelectedColor = Color.Transparent;
            this.btnStartEvent.Size = new Size(150, 35);
            this.btnStartEvent.Style = Sunny.UI.UIStyle.Custom;
            this.btnStartEvent.TabIndex = 14;
            this.btnStartEvent.Text = "Начать сеанс";

            // ==========================================
            // pnlEventInner (Скроллируемая область)
            // ==========================================
            this.pnlEventInner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.pnlEventInner.AutoScroll = true;
            this.pnlEventInner.Controls.Add(this.pnlEventContent);
            this.pnlEventInner.Location = new Point(3, 25);
            this.pnlEventInner.Name = "pnlEventInner";
            this.pnlEventInner.Size = new Size(693, 413);
            this.pnlEventInner.TabIndex = 22;

            // ==========================================
            // pnlEventContent (Основной контент с отступом 9px)
            // ==========================================
            this.pnlEventContent.BackColor = Color.FromArgb(35, 39, 48);
            this.pnlEventContent.Controls.Add(this.grpEventHistory);
            this.pnlEventContent.Controls.Add(this.chkManualNotifyError);
            this.pnlEventContent.Controls.Add(this.cmbManualNotifyError1);
            this.pnlEventContent.Controls.Add(this.lblManualNotifyErrorOr);
            this.pnlEventContent.Controls.Add(this.cmbManualNotifyError2);
            this.pnlEventContent.Controls.Add(this.chkManualNotifyComplete);
            this.pnlEventContent.Controls.Add(this.cmbManualNotifyComplete1);
            this.pnlEventContent.Controls.Add(this.lblManualNotifyCompleteOr);
            this.pnlEventContent.Controls.Add(this.cmbManualNotifyComplete2);
            this.pnlEventContent.Controls.Add(this.chkManualNotifySuccess);
            this.pnlEventContent.Controls.Add(this.cmbManualNotifySuccess1);
            this.pnlEventContent.Controls.Add(this.lblManualNotifySuccessOr);
            this.pnlEventContent.Controls.Add(this.cmbManualNotifySuccess2);
            this.pnlEventContent.Controls.Add(this.chkManualAnimatedEffect);
            this.pnlEventContent.Controls.Add(this.cmbManualAnimatedEffect);
            this.pnlEventContent.Controls.Add(this.cmbManualEffectApplyTo);
            this.pnlEventContent.Controls.Add(this.chkManualAnimatedEmoji);
            this.pnlEventContent.Controls.Add(this.cmbManualAnimatedEmoji);
            this.pnlEventContent.Controls.Add(this.cmbManualEmojiApplyTo);
            this.pnlEventContent.Controls.Add(this.cmbManualPinTarget);
            this.pnlEventContent.Controls.Add(this.chkManualPinMessage);
            this.pnlEventContent.Controls.Add(this.chkManualDeletePrevious);
            this.pnlEventContent.Controls.Add(this.chkManualProtectContent);
            this.pnlEventContent.Controls.Add(this.chkManualHideSpoiler);
            this.pnlEventContent.Controls.Add(this.chkManualReplyToLast);
            this.pnlEventContent.Controls.Add(this.chkManualSilentSend);
            this.pnlEventContent.Controls.Add(this.chkManualDisablePreview);
            this.pnlEventContent.Controls.Add(this.chkManualSendTemplateFirst);
            this.pnlEventContent.Controls.Add(this.chkStopOnMatch);
            this.pnlEventContent.Controls.Add(this.chkSendNotification);
            this.pnlEventContent.Controls.Add(this.chkLogEvent);
            this.pnlEventContent.Controls.Add(this.chkAutoPublish);
            this.pnlEventContent.Controls.Add(this.lblEventActions);
            this.pnlEventContent.Controls.Add(this.btnAddRule);
            this.pnlEventContent.Controls.Add(this.flpTriggersList);
            this.pnlEventContent.Controls.Add(this.lblRulesTitle);
            this.pnlEventContent.Controls.Add(this.lblEventTemplateHint);
            this.pnlEventContent.Controls.Add(this.txtEventCustomText);
            this.pnlEventContent.Controls.Add(this.cmbEventTemplate);
            this.pnlEventContent.Location = new Point(0, 0);
            this.pnlEventContent.MinimumSize = new Size(673, 0);
            this.pnlEventContent.Name = "pnlEventContent";
            this.pnlEventContent.Padding = new Padding(9, 9, 9, 9);
            this.pnlEventContent.Size = new Size(676, 1320);
            this.pnlEventContent.TabIndex = 0;

            // --- 1. СООБЩЕНИЕ ---
            this.cmbEventTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.cmbEventTemplate.DataSource = null;
            this.cmbEventTemplate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbEventTemplate.FillColor = Color.FromArgb(42, 46, 57);
            this.cmbEventTemplate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.cmbEventTemplate.ForeColor = Color.White;
            this.cmbEventTemplate.ItemHoverColor = Color.FromArgb(155, 200, 255);
            this.cmbEventTemplate.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            this.cmbEventTemplate.Location = new Point(9, 9);
            this.cmbEventTemplate.Margin = new Padding(4, 5, 4, 5);
            this.cmbEventTemplate.MinimumSize = new Size(63, 0);
            this.cmbEventTemplate.Name = "cmbEventTemplate";
            this.cmbEventTemplate.Padding = new Padding(0, 0, 30, 2);
            this.cmbEventTemplate.RectColor = Color.FromArgb(65, 71, 84);
            this.cmbEventTemplate.Size = new Size(658, 25);
            this.cmbEventTemplate.Style = Sunny.UI.UIStyle.Custom;
            this.cmbEventTemplate.StyleDropDown = Sunny.UI.UIStyle.Purple;
            this.cmbEventTemplate.SymbolSize = 24;
            this.cmbEventTemplate.TabIndex = 25;
            this.cmbEventTemplate.TextAlignment = ContentAlignment.MiddleLeft;
            this.cmbEventTemplate.Watermark = "Выберите шаблон сообщения (по умолчанию для всех правил)";

            this.txtEventCustomText.ButtonFillColor = Color.Transparent;
            this.txtEventCustomText.ButtonStyleInherited = false;
            this.txtEventCustomText.FillColor = Color.FromArgb(42, 46, 57);
            this.txtEventCustomText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.txtEventCustomText.ForeColor = Color.White;
            this.txtEventCustomText.Location = new Point(9, 43);
            this.txtEventCustomText.Margin = new Padding(4, 5, 4, 5);
            this.txtEventCustomText.MinimumSize = new Size(1, 16);
            this.txtEventCustomText.Name = "txtEventCustomText";
            this.txtEventCustomText.Padding = new Padding(5);
            this.txtEventCustomText.RectColor = Color.FromArgb(65, 71, 84);
            this.txtEventCustomText.ShowText = false;
            this.txtEventCustomText.Size = new Size(658, 25);
            this.txtEventCustomText.Style = Sunny.UI.UIStyle.Custom;
            this.txtEventCustomText.TabIndex = 26;
            this.txtEventCustomText.TextAlignment = ContentAlignment.MiddleLeft;
            this.txtEventCustomText.Watermark = "Или введите пользовательское сообщение";

            this.lblEventTemplateHint.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            this.lblEventTemplateHint.ForeColor = Color.DarkGray;
            this.lblEventTemplateHint.Location = new Point(9, 77);
            this.lblEventTemplateHint.Name = "lblEventTemplateHint";
            this.lblEventTemplateHint.Size = new Size(658, 35);
            this.lblEventTemplateHint.TabIndex = 27;
            this.lblEventTemplateHint.Text = "💡 Эти настройки будут использованы при срабатывании любого добавленного ниже правила.";

            // --- 2. СПИСОК ПРАВИЛ ---
            this.lblRulesTitle.AutoSize = true;
            this.lblRulesTitle.BackColor = Color.Transparent;
            this.lblRulesTitle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            this.lblRulesTitle.ForeColor = Color.FromArgb(180, 180, 180);
            this.lblRulesTitle.Location = new Point(9, 125);
            this.lblRulesTitle.Name = "lblRulesTitle";
            this.lblRulesTitle.Size = new Size(220, 17);
            this.lblRulesTitle.TabIndex = 203;
            this.lblRulesTitle.Text = "📋 Активные правила (сценарии):";

            this.flpTriggersList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.flpTriggersList.AutoScroll = true;
            this.flpTriggersList.BackColor = Color.FromArgb(30, 33, 40);
            this.flpTriggersList.FlowDirection = FlowDirection.TopDown;
            this.flpTriggersList.Location = new Point(9, 150);
            this.flpTriggersList.Name = "flpTriggersList";
            this.flpTriggersList.Padding = new Padding(5);
            this.flpTriggersList.Size = new Size(658, 300);
            this.flpTriggersList.TabIndex = 204;
            this.flpTriggersList.WrapContents = false;

            this.btnAddRule.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.btnAddRule.FillColor = Color.FromArgb(108, 99, 255);
            this.btnAddRule.FillColor2 = Color.Transparent;
            this.btnAddRule.FillDisableColor = Color.FromArgb(46, 42, 110);
            this.btnAddRule.FillHoverColor = Color.FromArgb(139, 133, 255);
            this.btnAddRule.FillPressColor = Color.FromArgb(90, 82, 213);
            this.btnAddRule.FillSelectedColor = Color.Transparent;
            this.btnAddRule.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnAddRule.ForeDisableColor = Color.White;
            this.btnAddRule.Location = new Point(9, 460);
            this.btnAddRule.MinimumSize = new Size(1, 1);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Radius = 8;
            this.btnAddRule.RectColor = Color.Transparent;
            this.btnAddRule.RectDisableColor = Color.Transparent;
            this.btnAddRule.RectHoverColor = Color.Transparent;
            this.btnAddRule.RectPressColor = Color.Transparent;
            this.btnAddRule.RectSelectedColor = Color.Transparent;
            this.btnAddRule.Size = new Size(658, 35);
            this.btnAddRule.Style = Sunny.UI.UIStyle.Custom;
            this.btnAddRule.TabIndex = 205;
            this.btnAddRule.Text = "➕ Добавить новый сценарий (правило)";

            // --- 3. ДЕЙСТВИЯ ---
            this.lblEventActions.AutoSize = true;
            this.lblEventActions.BackColor = Color.Transparent;
            this.lblEventActions.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.lblEventActions.ForeColor = Color.FromArgb(180, 180, 180);
            this.lblEventActions.Location = new Point(9, 510);
            this.lblEventActions.Name = "lblEventActions";
            this.lblEventActions.Size = new Size(138, 15);
            this.lblEventActions.TabIndex = 14;
            this.lblEventActions.Text = "Действия при событии:";

            this.chkAutoPublish.BackColor = Color.Transparent;
            this.chkAutoPublish.CheckBoxColor = Color.BlueViolet;
            this.chkAutoPublish.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.chkAutoPublish.ForeColor = Color.White;
            this.chkAutoPublish.Location = new Point(9, 535);
            this.chkAutoPublish.MinimumSize = new Size(1, 1);
            this.chkAutoPublish.Name = "chkAutoPublish";
            this.chkAutoPublish.Size = new Size(320, 25);
            this.chkAutoPublish.TabIndex = 15;
            this.chkAutoPublish.Text = "Автоматически публиковать при событии";

            this.chkLogEvent.BackColor = Color.Transparent;
            this.chkLogEvent.CheckBoxColor = Color.BlueViolet;
            this.chkLogEvent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.chkLogEvent.ForeColor = Color.White;
            this.chkLogEvent.Location = new Point(338, 535);
            this.chkLogEvent.MinimumSize = new Size(1, 1);
            this.chkLogEvent.Name = "chkLogEvent";
            this.chkLogEvent.Size = new Size(320, 25);
            this.chkLogEvent.TabIndex = 17;
            this.chkLogEvent.Text = "Логировать событие";

            this.chkSendNotification.BackColor = Color.Transparent;
            this.chkSendNotification.CheckBoxColor = Color.BlueViolet;
            this.chkSendNotification.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.chkSendNotification.ForeColor = Color.White;
            this.chkSendNotification.Location = new Point(9, 565);
            this.chkSendNotification.MinimumSize = new Size(1, 1);
            this.chkSendNotification.Name = "chkSendNotification";
            this.chkSendNotification.Size = new Size(320, 25);
            this.chkSendNotification.TabIndex = 16;
            this.chkSendNotification.Text = "Отправить уведомление";

            this.chkStopOnMatch.BackColor = Color.Transparent;
            this.chkStopOnMatch.CheckBoxColor = Color.BlueViolet;
            this.chkStopOnMatch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.chkStopOnMatch.ForeColor = Color.White;
            this.chkStopOnMatch.Location = new Point(338, 565);
            this.chkStopOnMatch.MinimumSize = new Size(1, 1);
            this.chkStopOnMatch.Name = "chkStopOnMatch";
            this.chkStopOnMatch.Size = new Size(320, 25);
            this.chkStopOnMatch.TabIndex = 18;
            this.chkStopOnMatch.Text = "Остановить обработку после срабатывания";

            // --- 4. НАСТРОЙКИ ОТПРАВКИ ---
            this.chkManualSendTemplateFirst.BackColor = Color.Transparent;
            this.chkManualSendTemplateFirst.CheckBoxColor = Color.BlueViolet;
            this.chkManualSendTemplateFirst.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.chkManualSendTemplateFirst.ForeColor = Color.White;
            this.chkManualSendTemplateFirst.Location = new Point(9, 600);
            this.chkManualSendTemplateFirst.MinimumSize = new Size(1, 1);
            this.chkManualSendTemplateFirst.Name = "chkManualSendTemplateFirst";
            this.chkManualSendTemplateFirst.Size = new Size(320, 25);
            this.chkManualSendTemplateFirst.TabIndex = 122;
            this.chkManualSendTemplateFirst.Text = "Отправить первым шаблон";

            this.chkManualDisablePreview.BackColor = Color.Transparent;
            this.chkManualDisablePreview.CheckBoxColor = Color.BlueViolet;
            this.chkManualDisablePreview.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.chkManualDisablePreview.ForeColor = Color.White;
            this.chkManualDisablePreview.Location = new Point(338, 600);
            this.chkManualDisablePreview.MinimumSize = new Size(1, 1);
            this.chkManualDisablePreview.Name = "chkManualDisablePreview";
            this.chkManualDisablePreview.Size = new Size(320, 25);
            this.chkManualDisablePreview.TabIndex = 123;
            this.chkManualDisablePreview.Text = "Отключить предпросмотр ссылок";

            this.chkManualSilentSend.BackColor = Color.Transparent;
            this.chkManualSilentSend.CheckBoxColor = Color.BlueViolet;
            this.chkManualSilentSend.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.chkManualSilentSend.ForeColor = Color.White;
            this.chkManualSilentSend.Location = new Point(9, 630);
            this.chkManualSilentSend.MinimumSize = new Size(1, 1);
            this.chkManualSilentSend.Name = "chkManualSilentSend";
            this.chkManualSilentSend.Size = new Size(320, 25);
            this.chkManualSilentSend.TabIndex = 124;
            this.chkManualSilentSend.Text = "Тихая отправка (без звука)";

            this.chkManualReplyToLast.BackColor = Color.Transparent;
            this.chkManualReplyToLast.CheckBoxColor = Color.BlueViolet;
            this.chkManualReplyToLast.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.chkManualReplyToLast.ForeColor = Color.White;
            this.chkManualReplyToLast.Location = new Point(338, 630);
            this.chkManualReplyToLast.MinimumSize = new Size(1, 1);
            this.chkManualReplyToLast.Name = "chkManualReplyToLast";
            this.chkManualReplyToLast.Size = new Size(320, 25);
            this.chkManualReplyToLast.TabIndex = 125;
            this.chkManualReplyToLast.Text = "Ответить на последнее сообщение (Reply)";

            this.chkManualHideSpoiler.BackColor = Color.Transparent;
            this.chkManualHideSpoiler.CheckBoxColor = Color.BlueViolet;
            this.chkManualHideSpoiler.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.chkManualHideSpoiler.ForeColor = Color.White;
            this.chkManualHideSpoiler.Location = new Point(9, 660);
            this.chkManualHideSpoiler.MinimumSize = new Size(1, 1);
            this.chkManualHideSpoiler.Name = "chkManualHideSpoiler";
            this.chkManualHideSpoiler.Size = new Size(320, 25);
            this.chkManualHideSpoiler.TabIndex = 128;
            this.chkManualHideSpoiler.Text = "Скрыть содержимое как спойлер";

            this.chkManualProtectContent.BackColor = Color.Transparent;
            this.chkManualProtectContent.CheckBoxColor = Color.BlueViolet;
            this.chkManualProtectContent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.chkManualProtectContent.ForeColor = Color.White;
            this.chkManualProtectContent.Location = new Point(338, 660);
            this.chkManualProtectContent.MinimumSize = new Size(1, 1);
            this.chkManualProtectContent.Name = "chkManualProtectContent";
            this.chkManualProtectContent.Size = new Size(320, 25);
            this.chkManualProtectContent.TabIndex = 126;
            this.chkManualProtectContent.Text = "Защитить от копирования и пересылки";

            this.chkManualDeletePrevious.BackColor = Color.Transparent;
            this.chkManualDeletePrevious.CheckBoxColor = Color.BlueViolet;
            this.chkManualDeletePrevious.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.chkManualDeletePrevious.ForeColor = Color.White;
            this.chkManualDeletePrevious.Location = new Point(9, 690);
            this.chkManualDeletePrevious.MinimumSize = new Size(1, 1);
            this.chkManualDeletePrevious.Name = "chkManualDeletePrevious";
            this.chkManualDeletePrevious.Size = new Size(658, 25);
            this.chkManualDeletePrevious.TabIndex = 129;
            this.chkManualDeletePrevious.Text = "Удалить предыдущее сообщение бота перед отправкой";

            this.chkManualPinMessage.BackColor = Color.Transparent;
            this.chkManualPinMessage.CheckBoxColor = Color.BlueViolet;
            this.chkManualPinMessage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.chkManualPinMessage.ForeColor = Color.White;
            this.chkManualPinMessage.Location = new Point(9, 720);
            this.chkManualPinMessage.MinimumSize = new Size(1, 1);
            this.chkManualPinMessage.Name = "chkManualPinMessage";
            this.chkManualPinMessage.Size = new Size(95, 25);
            this.chkManualPinMessage.TabIndex = 127;
            this.chkManualPinMessage.Text = "Закрепить:";

            this.cmbManualPinTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.cmbManualPinTarget.DataSource = null;
            this.cmbManualPinTarget.DropDownAutoWidth = true;
            this.cmbManualPinTarget.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbManualPinTarget.FillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualPinTarget.FillColor2 = Color.Transparent;
            this.cmbManualPinTarget.FillDisableColor = Color.FromArgb(37, 40, 50);
            this.cmbManualPinTarget.Font = new Font("Segoe UI", 9F);
            this.cmbManualPinTarget.ForeColor = Color.White;
            this.cmbManualPinTarget.ItemFillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualPinTarget.ItemForeColor = Color.White;
            this.cmbManualPinTarget.ItemHoverColor = Color.FromArgb(124, 58, 237);
            this.cmbManualPinTarget.ItemRectColor = Color.FromArgb(58, 63, 75);
            this.cmbManualPinTarget.Items.AddRange(new object[] { "Отменить выбор", "Закрепить только шаблон", "Закрепить только текст", "Закрепить оба (сначала шаблон, потом текст)", "Закрепить оба (сначала текст, потом шаблон)" });
            this.cmbManualPinTarget.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            this.cmbManualPinTarget.ItemSelectForeColor = Color.White;
            this.cmbManualPinTarget.Location = new Point(110, 720);
            this.cmbManualPinTarget.Margin = new Padding(4, 5, 4, 5);
            this.cmbManualPinTarget.MinimumSize = new Size(63, 0);
            this.cmbManualPinTarget.Name = "cmbManualPinTarget";
            this.cmbManualPinTarget.Padding = new Padding(0, 0, 30, 2);
            this.cmbManualPinTarget.RectColor = Color.FromArgb(65, 71, 84);
            this.cmbManualPinTarget.RectDisableColor = Color.FromArgb(54, 59, 70);
            this.cmbManualPinTarget.Size = new Size(548, 25);
            this.cmbManualPinTarget.Style = Sunny.UI.UIStyle.Custom;
            this.cmbManualPinTarget.StyleDropDown = Sunny.UI.UIStyle.Purple;
            this.cmbManualPinTarget.SymbolSize = 24;
            this.cmbManualPinTarget.TabIndex = 117;
            this.cmbManualPinTarget.TextAlignment = ContentAlignment.MiddleLeft;
            this.cmbManualPinTarget.Watermark = "Выберите что закрепить";

            // --- 5. АНИМАЦИИ ---
            this.chkManualAnimatedEmoji.BackColor = Color.Transparent;
            this.chkManualAnimatedEmoji.CheckBoxColor = Color.BlueViolet;
            this.chkManualAnimatedEmoji.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.chkManualAnimatedEmoji.ForeColor = Color.White;
            this.chkManualAnimatedEmoji.Location = new Point(9, 755);
            this.chkManualAnimatedEmoji.MinimumSize = new Size(1, 1);
            this.chkManualAnimatedEmoji.Name = "chkManualAnimatedEmoji";
            this.chkManualAnimatedEmoji.Size = new Size(239, 25);
            this.chkManualAnimatedEmoji.TabIndex = 118;
            this.chkManualAnimatedEmoji.Text = "Добавить анимированный смайлик:";

            this.cmbManualAnimatedEmoji.DataSource = null;
            this.cmbManualAnimatedEmoji.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbManualAnimatedEmoji.FillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualAnimatedEmoji.FillColor2 = Color.Transparent;
            this.cmbManualAnimatedEmoji.FillDisableColor = Color.FromArgb(37, 40, 50);
            this.cmbManualAnimatedEmoji.Font = new Font("Segoe UI", 9F);
            this.cmbManualAnimatedEmoji.ForeColor = Color.White;
            this.cmbManualAnimatedEmoji.ItemFillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualAnimatedEmoji.ItemForeColor = Color.White;
            this.cmbManualAnimatedEmoji.ItemHoverColor = Color.FromArgb(124, 58, 237);
            this.cmbManualAnimatedEmoji.ItemRectColor = Color.FromArgb(58, 63, 75);
            this.cmbManualAnimatedEmoji.Items.AddRange(new object[] { "Отменить выбор", "👍 Лайк", "👎 Дизлайк", "❤️ Сердце", "🔥 Огонь", "🥰 Лицо с сердечками", "👏 Аплодисменты", "😁 Улыбка", "🤔 Задумчивость", "🤯 Взрыв мозга", "😱 Крик от страха", "🤬 Мат", "😢 Плач", "🎉 Праздник", "🤩 Звёзды в глазах", "🤮 Тошнота", "💩 Какашка", "🙏 Молитва", "👌 ОК", "🕊️ Голубь", "🤝 Рукопожатие", "🍾 Бутылка", "🎂 Торт", "🎄 Ёлка", "🎆 Фейерверк", "🎇 Бенгальский огонь", "🧨 Петарда", "✨ Искры", "🎈 Шарик", "🎊 Конфетти", "🎁 Подарок", "🏆 Трофей", "🥇 Медаль", "⚽ Мяч", "🏀 Баскетбол", "🎯 Мишень", "🎲 Кубик", "🎰 Слот-машина", "🎳 Боулинг", "🍕 Пицца", "🍔 Бургер", "🍟 Картошка фри", "🍿 Попкорн", "☕ Кофе", "🍺 Пиво", "🥂 Бокалы", "🚀 Ракета", "✈️ Самолёт", "🌟 Звезда", "💯 100 баллов", "🌈 Радуга", "☃️ Снеговик", "⛄ Снеговик", "🎃 Тыква", "🎅 Санта", "🤶 Снегурочка", "🔔 Колокольчик", "🎵 Нота", "🎶 Ноты", "💤 Сон", "💣 Бомба", "💥 Столкновение", "💦 Капли", "💨 Ветер" });
            this.cmbManualAnimatedEmoji.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            this.cmbManualAnimatedEmoji.ItemSelectForeColor = Color.White;
            this.cmbManualAnimatedEmoji.Location = new Point(258, 755);
            this.cmbManualAnimatedEmoji.Margin = new Padding(4, 5, 4, 5);
            this.cmbManualAnimatedEmoji.MinimumSize = new Size(63, 0);
            this.cmbManualAnimatedEmoji.Name = "cmbManualAnimatedEmoji";
            this.cmbManualAnimatedEmoji.Padding = new Padding(0, 0, 30, 2);
            this.cmbManualAnimatedEmoji.RectColor = Color.FromArgb(65, 71, 84);
            this.cmbManualAnimatedEmoji.RectDisableColor = Color.FromArgb(54, 59, 70);
            this.cmbManualAnimatedEmoji.Size = new Size(154, 25);
            this.cmbManualAnimatedEmoji.Style = Sunny.UI.UIStyle.Custom;
            this.cmbManualAnimatedEmoji.StyleDropDown = Sunny.UI.UIStyle.Purple;
            this.cmbManualAnimatedEmoji.SymbolSize = 24;
            this.cmbManualAnimatedEmoji.TabIndex = 115;
            this.cmbManualAnimatedEmoji.TextAlignment = ContentAlignment.MiddleLeft;
            this.cmbManualAnimatedEmoji.Watermark = "Выберите смайлик";

            this.cmbManualEmojiApplyTo.DataSource = null;
            this.cmbManualEmojiApplyTo.DropDownAutoWidth = true;
            this.cmbManualEmojiApplyTo.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbManualEmojiApplyTo.FillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualEmojiApplyTo.FillColor2 = Color.Transparent;
            this.cmbManualEmojiApplyTo.FillDisableColor = Color.FromArgb(37, 40, 50);
            this.cmbManualEmojiApplyTo.Font = new Font("Segoe UI", 9F);
            this.cmbManualEmojiApplyTo.ForeColor = Color.White;
            this.cmbManualEmojiApplyTo.ItemFillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualEmojiApplyTo.ItemForeColor = Color.White;
            this.cmbManualEmojiApplyTo.ItemHoverColor = Color.FromArgb(124, 58, 237);
            this.cmbManualEmojiApplyTo.ItemRectColor = Color.FromArgb(58, 63, 75);
            this.cmbManualEmojiApplyTo.Items.AddRange(new object[] { "Отменить выбор", "После пользовательского сообщения", "После шаблона", "После всех сообщений", "Перед всеми сообщениями", "После каждого сообщения" });
            this.cmbManualEmojiApplyTo.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            this.cmbManualEmojiApplyTo.ItemSelectForeColor = Color.White;
            this.cmbManualEmojiApplyTo.Location = new Point(420, 755);
            this.cmbManualEmojiApplyTo.Margin = new Padding(4, 5, 4, 5);
            this.cmbManualEmojiApplyTo.MinimumSize = new Size(63, 0);
            this.cmbManualEmojiApplyTo.Name = "cmbManualEmojiApplyTo";
            this.cmbManualEmojiApplyTo.Padding = new Padding(0, 0, 30, 2);
            this.cmbManualEmojiApplyTo.RectColor = Color.FromArgb(65, 71, 84);
            this.cmbManualEmojiApplyTo.RectDisableColor = Color.FromArgb(54, 59, 70);
            this.cmbManualEmojiApplyTo.Size = new Size(238, 25);
            this.cmbManualEmojiApplyTo.Style = Sunny.UI.UIStyle.Custom;
            this.cmbManualEmojiApplyTo.StyleDropDown = Sunny.UI.UIStyle.Purple;
            this.cmbManualEmojiApplyTo.SymbolSize = 24;
            this.cmbManualEmojiApplyTo.TabIndex = 121;
            this.cmbManualEmojiApplyTo.TextAlignment = ContentAlignment.MiddleLeft;
            this.cmbManualEmojiApplyTo.Watermark = "Отправить после";

            this.chkManualAnimatedEffect.BackColor = Color.Transparent;
            this.chkManualAnimatedEffect.CheckBoxColor = Color.BlueViolet;
            this.chkManualAnimatedEffect.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.chkManualAnimatedEffect.ForeColor = Color.White;
            this.chkManualAnimatedEffect.Location = new Point(9, 790);
            this.chkManualAnimatedEffect.MinimumSize = new Size(1, 1);
            this.chkManualAnimatedEffect.Name = "chkManualAnimatedEffect";
            this.chkManualAnimatedEffect.Size = new Size(239, 25);
            this.chkManualAnimatedEffect.TabIndex = 119;
            this.chkManualAnimatedEffect.Text = "Добавить анимированный эффект:";

            this.cmbManualAnimatedEffect.DataSource = null;
            this.cmbManualAnimatedEffect.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbManualAnimatedEffect.FillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualAnimatedEffect.FillColor2 = Color.Transparent;
            this.cmbManualAnimatedEffect.FillDisableColor = Color.FromArgb(37, 40, 50);
            this.cmbManualAnimatedEffect.Font = new Font("Segoe UI", 9F);
            this.cmbManualAnimatedEffect.ForeColor = Color.White;
            this.cmbManualAnimatedEffect.ItemFillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualAnimatedEffect.ItemForeColor = Color.White;
            this.cmbManualAnimatedEffect.ItemHoverColor = Color.FromArgb(124, 58, 237);
            this.cmbManualAnimatedEffect.ItemRectColor = Color.FromArgb(58, 63, 75);
            this.cmbManualAnimatedEffect.Items.AddRange(new object[] { "Отменить выбор", "👍 Лайк", "👎 Дизлайк", "❤️ Сердце", "🔥 Огонь", "🥰 Лицо с сердечками", "👏 Аплодисменты", "😁 Улыбка", "🤔 Задумчивость", "🤯 Взрыв мозга", "😱 Крик от страха", "🤬 Мат", "😢 Плач", "🎉 Праздник", "🤩 Звёзды в глазах", "🤮 Тошнота", "💩 Какашка", "🙏 Молитва", "👌 ОК", "🕊️ Голубь", "🤝 Рукопожатие", "🍾 Бутылка", "🎂 Торт", "🎄 Ёлка", "🎆 Фейерверк", "🎇 Бенгальский огонь", "🧨 Петарда", "✨ Искры", "🎈 Шарик", "🎊 Конфетти", "🎁 Подарок", "🏆 Трофей", "🥇 Медаль", "⚽ Мяч", "🏀 Баскетбол", "🎯 Мишень", "🎲 Кубик", "🎰 Слот-машина", "🎳 Боулинг", "🍕 Пицца", "🍔 Бургер", "🍟 Картошка фри", "🍿 Попкорн", "☕ Кофе", "🍺 Пиво", "🥂 Бокалы", "🚀 Ракета", "✈️ Самолёт", "🌟 Звезда", "💯 100 баллов", "🌈 Радуга", "☃️ Снеговик", "⛄ Снеговик", "🎃 Тыква", "🎅 Санта", "🤶 Снегурочка", "🔔 Колокольчик", "🎵 Нота", "🎶 Ноты", "💤 Сон", "💣 Бомба", "💥 Столкновение", "💦 Капли", "💨 Ветер" });
            this.cmbManualAnimatedEffect.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            this.cmbManualAnimatedEffect.ItemSelectForeColor = Color.White;
            this.cmbManualAnimatedEffect.Location = new Point(258, 790);
            this.cmbManualAnimatedEffect.Margin = new Padding(4, 5, 4, 5);
            this.cmbManualAnimatedEffect.MinimumSize = new Size(63, 0);
            this.cmbManualAnimatedEffect.Name = "cmbManualAnimatedEffect";
            this.cmbManualAnimatedEffect.Padding = new Padding(0, 0, 30, 2);
            this.cmbManualAnimatedEffect.RectColor = Color.FromArgb(65, 71, 84);
            this.cmbManualAnimatedEffect.RectDisableColor = Color.FromArgb(54, 59, 70);
            this.cmbManualAnimatedEffect.Size = new Size(154, 25);
            this.cmbManualAnimatedEffect.Style = Sunny.UI.UIStyle.Custom;
            this.cmbManualAnimatedEffect.StyleDropDown = Sunny.UI.UIStyle.Purple;
            this.cmbManualAnimatedEffect.SymbolSize = 24;
            this.cmbManualAnimatedEffect.TabIndex = 116;
            this.cmbManualAnimatedEffect.TextAlignment = ContentAlignment.MiddleLeft;
            this.cmbManualAnimatedEffect.Watermark = "Выберите эффект";

            this.cmbManualEffectApplyTo.DataSource = null;
            this.cmbManualEffectApplyTo.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbManualEffectApplyTo.FillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualEffectApplyTo.FillColor2 = Color.Transparent;
            this.cmbManualEffectApplyTo.FillDisableColor = Color.FromArgb(37, 40, 50);
            this.cmbManualEffectApplyTo.Font = new Font("Segoe UI", 9F);
            this.cmbManualEffectApplyTo.ForeColor = Color.White;
            this.cmbManualEffectApplyTo.ItemFillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualEffectApplyTo.ItemForeColor = Color.White;
            this.cmbManualEffectApplyTo.ItemHoverColor = Color.FromArgb(124, 58, 237);
            this.cmbManualEffectApplyTo.ItemRectColor = Color.FromArgb(58, 63, 75);
            this.cmbManualEffectApplyTo.Items.AddRange(new object[] { "Отменить выбор", "Только на сообщение", "Только на шаблон", "На оба" });
            this.cmbManualEffectApplyTo.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            this.cmbManualEffectApplyTo.ItemSelectForeColor = Color.White;
            this.cmbManualEffectApplyTo.Location = new Point(420, 790);
            this.cmbManualEffectApplyTo.Margin = new Padding(4, 5, 4, 5);
            this.cmbManualEffectApplyTo.MinimumSize = new Size(63, 0);
            this.cmbManualEffectApplyTo.Name = "cmbManualEffectApplyTo";
            this.cmbManualEffectApplyTo.Padding = new Padding(0, 0, 30, 2);
            this.cmbManualEffectApplyTo.RectColor = Color.FromArgb(65, 71, 84);
            this.cmbManualEffectApplyTo.RectDisableColor = Color.FromArgb(54, 59, 70);
            this.cmbManualEffectApplyTo.Size = new Size(238, 25);
            this.cmbManualEffectApplyTo.Style = Sunny.UI.UIStyle.Custom;
            this.cmbManualEffectApplyTo.StyleDropDown = Sunny.UI.UIStyle.Purple;
            this.cmbManualEffectApplyTo.SymbolSize = 24;
            this.cmbManualEffectApplyTo.TabIndex = 120;
            this.cmbManualEffectApplyTo.TextAlignment = ContentAlignment.MiddleLeft;
            this.cmbManualEffectApplyTo.Watermark = "Применить на";

            // --- 6. УВЕДОМЛЕНИЯ ---
            this.chkManualNotifySuccess.BackColor = Color.Transparent;
            this.chkManualNotifySuccess.CheckBoxColor = Color.BlueViolet;
            this.chkManualNotifySuccess.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.chkManualNotifySuccess.ForeColor = Color.White;
            this.chkManualNotifySuccess.Location = new Point(9, 825);
            this.chkManualNotifySuccess.MinimumSize = new Size(1, 1);
            this.chkManualNotifySuccess.Name = "chkManualNotifySuccess";
            this.chkManualNotifySuccess.Size = new Size(265, 25);
            this.chkManualNotifySuccess.TabIndex = 103;
            this.chkManualNotifySuccess.Text = "Уведомлять все успешные отправки в:";

            this.cmbManualNotifySuccess1.DataSource = null;
            this.cmbManualNotifySuccess1.DropDownAutoWidth = true;
            this.cmbManualNotifySuccess1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbManualNotifySuccess1.FillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualNotifySuccess1.FillColor2 = Color.Transparent;
            this.cmbManualNotifySuccess1.FillDisableColor = Color.FromArgb(37, 40, 50);
            this.cmbManualNotifySuccess1.Font = new Font("Segoe UI", 9F);
            this.cmbManualNotifySuccess1.ForeColor = Color.White;
            this.cmbManualNotifySuccess1.ItemFillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualNotifySuccess1.ItemForeColor = Color.White;
            this.cmbManualNotifySuccess1.ItemHoverColor = Color.FromArgb(124, 58, 237);
            this.cmbManualNotifySuccess1.ItemRectColor = Color.FromArgb(58, 63, 75);
            this.cmbManualNotifySuccess1.Items.AddRange(new object[] { "Отменить выбор", "В личные сообщения", "В приложении" });
            this.cmbManualNotifySuccess1.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            this.cmbManualNotifySuccess1.ItemSelectForeColor = Color.White;
            this.cmbManualNotifySuccess1.Location = new Point(280, 825);
            this.cmbManualNotifySuccess1.Margin = new Padding(4, 5, 4, 5);
            this.cmbManualNotifySuccess1.MinimumSize = new Size(63, 0);
            this.cmbManualNotifySuccess1.Name = "cmbManualNotifySuccess1";
            this.cmbManualNotifySuccess1.Padding = new Padding(0, 0, 30, 2);
            this.cmbManualNotifySuccess1.RectColor = Color.FromArgb(65, 71, 84);
            this.cmbManualNotifySuccess1.RectDisableColor = Color.FromArgb(54, 59, 70);
            this.cmbManualNotifySuccess1.Size = new Size(146, 25);
            this.cmbManualNotifySuccess1.Style = Sunny.UI.UIStyle.Custom;
            this.cmbManualNotifySuccess1.StyleDropDown = Sunny.UI.UIStyle.Purple;
            this.cmbManualNotifySuccess1.SymbolSize = 24;
            this.cmbManualNotifySuccess1.TabIndex = 105;
            this.cmbManualNotifySuccess1.TextAlignment = ContentAlignment.MiddleLeft;
            this.cmbManualNotifySuccess1.Watermark = "Куда отправить";

            this.lblManualNotifySuccessOr.AutoSize = true;
            this.lblManualNotifySuccessOr.BackColor = Color.Transparent;
            this.lblManualNotifySuccessOr.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            this.lblManualNotifySuccessOr.ForeColor = Color.FromArgb(180, 180, 180);
            this.lblManualNotifySuccessOr.Location = new Point(432, 830);
            this.lblManualNotifySuccessOr.Name = "lblManualNotifySuccessOr";
            this.lblManualNotifySuccessOr.Size = new Size(39, 13);
            this.lblManualNotifySuccessOr.TabIndex = 112;
            this.lblManualNotifySuccessOr.Text = "и/или";

            this.cmbManualNotifySuccess2.DataSource = null;
            this.cmbManualNotifySuccess2.DropDownAutoWidth = true;
            this.cmbManualNotifySuccess2.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbManualNotifySuccess2.FillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualNotifySuccess2.FillColor2 = Color.Transparent;
            this.cmbManualNotifySuccess2.FillDisableColor = Color.FromArgb(37, 40, 50);
            this.cmbManualNotifySuccess2.Font = new Font("Segoe UI", 9F);
            this.cmbManualNotifySuccess2.ForeColor = Color.White;
            this.cmbManualNotifySuccess2.ItemFillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualNotifySuccess2.ItemForeColor = Color.White;
            this.cmbManualNotifySuccess2.ItemHoverColor = Color.FromArgb(124, 58, 237);
            this.cmbManualNotifySuccess2.ItemRectColor = Color.FromArgb(58, 63, 75);
            this.cmbManualNotifySuccess2.Items.AddRange(new object[] { "Отменить выбор", "В личные сообщения", "В приложении" });
            this.cmbManualNotifySuccess2.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            this.cmbManualNotifySuccess2.ItemSelectForeColor = Color.White;
            this.cmbManualNotifySuccess2.Location = new Point(479, 825);
            this.cmbManualNotifySuccess2.Margin = new Padding(4, 5, 4, 5);
            this.cmbManualNotifySuccess2.MinimumSize = new Size(63, 0);
            this.cmbManualNotifySuccess2.Name = "cmbManualNotifySuccess2";
            this.cmbManualNotifySuccess2.Padding = new Padding(0, 0, 30, 2);
            this.cmbManualNotifySuccess2.RectColor = Color.FromArgb(65, 71, 84);
            this.cmbManualNotifySuccess2.RectDisableColor = Color.FromArgb(54, 59, 70);
            this.cmbManualNotifySuccess2.Size = new Size(177, 25);
            this.cmbManualNotifySuccess2.Style = Sunny.UI.UIStyle.Custom;
            this.cmbManualNotifySuccess2.StyleDropDown = Sunny.UI.UIStyle.Purple;
            this.cmbManualNotifySuccess2.SymbolSize = 24;
            this.cmbManualNotifySuccess2.TabIndex = 107;
            this.cmbManualNotifySuccess2.TextAlignment = ContentAlignment.MiddleLeft;
            this.cmbManualNotifySuccess2.Watermark = "Куда отправить";

            this.chkManualNotifyComplete.BackColor = Color.Transparent;
            this.chkManualNotifyComplete.CheckBoxColor = Color.BlueViolet;
            this.chkManualNotifyComplete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.chkManualNotifyComplete.ForeColor = Color.White;
            this.chkManualNotifyComplete.Location = new Point(9, 860);
            this.chkManualNotifyComplete.MinimumSize = new Size(1, 1);
            this.chkManualNotifyComplete.Name = "chkManualNotifyComplete";
            this.chkManualNotifyComplete.Size = new Size(265, 25);
            this.chkManualNotifyComplete.TabIndex = 104;
            this.chkManualNotifyComplete.Text = "Уведомить при завершении сессии в:";

            this.cmbManualNotifyComplete1.DataSource = null;
            this.cmbManualNotifyComplete1.DropDownAutoWidth = true;
            this.cmbManualNotifyComplete1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbManualNotifyComplete1.FillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualNotifyComplete1.FillColor2 = Color.Transparent;
            this.cmbManualNotifyComplete1.FillDisableColor = Color.FromArgb(37, 40, 50);
            this.cmbManualNotifyComplete1.Font = new Font("Segoe UI", 9F);
            this.cmbManualNotifyComplete1.ForeColor = Color.White;
            this.cmbManualNotifyComplete1.ItemFillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualNotifyComplete1.ItemForeColor = Color.White;
            this.cmbManualNotifyComplete1.ItemHoverColor = Color.FromArgb(124, 58, 237);
            this.cmbManualNotifyComplete1.ItemRectColor = Color.FromArgb(58, 63, 75);
            this.cmbManualNotifyComplete1.Items.AddRange(new object[] { "Отменить выбор", "В личные сообщения", "В приложении" });
            this.cmbManualNotifyComplete1.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            this.cmbManualNotifyComplete1.ItemSelectForeColor = Color.White;
            this.cmbManualNotifyComplete1.Location = new Point(280, 860);
            this.cmbManualNotifyComplete1.Margin = new Padding(4, 5, 4, 5);
            this.cmbManualNotifyComplete1.MinimumSize = new Size(63, 0);
            this.cmbManualNotifyComplete1.Name = "cmbManualNotifyComplete1";
            this.cmbManualNotifyComplete1.Padding = new Padding(0, 0, 30, 2);
            this.cmbManualNotifyComplete1.RectColor = Color.FromArgb(65, 71, 84);
            this.cmbManualNotifyComplete1.RectDisableColor = Color.FromArgb(54, 59, 70);
            this.cmbManualNotifyComplete1.Size = new Size(146, 25);
            this.cmbManualNotifyComplete1.Style = Sunny.UI.UIStyle.Custom;
            this.cmbManualNotifyComplete1.StyleDropDown = Sunny.UI.UIStyle.Purple;
            this.cmbManualNotifyComplete1.SymbolSize = 24;
            this.cmbManualNotifyComplete1.TabIndex = 106;
            this.cmbManualNotifyComplete1.TextAlignment = ContentAlignment.MiddleLeft;
            this.cmbManualNotifyComplete1.Watermark = "Куда отправить";

            this.lblManualNotifyCompleteOr.AutoSize = true;
            this.lblManualNotifyCompleteOr.BackColor = Color.Transparent;
            this.lblManualNotifyCompleteOr.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            this.lblManualNotifyCompleteOr.ForeColor = Color.FromArgb(180, 180, 180);
            this.lblManualNotifyCompleteOr.Location = new Point(432, 865);
            this.lblManualNotifyCompleteOr.Name = "lblManualNotifyCompleteOr";
            this.lblManualNotifyCompleteOr.Size = new Size(39, 13);
            this.lblManualNotifyCompleteOr.TabIndex = 113;
            this.lblManualNotifyCompleteOr.Text = "и/или";

            this.cmbManualNotifyComplete2.DataSource = null;
            this.cmbManualNotifyComplete2.DropDownAutoWidth = true;
            this.cmbManualNotifyComplete2.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbManualNotifyComplete2.FillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualNotifyComplete2.FillColor2 = Color.Transparent;
            this.cmbManualNotifyComplete2.FillDisableColor = Color.FromArgb(37, 40, 50);
            this.cmbManualNotifyComplete2.Font = new Font("Segoe UI", 9F);
            this.cmbManualNotifyComplete2.ForeColor = Color.White;
            this.cmbManualNotifyComplete2.ItemFillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualNotifyComplete2.ItemForeColor = Color.White;
            this.cmbManualNotifyComplete2.ItemHoverColor = Color.FromArgb(124, 58, 237);
            this.cmbManualNotifyComplete2.ItemRectColor = Color.FromArgb(58, 63, 75);
            this.cmbManualNotifyComplete2.Items.AddRange(new object[] { "Отменить выбор", "В личные сообщения", "В приложении" });
            this.cmbManualNotifyComplete2.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            this.cmbManualNotifyComplete2.ItemSelectForeColor = Color.White;
            this.cmbManualNotifyComplete2.Location = new Point(479, 860);
            this.cmbManualNotifyComplete2.Margin = new Padding(4, 5, 4, 5);
            this.cmbManualNotifyComplete2.MinimumSize = new Size(63, 0);
            this.cmbManualNotifyComplete2.Name = "cmbManualNotifyComplete2";
            this.cmbManualNotifyComplete2.Padding = new Padding(0, 0, 30, 2);
            this.cmbManualNotifyComplete2.RectColor = Color.FromArgb(65, 71, 84);
            this.cmbManualNotifyComplete2.RectDisableColor = Color.FromArgb(54, 59, 70);
            this.cmbManualNotifyComplete2.Size = new Size(177, 25);
            this.cmbManualNotifyComplete2.Style = Sunny.UI.UIStyle.Custom;
            this.cmbManualNotifyComplete2.StyleDropDown = Sunny.UI.UIStyle.Purple;
            this.cmbManualNotifyComplete2.SymbolSize = 24;
            this.cmbManualNotifyComplete2.TabIndex = 108;
            this.cmbManualNotifyComplete2.TextAlignment = ContentAlignment.MiddleLeft;
            this.cmbManualNotifyComplete2.Watermark = "Куда отправить";

            this.chkManualNotifyError.BackColor = Color.Transparent;
            this.chkManualNotifyError.CheckBoxColor = Color.BlueViolet;
            this.chkManualNotifyError.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.chkManualNotifyError.ForeColor = Color.White;
            this.chkManualNotifyError.Location = new Point(9, 895);
            this.chkManualNotifyError.MinimumSize = new Size(1, 1);
            this.chkManualNotifyError.Name = "chkManualNotifyError";
            this.chkManualNotifyError.Size = new Size(265, 25);
            this.chkManualNotifyError.TabIndex = 111;
            this.chkManualNotifyError.Text = "Уведомлять любую ошибку в:";

            this.cmbManualNotifyError1.DataSource = null;
            this.cmbManualNotifyError1.DropDownAutoWidth = true;
            this.cmbManualNotifyError1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbManualNotifyError1.FillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualNotifyError1.FillColor2 = Color.Transparent;
            this.cmbManualNotifyError1.FillDisableColor = Color.FromArgb(37, 40, 50);
            this.cmbManualNotifyError1.Font = new Font("Segoe UI", 9F);
            this.cmbManualNotifyError1.ForeColor = Color.White;
            this.cmbManualNotifyError1.ItemFillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualNotifyError1.ItemForeColor = Color.White;
            this.cmbManualNotifyError1.ItemHoverColor = Color.FromArgb(124, 58, 237);
            this.cmbManualNotifyError1.ItemRectColor = Color.FromArgb(58, 63, 75);
            this.cmbManualNotifyError1.Items.AddRange(new object[] { "Отменить выбор", "В личные сообщения", "В приложении" });
            this.cmbManualNotifyError1.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            this.cmbManualNotifyError1.ItemSelectForeColor = Color.White;
            this.cmbManualNotifyError1.Location = new Point(280, 895);
            this.cmbManualNotifyError1.Margin = new Padding(4, 5, 4, 5);
            this.cmbManualNotifyError1.MinimumSize = new Size(63, 0);
            this.cmbManualNotifyError1.Name = "cmbManualNotifyError1";
            this.cmbManualNotifyError1.Padding = new Padding(0, 0, 30, 2);
            this.cmbManualNotifyError1.RectColor = Color.FromArgb(65, 71, 84);
            this.cmbManualNotifyError1.RectDisableColor = Color.FromArgb(54, 59, 70);
            this.cmbManualNotifyError1.Size = new Size(146, 25);
            this.cmbManualNotifyError1.Style = Sunny.UI.UIStyle.Custom;
            this.cmbManualNotifyError1.StyleDropDown = Sunny.UI.UIStyle.Purple;
            this.cmbManualNotifyError1.SymbolSize = 24;
            this.cmbManualNotifyError1.TabIndex = 109;
            this.cmbManualNotifyError1.TextAlignment = ContentAlignment.MiddleLeft;
            this.cmbManualNotifyError1.Watermark = "Куда отправить";

            this.lblManualNotifyErrorOr.AutoSize = true;
            this.lblManualNotifyErrorOr.BackColor = Color.Transparent;
            this.lblManualNotifyErrorOr.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            this.lblManualNotifyErrorOr.ForeColor = Color.FromArgb(180, 180, 180);
            this.lblManualNotifyErrorOr.Location = new Point(432, 900);
            this.lblManualNotifyErrorOr.Name = "lblManualNotifyErrorOr";
            this.lblManualNotifyErrorOr.Size = new Size(39, 13);
            this.lblManualNotifyErrorOr.TabIndex = 114;
            this.lblManualNotifyErrorOr.Text = "и/или";

            this.cmbManualNotifyError2.DataSource = null;
            this.cmbManualNotifyError2.DropDownAutoWidth = true;
            this.cmbManualNotifyError2.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbManualNotifyError2.FillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualNotifyError2.FillColor2 = Color.Transparent;
            this.cmbManualNotifyError2.FillDisableColor = Color.FromArgb(37, 40, 50);
            this.cmbManualNotifyError2.Font = new Font("Segoe UI", 9F);
            this.cmbManualNotifyError2.ForeColor = Color.White;
            this.cmbManualNotifyError2.ItemFillColor = Color.FromArgb(42, 46, 57);
            this.cmbManualNotifyError2.ItemForeColor = Color.White;
            this.cmbManualNotifyError2.ItemHoverColor = Color.FromArgb(124, 58, 237);
            this.cmbManualNotifyError2.ItemRectColor = Color.FromArgb(58, 63, 75);
            this.cmbManualNotifyError2.Items.AddRange(new object[] { "Отменить выбор", "В личные сообщения", "В приложении" });
            this.cmbManualNotifyError2.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            this.cmbManualNotifyError2.ItemSelectForeColor = Color.White;
            this.cmbManualNotifyError2.Location = new Point(479, 895);
            this.cmbManualNotifyError2.Margin = new Padding(4, 5, 4, 5);
            this.cmbManualNotifyError2.MinimumSize = new Size(63, 0);
            this.cmbManualNotifyError2.Name = "cmbManualNotifyError2";
            this.cmbManualNotifyError2.Padding = new Padding(0, 0, 30, 2);
            this.cmbManualNotifyError2.RectColor = Color.FromArgb(65, 71, 84);
            this.cmbManualNotifyError2.RectDisableColor = Color.FromArgb(54, 59, 70);
            this.cmbManualNotifyError2.Size = new Size(177, 25);
            this.cmbManualNotifyError2.Style = Sunny.UI.UIStyle.Custom;
            this.cmbManualNotifyError2.StyleDropDown = Sunny.UI.UIStyle.Purple;
            this.cmbManualNotifyError2.SymbolSize = 24;
            this.cmbManualNotifyError2.TabIndex = 110;
            this.cmbManualNotifyError2.TextAlignment = ContentAlignment.MiddleLeft;
            this.cmbManualNotifyError2.Watermark = "Куда отправить";

            // --- 7. ИСТОРИЯ ---
            this.grpEventHistory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.grpEventHistory.Controls.Add(this.flpEventHistory);
            this.grpEventHistory.FillColor = Color.Transparent;
            this.grpEventHistory.FillColor2 = Color.Transparent;
            this.grpEventHistory.FillDisableColor = Color.Transparent;
            this.grpEventHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.grpEventHistory.ForeColor = SystemColors.ActiveBorder;
            this.grpEventHistory.ForeDisableColor = Color.Transparent;
            this.grpEventHistory.Location = new Point(9, 940);
            this.grpEventHistory.Margin = new Padding(4, 5, 4, 5);
            this.grpEventHistory.MinimumSize = new Size(1, 1);
            this.grpEventHistory.Name = "grpEventHistory";
            this.grpEventHistory.Padding = new Padding(5, 32, 5, 5);
            this.grpEventHistory.RectColor = Color.FromArgb(58, 58, 69);
            this.grpEventHistory.RectDisableColor = Color.Transparent;
            this.grpEventHistory.Size = new Size(658, 350);
            this.grpEventHistory.TabIndex = 28;
            this.grpEventHistory.Text = "📊 История срабатываний:";
            this.grpEventHistory.TextAlignment = ContentAlignment.MiddleLeft;
            this.grpEventHistory.TitleTop = 10;

            this.flpEventHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.flpEventHistory.AutoScroll = true;
            this.flpEventHistory.FlowDirection = FlowDirection.TopDown;
            this.flpEventHistory.Location = new Point(10, 20);
            this.flpEventHistory.Name = "flpEventHistory";
            this.flpEventHistory.Size = new Size(636, 319);
            this.flpEventHistory.TabIndex = 10;
            this.flpEventHistory.WrapContents = false;

            // toolTip1
            this.toolTip1.BackColor = Color.FromArgb(30, 30, 36);
            this.toolTip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.toolTip1.ForeColor = Color.White;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.TitleFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);

            // EventTabControl
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.grpEvent);
            this.Name = "EventTabControl";
            this.Size = new Size(696, 483);

            this.grpEvent.ResumeLayout(false);
            this.pnlEventButtons.ResumeLayout(false);
            this.pnlEventInner.ResumeLayout(false);
            this.pnlEventContent.ResumeLayout(false);
            this.pnlEventContent.PerformLayout();
            this.grpEventHistory.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #region Поля элементов управления
        private Sunny.UI.UIGroupBox grpEvent;
        private Sunny.UI.UIPanel pnlEventButtons;
        private Sunny.UI.UICheckBox chkEventManualConfirm;
        private Sunny.UI.UIButton btnSaveEvent;
        private Sunny.UI.UIButton btnStartEvent;
        private Panel pnlEventInner;
        private Panel pnlEventContent;

        private Sunny.UI.UIComboBox cmbEventTemplate;
        private Sunny.UI.UITextBox txtEventCustomText;
        private Label lblEventTemplateHint;

        private Label lblRulesTitle;
        private FlowLayoutPanel flpTriggersList;
        private Sunny.UI.UIButton btnAddRule;

        private Label lblEventActions;
        private Sunny.UI.UICheckBox chkAutoPublish;
        private Sunny.UI.UICheckBox chkLogEvent;
        private Sunny.UI.UICheckBox chkSendNotification;
        private Sunny.UI.UICheckBox chkStopOnMatch;

        private Sunny.UI.UICheckBox chkManualSendTemplateFirst;
        private Sunny.UI.UICheckBox chkManualDisablePreview;
        private Sunny.UI.UICheckBox chkManualSilentSend;
        private Sunny.UI.UICheckBox chkManualReplyToLast;
        private Sunny.UI.UICheckBox chkManualHideSpoiler;
        private Sunny.UI.UICheckBox chkManualProtectContent;
        private Sunny.UI.UICheckBox chkManualDeletePrevious;
        private Sunny.UI.UICheckBox chkManualPinMessage;
        private Sunny.UI.UIComboBox cmbManualPinTarget;

        private Sunny.UI.UICheckBox chkManualAnimatedEmoji;
        private Sunny.UI.UIComboBox cmbManualAnimatedEmoji;
        private Sunny.UI.UIComboBox cmbManualEmojiApplyTo;
        private Sunny.UI.UICheckBox chkManualAnimatedEffect;
        private Sunny.UI.UIComboBox cmbManualAnimatedEffect;
        private Sunny.UI.UIComboBox cmbManualEffectApplyTo;

        private Sunny.UI.UICheckBox chkManualNotifySuccess;
        private Sunny.UI.UIComboBox cmbManualNotifySuccess1;
        private Label lblManualNotifySuccessOr;
        private Sunny.UI.UIComboBox cmbManualNotifySuccess2;
        private Sunny.UI.UICheckBox chkManualNotifyComplete;
        private Sunny.UI.UIComboBox cmbManualNotifyComplete1;
        private Label lblManualNotifyCompleteOr;
        private Sunny.UI.UIComboBox cmbManualNotifyComplete2;
        private Sunny.UI.UICheckBox chkManualNotifyError;
        private Sunny.UI.UIComboBox cmbManualNotifyError1;
        private Label lblManualNotifyErrorOr;
        private Sunny.UI.UIComboBox cmbManualNotifyError2;

        private Sunny.UI.UIGroupBox grpEventHistory;
        private FlowLayoutPanel flpEventHistory;
        private Sunny.UI.UIToolTip toolTip1;
        #endregion
    }
}