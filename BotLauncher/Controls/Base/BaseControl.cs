using System.Windows.Forms;

namespace BotLauncher.Controls.Base
{
    public class BaseControl : UserControl
    {
        public BaseControl()
        {
            // Конструктор обязателен, даже если он пустой
        }

        public virtual void InitializePage()
        {
        }

        public virtual void LoadData()
        {
        }

        public virtual void SaveData()
        {
        }

        public virtual void RefreshData()
        {
        }

        protected virtual void OnPageOpened()
        {
        }

        protected virtual void OnPageClosed()
        {
        }
    }
}