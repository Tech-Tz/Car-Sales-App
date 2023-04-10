using CarSales.Core;
using CarSales.Core.Repositories;
using CarSales.UI.Events;
using CarSales.UI.Models;
using CarSales.UI.Validators;
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
    public class NewSaleFormController : BaseController<INewSaleFormView, NewSaleFormViewParam>
    {
        private ICustomerRepository customerRepository = RepositoryFactory.GetCustomerRepository();
        private ISalesRepository salesRepository = RepositoryFactory.GetSalesRepository();
        private IUnitOfWork unitOfWork = RepositoryFactory.GetUnitOfWork();

        private IEnumerable<CustomerModel> cachedCustomers;

        private bool ViewShownHandled;

        private CustomerModel customerSelected;

        public NewSaleFormController(INewSaleFormView view, 
            IViewActivator viewActivator, 
            IViewDeactivator viewDeactivator,
            NewSaleFormViewParam viewParam) : base(view, viewActivator, viewDeactivator, viewParam)
        {
            View.OnCustomerSelectionOptionClicked = CustomerSelectionOptionClickedHandler;
            View.OnCustomerSelected = CustomerSelectedHandler;
            View.OnValidateSaleClicked = ValidateSaleClickedHandler;
            View.OnCancelSaleClicked = CancelSaleClickedHandler;
            View.OnViewShown = ViewShownHandler;
            View.EnableCustomerDropdown = false;
        }

        private void ViewShownHandler()
        {
            cachedCustomers = customerRepository
                .GetAll()
                .Select(c => new CustomerModel(c.Id.Value, c.Name, c.Email, c.PhoneNumber));
            View.VIN = ViewParameter.VIN;
            View.Customers = cachedCustomers.ToList();
            View.DropdownSelectedCustomerId = 0; // By default, no option should be selected
            ViewShownHandled = true;
        }

        private void CustomerSelectionOptionClickedHandler(CustomerSelectionOptionClickedEvent customerSelectionOptionClickedEvent)
        {
            View.EnableCustomerEmailInput = !customerSelectionOptionClickedEvent.SelectExitingCustomer;
            View.EnableCustomerNameInput = !customerSelectionOptionClickedEvent.SelectExitingCustomer;
            View.EnableCustomerPhoneInput = !customerSelectionOptionClickedEvent.SelectExitingCustomer;

            View.EnableCustomerDropdown = customerSelectionOptionClickedEvent.SelectExitingCustomer;

            View.CustomerNameInput = null;
            View.CustomerEmailInput = null;
            View.CustomerPhoneInput = null;

            View.DropdownSelectedCustomerId = 0;
        }

        private void CustomerSelectedHandler(CustomerSelectedEvent customerSelectedEvent)
        {
            if (!ViewShownHandled)
                return;
            View.CustomerNameInput = customerSelectedEvent.CustomerModel.Name;
            View.CustomerEmailInput = customerSelectedEvent.CustomerModel.Email;
            View.CustomerPhoneInput = customerSelectedEvent.CustomerModel.Phonenumber;
            customerSelected = customerSelectedEvent.CustomerModel;
        }

        private void ValidateSaleClickedHandler()
        {
            if (View.NewCustomer && !ValidateInputs())
                return;

            unitOfWork.Execute(() => 
            {
                int customerId;

                if (View.NewCustomer)
                {
                    if (cachedCustomers.Any(c => c.Email == View.CustomerEmailInput))
                    {
                        View.ShowMessage("A customer with the same email already exists!");
                        return;
                    }
                    if (cachedCustomers.Any(c => c.Phonenumber == View.CustomerPhoneInput))
                    {
                        View.ShowMessage("A customer with the same phone number already exists!");
                        return;
                    }
                    customerId = customerRepository.Add(new Core.Entities.CustomerEntity(View.CustomerNameInput, View.CustomerEmailInput, View.CustomerPhoneInput));
                }
                else
                {
                    customerId = customerSelected.Id;
                }
                salesRepository.Add(new Core.Entities.SalesEntity(customerId, ViewParameter.CarId, ViewParameter.EmployeeId));
            });

            ViewDeactivator.Deactivate(this);
            ViewActivator.Activate<ICarListView, CarListViewParam>(new CarListViewParam(ViewParameter.EmployeeId));
        }

        private void CancelSaleClickedHandler()
        {
            ViewDeactivator.Deactivate(this);
        }

        private bool ValidateInputs()
        {
            if (!CustomerValidator.IsNameValid(View.CustomerNameInput))
            {
                View.ShowMessage(CustomerValidator.NameInvalid);
                return false;
            }
            else if (!CustomerValidator.IsEmailValid(View.CustomerEmailInput))
            {
                View.ShowMessage(CustomerValidator.EmailInvalid);
                return false;
            }
            else if (!CustomerValidator.IsPhonenumberValid(View.CustomerPhoneInput))
            {
                View.ShowMessage(CustomerValidator.PhonenumberInvalid);
                return false;
            }
            else return true;
        }
    }
}
