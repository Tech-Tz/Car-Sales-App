using CarSales.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.UI.Events
{
    public class CustomerSelectedEvent
    {
        public CustomerModel CustomerModel { get; set; }

        public CustomerSelectedEvent(CustomerModel customerModel)
        {
            CustomerModel = customerModel;
        }
    }
}
