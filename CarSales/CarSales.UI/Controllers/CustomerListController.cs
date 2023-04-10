using CarSales.Core.Repositories;
using CarSales.UI.Events;
using CarSales.UI.Models;
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
    public class CustomerListController : BaseController<ICustomerListView, IViewParameter>
    {
        private ICustomerRepository customerRepository = RepositoryFactory.GetCustomerRepository();
        private IEnumerable<CustomerModel> cachedCustomers;

        public CustomerListController(ICustomerListView view, 
            IViewActivator viewActivator, 
            IViewDeactivator viewDeactivator) : base(view, viewActivator, viewDeactivator)
        {
            View.OnSearchedCustomers = SearchedCustomersHandler;
            View.OnEditCustomerClicked = EditCustomerClickedHandler;

            DisplayCustomers();
        }

        private IEnumerable<CustomerModel> GetCustomers()
        {
            return customerRepository
                .GetAll()
                .Select(c => new CustomerModel(c.Id.Value, c.Name, c.Email, c.PhoneNumber));
        }

        private void DisplayCustomers()
        {
            cachedCustomers = GetCustomers();
            View.Customers = cachedCustomers.ToList();
        }
       
        private void SearchedCustomersHandler(SearchedCustomerEvent searchedCustomerEvent)
        {
            if (string.IsNullOrWhiteSpace(searchedCustomerEvent.SearchText))
                View.Customers = GetCustomers().ToList();
            else
            {
                View.Customers = cachedCustomers.Where(c =>
                {
                    return
                        c.Name.ToLower().Contains(searchedCustomerEvent.SearchText.ToLower()) ||
                        c.Email.ToString().ToLower().Contains(searchedCustomerEvent.SearchText.ToLower()) ||
                        c.Phonenumber.ToString().ToLower().Contains(searchedCustomerEvent.SearchText.ToLower());
                }).ToList();
            }
        }

        private void EditCustomerClickedHandler(EditCustomerClickedEvent editCustomerClickedEvent)
        {
            ViewActivator.ActivateModal<ICustomerFormView, CustomerFormViewParam>(new CustomerFormViewParam() 
            {
                Id = editCustomerClickedEvent.Customer.Id,
                Name = editCustomerClickedEvent.Customer.Name,
                Email = editCustomerClickedEvent.Customer.Email,
                Phonenumber = editCustomerClickedEvent.Customer.Phonenumber
            });
        }
    }
}
