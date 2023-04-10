using CarSales.UI.Events;
using CarSales.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.MVC;

namespace CarSales.UI.Views.Interfaces
{
    public interface INewSaleFormView : IView
    {
        public string VIN { set; }

        public IEnumerable<CustomerModel> Customers { set; }

        public string CustomerNameInput { get; set; }
        public string CustomerEmailInput { get; set; }
        public string CustomerPhoneInput { get; set; }

        public bool EnableCustomerNameInput { set; }
        public bool EnableCustomerEmailInput { set; }
        public bool EnableCustomerPhoneInput { set; }

        public bool EnableCustomerDropdown { set; }

        public int DropdownSelectedCustomerId { set; }

        public bool NewCustomer { get; }

        Action<CustomerSelectionOptionClickedEvent> OnCustomerSelectionOptionClicked { get; set; }
        Action<CustomerSelectedEvent> OnCustomerSelected { get; set; }
        Action OnValidateSaleClicked { get; set; }
        Action OnCancelSaleClicked { get; set; }
    }
}
