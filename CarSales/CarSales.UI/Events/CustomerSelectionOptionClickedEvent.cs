using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.UI.Events
{
    public class CustomerSelectionOptionClickedEvent
    {
        public bool SelectExitingCustomer { get; set; }

        public CustomerSelectionOptionClickedEvent(bool selectExitingCustomer)
        {
            SelectExitingCustomer = selectExitingCustomer;  
        }
    }
}
