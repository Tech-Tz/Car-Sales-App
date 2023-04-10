using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.UI.Events
{
    public class SearchedCarEvent
    {
        public string SearchText { get; }

        public SearchedCarEvent(string searchText) => SearchText = searchText;
    }
}
