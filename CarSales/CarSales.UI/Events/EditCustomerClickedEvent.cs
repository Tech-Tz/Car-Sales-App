using CarSales.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.UI.Events
{
    public class EditCustomerClickedEvent
    {
        public CustomerModel Customer { get; set; }
        public EditCustomerClickedEvent(CustomerModel customer)
        {
            Customer = customer;
        }
    }
}
