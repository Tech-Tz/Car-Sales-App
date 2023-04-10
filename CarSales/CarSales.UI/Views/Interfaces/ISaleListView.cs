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
    public interface ISaleListView : IView
    {
        IEnumerable<SaleModel> Sales { set; }

        Action<SearchedSaleEvent> OnSearchedSales { get; set; }
    }
}
