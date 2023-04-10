using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.UI.Events
{
    public class SearchedCustomerEvent
    {
        public string SearchText { get; }

        public SearchedCustomerEvent(string searchText) => SearchText = searchText;
    }
}
