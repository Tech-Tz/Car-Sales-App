using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.UI.Events
{
    public class SearchedSaleEvent
    {
        public string SearchText { get; }

        public SearchedSaleEvent(string searchText) => SearchText = searchText;
    }
}
