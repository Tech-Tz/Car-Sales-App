using CarSales.UI.Enums;
using CarSales.UI.Events;
using CarSales.UI.Views.Interfaces;
using CarSales.UI.ViewsParameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.MVC;

namespace CarSales.UI.Controllers
{
    public class MainController : BaseController<IMainView, MainViewParam>
    {
        public MainController(IMainView mainView, 
            IViewActivator viewNavigator,
            IViewDeactivator viewDeactivator,
            MainViewParam mainViewParam) : base(mainView, viewNavigator, viewDeactivator, mainViewParam)
        {
            View.OnTabChanged = TabChangedHandler;
            View.OnViewShown = ViewShownHandler;
        }

        private void TabChangedHandler(TabChangedEvent tabChangedEvent)
        {
            switch (tabChangedEvent.Tab)
            {
                case MainViewTab.Cars:
                    ViewActivator.Activate<ICarListView, CarListViewParam>(new CarListViewParam(ViewParameter.EmployeeId));
                    break;
                case MainViewTab.Customers:
                    ViewActivator.Activate<ICustomerListView, IViewParameter>();
                    break;
                case MainViewTab.Report:
                    ViewActivator.Activate<ISaleListView, IViewParameter>();
                    break;
            }
        }

        private void ViewShownHandler()
        {
            View.EmployeeLoggedinText = $"{ViewParameter.EmployeeName} logged in";

            // Show Car list view by default:

            // View.DefaultTab = MainViewTab.Cars; // Ideally setting the default up should activate the ICarListView

            // Activate manually since there is potential bug in winforms when setting the default tab
            ViewActivator.Activate<ICarListView, CarListViewParam>(new CarListViewParam(ViewParameter.EmployeeId));
        }
    }
}
