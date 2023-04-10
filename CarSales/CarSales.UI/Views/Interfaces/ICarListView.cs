using CarSales.Core.Entities;
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
    public interface ICarListView : IView
    {
        IEnumerable<CarModel> Cars { set; }

        Action OnAddNewCarClicked { get; set; }
        Action<SearchedCarEvent> OnSearchedCars { get; set; }
        Action<EditCarClickedEvent> OnEditCarClicked { get; set; }
        Action<DeleteCarClickedEvent> OnDeleteCarClicked { get; set; }
        Action<SellCarClickedEvent> OnSellCarClicked { get; set; }
    }
}
