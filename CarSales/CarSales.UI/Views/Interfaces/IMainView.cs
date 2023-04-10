using CarSales.UI.Enums;
using CarSales.UI.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.MVC;

namespace CarSales.UI.Views.Interfaces
{
    public interface IMainView : IView
    {
        MainViewTab DefaultTab { set; }
        string EmployeeLoggedinText { set; }

        Action<TabChangedEvent> OnTabChanged { get; set; }

    }
}
