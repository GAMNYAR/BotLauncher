using BotLauncher.Controls.Base;

namespace BotLauncher.Shared.Navigation
{
    public class NavigationManager
    {
        private readonly Control container;

        public NavigationManager(Control container)
        {
            this.container = container;
        }

        public void Open(BaseControl page)
        {
            // Если эта страница уже открыта — ничего не делаем
            if (container.Controls.Count > 0 &&
                ReferenceEquals(container.Controls[0], page) &&
                page.Visible)
                return;

            container.SuspendLayout();

            // ✅ СКРЫВАЕМ все контролы вместо удаления
            foreach (Control control in container.Controls)
            {
                control.Visible = false;
            }

            // ✅ Если контрол ещё не добавлен — добавляем
            if (!container.Controls.Contains(page))
            {
                page.Dock = DockStyle.Fill;
                container.Controls.Add(page);
            }

            // ✅ Показываем нужную страницу
            page.Visible = true;
            page.BringToFront();

            container.ResumeLayout(true);
        }
    }
}