using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.MVC;

namespace CarSales.UI.Views
{
    public abstract class BaseView : Form, IView
    {
        public bool IsDeactivated { get; set; }

        public IViewParameter ViewParameter { get; set; }

        public Action OnViewShown { get; set; }

        public Action OnViewClosed { get; set; }
        
        public void CloseView() => this.Close();

        public void OpenView() => new Thread((ThreadStart)delegate { Application.Run(this); }).Start();

        public void OpenViewModal() => this.ShowDialog();

        public void ShowMessage(string message) => MessageBox.Show(message);

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            OnViewShown?.Invoke();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            OnViewClosed?.Invoke();
        }
    }
}
