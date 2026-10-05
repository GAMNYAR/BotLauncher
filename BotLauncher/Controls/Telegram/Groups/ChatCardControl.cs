using BotLauncher.Controls.Base;
using BotLauncher.Models.Telegram;
using BotLauncher.Services.Telegram;
using Sunny.UI;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotLauncher.Controls.Telegram.Groups;

public partial class ChatCardControl : BaseControl
{
    private TelegramGroup? group;
    private readonly TelegramBotService? telegramBot;
    private ContextMenuStrip? contextMenu;
    private bool _isSelected;

    public event Action<TelegramGroup>? DeleteRequested;
    public event Action<TelegramGroup>? MoveUpRequested;
    public event Action<TelegramGroup>? MoveDownRequested;
    public event Action<TelegramGroup>? ChatSelected;

    public ChatCardControl(TelegramBotService? botService = null)
    {
        InitializeComponent();

        telegramBot = botService;

        contextMenu = new ContextMenuStrip();
        contextMenu.BackColor = Color.FromArgb(35, 39, 48);
        contextMenu.ForeColor = Color.White;
        contextMenu.Font = new Font("Segoe UI", 9F);
        contextMenu.Renderer = new CustomMenuRenderer();

        var menuItemUp = new ToolStripMenuItem("⬆ Поднять вверх");
        menuItemUp.Click += MenuItemUp_Click;
        contextMenu.Items.Add(menuItemUp);

        var menuItemDown = new ToolStripMenuItem("⬇ Опустить вниз");
        menuItemDown.Click += MenuItemDown_Click;
        contextMenu.Items.Add(menuItemDown);

        contextMenu.Items.Add(new ToolStripSeparator());

        var menuItemDelete = new ToolStripMenuItem("🗑 Удалить");
        menuItemDelete.ForeColor = Color.FromArgb(239, 68, 68);
        menuItemDelete.Click += MenuItemDelete_Click;
        contextMenu.Items.Add(menuItemDelete);

        btnChatMenu.Click += BtnChatMenu_Click;

        cardPanel.Click += CardPanel_Click;
        pnlAvatar.Click += CardPanel_Click;
        lblChatName.Click += CardPanel_Click;
        lblChatUsername.Click += CardPanel_Click;
        lblChatType.Click += CardPanel_Click;
        lblBotRole.Click += CardPanel_Click;
        lblChatId.Click += CardPanel_Click;
        lblMembers.Click += CardPanel_Click;
        lblChatStatus.Click += CardPanel_Click;

        pnlAvatar.BackgroundImageLayout = ImageLayout.Stretch;
        pnlAvatar.BackgroundImage = Properties.Resources.robot_solid;

        // ✅ Красная рамка по умолчанию (бот не работает)
        pnlAvatar.RectColor = Color.Red;

        SetSelected(false);
    }

    public void SetSelected(bool isSelected)
    {
        _isSelected = isSelected;

        if (cardPanel == null) return;

        if (isSelected)
        {
            cardPanel.FillColor = Color.Indigo;
            cardPanel.RectColor = Color.MediumSlateBlue;
        }
        else
        {
            cardPanel.FillColor = Color.FromArgb(35, 39, 48);
            cardPanel.RectColor = Color.FromArgb(58, 58, 69);
        }

        cardPanel.Invalidate();
        cardPanel.Update();
    }

    public void SetSessionStatus(bool isActive)
    {
        if (InvokeRequired)
        {
            Invoke(new Action(() => SetSessionStatus(isActive)));
            return;
        }

        pnlAvatar.RectColor = isActive ? Color.Lime : Color.Red;
        pnlAvatar.Invalidate();
    }

    private void BtnChatMenu_Click(object? sender, EventArgs e)
    {
        if (contextMenu == null || group == null) return;
        contextMenu.Show(btnChatMenu, new Point(0, btnChatMenu.Height));
    }

    private void MenuItemUp_Click(object? sender, EventArgs e)
    {
        if (group != null) MoveUpRequested?.Invoke(group);
    }

