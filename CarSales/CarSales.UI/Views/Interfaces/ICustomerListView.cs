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
    public interface ICustomerListView : IView
    {
        IEnumerable<CustomerModel> Customers { set; }

        Action<SearchedCustomerEvent> OnSearchedCustomers { get; set; }
        Action<EditCustomerClickedEvent> OnEditCustomerClicked { get; set; }
    }
}
