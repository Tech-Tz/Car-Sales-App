using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.MVC;

namespace CarSales.UI.Views.Interfaces
{
    public interface ICustomerFormView : IView
    {
        public string CustomerNameInput { get; set; }
        public string CustomerEmailInput { get; set; }
        public string CustomerPhoneInput { get; set; }

        Action OnSubmitted { get; set; }
        Action OnCanceled { get; set; }
    }
}
