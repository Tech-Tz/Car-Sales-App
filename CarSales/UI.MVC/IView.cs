using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.MVC
{
    public interface IView
    {
        bool IsDeactivated { get; set; }

        Action OnViewShown { get; set; }

        Action OnViewClosed { get; set; }

        void OpenView();

        void OpenViewModal();

        void CloseView();

        void ShowMessage(string message);
    }
}
