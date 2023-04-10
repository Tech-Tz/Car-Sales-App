using CarSales.Core.Repositories;
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
    public class CustomerFormController : BaseController<ICustomerFormView, CustomerFormViewParam>
    {
        private ICustomerRepository customerRepository = RepositoryFactory.GetCustomerRepository();

        public CustomerFormController(ICustomerFormView view, 
            IViewActivator viewActivator, 
            IViewDeactivator viewDeactivator,
            CustomerFormViewParam customerFormViewParam) : base(view, viewActivator, viewDeactivator, customerFormViewParam)
        {
            View.OnViewShown = ShownHandler;
            View.OnCanceled = CanceledHandler;
            View.OnSubmitted = SubmittedHandler;
        }

        private void ShownHandler()
        {
            View.CustomerNameInput = ViewParameter.Name;
            View.CustomerEmailInput = ViewParameter.Email;
            View.CustomerPhoneInput = ViewParameter.Phonenumber;
        }

        private void CanceledHandler() => ViewDeactivator.Deactivate(this);

        private void SubmittedHandler()
        {
            if (!ValidateInputs())
                return;

            var customers = customerRepository.GetAll();

            if (customers.Any(c => c.Email == View.CustomerEmailInput && c.Id != ViewParameter.Id))
            {
                View.ShowMessage("A customer with the same email already exists!");
                return;
            }
            if (customers.Any(c => c.PhoneNumber == View.CustomerPhoneInput && c.Id != ViewParameter.Id))
            {
                View.ShowMessage("A customer with the same phone number already exists!");
                return;
            }

            var customerEntity = new Core.Entities.CustomerEntity(View.CustomerNameInput, View.CustomerEmailInput, View.CustomerPhoneInput);
            customerEntity.Id = ViewParameter.Id;

            customerRepository.Update(customerEntity);

            ViewDeactivator.Deactivate(this);
            ViewActivator.Activate<ICustomerListView, IViewParameter>();
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