    private void MenuItemDown_Click(object? sender, EventArgs e)
    {
        if (group != null) MoveDownRequested?.Invoke(group);
    }

    private void MenuItemDelete_Click(object? sender, EventArgs e)
    {
        if (group != null) DeleteRequested?.Invoke(group);
    }

    private void CardPanel_Click(object? sender, EventArgs e)
    {
        if (group != null) ChatSelected?.Invoke(group);
    }

    public void SetData(TelegramGroup telegramGroup)
    {
        if (telegramGroup == null) return;

        group = telegramGroup;
        UpdateData();
        _ = LoadAvatarAsync();
    }

    private async Task LoadAvatarAsync()
    {
        if (telegramBot == null || group == null) return;

        try
        {
            byte[]? photoBytes = await telegramBot.GetChatPhotoAsync(group.ChatId);

            if (photoBytes != null && photoBytes.Length > 0)
            {
                using var stream = new MemoryStream(photoBytes);
                using Image? avatar = Image.FromStream(stream);

                if (avatar != null)
                {
                    var roundedImage = CreateRoundedImage(avatar, 6);

                    if (roundedImage != null)
                    {
                        var oldBg = pnlAvatar.BackgroundImage;
                        pnlAvatar.BackgroundImage = roundedImage;
                        pnlAvatar.Invalidate();
                        oldBg?.Dispose();
                    }
                }
            }
        }
        catch
        {
            pnlAvatar.BackgroundImage = Properties.Resources.robot_solid;
            pnlAvatar.RectColor = Color.Gray; // Серая при ошибке
            pnlAvatar.Invalidate();
        }
    }

    private Bitmap CreateRoundedImage(Image sourceImage, int cornerRadius)
    {
        int width = pnlAvatar.Width > 0 ? pnlAvatar.Width : 64;
        int height = pnlAvatar.Height > 0 ? pnlAvatar.Height : 64;

        Bitmap roundedBitmap = new Bitmap(width, height);
        roundedBitmap.SetResolution(sourceImage.HorizontalResolution, sourceImage.VerticalResolution);

        using (Graphics g = Graphics.FromImage(roundedBitmap))
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            using (GraphicsPath path = new GraphicsPath())
            {
                int padding = 2;
                int diameter = cornerRadius * 2;
                Rectangle rect = new Rectangle(padding, padding, width - padding * 2 - 1, height - padding * 2 - 1);

                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                g.SetClip(path);
                g.DrawImage(sourceImage, rect);
            }
        }

        return roundedBitmap;
    }

    public void UpdateData()
    {
        if (group == null) return;

        lblChatName.Text = group.Title;
        lblChatUsername.Text = string.IsNullOrWhiteSpace(group.Username) ? "@username" : $"@{group.Username.TrimStart('@')}";
        lblChatType.Text = group.Type;
        lblBotRole.Text = string.IsNullOrWhiteSpace(group.BotRole) ? "Роль: —" : $"Роль: {group.BotRole}";
        lblChatId.Text = $"ID: {group.ChatId}";
        lblMembers.Text = group.Members <= 0 ? "Участники: —" : (group.Type == "Канал" ? $"Подписчиков: {group.Members:N0}" : $"Участников: {group.Members:N0}");
        lblChatStatus.Text = string.IsNullOrWhiteSpace(group.ChatStatus) ? "Статус: —" : $"Статус: {group.ChatStatus}";
    }

    public TelegramGroup? GetGroup()
    {
        return group;
    }
}

public class CustomMenuRenderer : ToolStripProfessionalRenderer
{
    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
    {
        if (e.Item.Selected)
        {
            using var brush = new SolidBrush(Color.FromArgb(124, 58, 237));
            e.Graphics.FillRectangle(brush, new Rectangle(Point.Empty, e.Item.Size));
        }
        else
        {
            base.OnRenderMenuItemBackground(e);
        }
    }

    protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
    {
        using var pen = new Pen(Color.FromArgb(58, 63, 75));
        e.Graphics.DrawLine(pen, 0, e.Item.Height / 2, e.Item.Width, e.Item.Height / 2);
    }
}