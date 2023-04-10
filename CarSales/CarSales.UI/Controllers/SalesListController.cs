using CarSales.Core.Repositories;
using CarSales.UI.Events;
using CarSales.UI.Models;
using CarSales.UI.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.MVC;

namespace CarSales.UI.Controllers
{
    public class SalesListController : BaseController<ISaleListView, IViewParameter>
    {
        private ISalesRepository salesRepository = RepositoryFactory.GetSalesRepository();
        private ICarRepository carRepository = RepositoryFactory.GetCarRepository();
        private ICustomerRepository customerRepository = RepositoryFactory.GetCustomerRepository();
        private IEmployeeRepository employeeRepository = RepositoryFactory.GetEmployeeRepository();

        private IEnumerable<SaleModel> cachedSales;

        public SalesListController(ISaleListView view, 
            IViewActivator viewActivator, 
            IViewDeactivator viewDeactivator) : base(view, viewActivator, viewDeactivator)
        {
            View.OnSearchedSales = SearchedSalesHandler;

            DisplaySales();
        }

        private IEnumerable<SaleModel> GetSales()
        {
            return from sale in salesRepository.GetAll()
                   join car in carRepository.GetAll()
                   on sale.CarId equals car.Id
                   join customer in customerRepository.GetAll()
                   on sale.CustomerId equals customer.Id
                   join employee in employeeRepository.GetAll()
                   on sale.EmployeeId equals employee.Id
                   select new SaleModel(
                       sale.Id.Value,
                       sale.CarId,
                       sale.CustomerId,
                       sale.EmployeeId,
                       car.Model,
                       customer.Name,
                       employee.Name,
                       sale.PurchaseDate,
                       car.VIN);
        }

        private void SearchedSalesHandler(SearchedSaleEvent searchSaleEvent)
        {
            if (string.IsNullOrWhiteSpace(searchSaleEvent.SearchText))
                View.Sales = cachedSales.ToList();
            else
            {
                View.Sales = cachedSales.Where(s =>
                {
                    return
                        s.VIN.ToLower().Contains(searchSaleEvent.SearchText.ToLower()) ||
                        s.EmployeeName.ToString().ToLower().Contains(searchSaleEvent.SearchText.ToLower()) ||
                        s.CarModel.ToString().ToLower().Contains(searchSaleEvent.SearchText.ToLower()) ||
                        s.PurchaseDate.ToString().ToLower().Contains(searchSaleEvent.SearchText.ToLower()) ||
                        s.CustomerName.ToString().ToLower().Contains(searchSaleEvent.SearchText.ToLower());
                }).ToList();
            }
        }

        private void DisplaySales()
        {
            cachedSales = GetSales();
            View.Sales = cachedSales.ToList();
        }

    }
}
