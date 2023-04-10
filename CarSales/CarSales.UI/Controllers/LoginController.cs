using CarSales.Core.Entities;
using CarSales.Core.Repositories;
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
    public class LoginController : BaseController<ILoginView, IViewParameter>
    {
        private readonly IEmployeeRepository employeeRepository = RepositoryFactory.GetEmployeeRepository();

        public LoginController(ILoginView loginView, 
            IViewActivator viewNavigator,
            IViewDeactivator viewDeactivator) : base(loginView, viewNavigator, viewDeactivator)
        {
            View.OnLogin = LoginHandler;
            View.OnRegister = RegisterHandler;
        }

        private void LoginHandler(EmployeeCredentialInputEvent employeeLoginEvent) 
        {
            MainViewParam mainViewParam;

            var userNameValid = employeeRepository.UsernameExists(employeeLoginEvent.UsernameInput);

            if (!userNameValid)
            {
                View.ShowMessage("Username invalid!");
                return;
            }

            var employee = employeeRepository.GetByCredentials(employeeLoginEvent.UsernameInput, employeeLoginEvent.PasswordInput);
            if (employee == null)
            {
                View.ShowMessage("Password invalid!");
                return;
            }

            mainViewParam = new MainViewParam(employee.Name, employee.Id.Value);
            NavigateToMainView(mainViewParam);
        }

        private void RegisterHandler(EmployeeRegisterEvent employeeRegisterEvent)
        {
            bool inputsValid = ValidateInputs(employeeRegisterEvent.UsernameInput, employeeRegisterEvent.PasswordInput, employeeRegisterEvent.Name);

            if (!inputsValid)
                return;

            if (employeeRepository.GetByName(employeeRegisterEvent.Name) != null)
            {
                View.ShowMessage("User already exists!");
                return;
            }

            if (employeeRepository.UsernameExists(employeeRegisterEvent.UsernameInput))
            {
                View.ShowMessage("Username already exists!");
                return;
            }

            var employeeEntity = new EmployeeEntity(employeeRegisterEvent.Name, employeeRegisterEvent.UsernameInput, employeeRegisterEvent.PasswordInput);
            int employeeId = employeeRepository.Add(employeeEntity);

            MainViewParam mainViewParam = new MainViewParam(employeeEntity.Name, employeeId);
            NavigateToMainView(mainViewParam);
        }

        private bool ValidateInputs(string username, string password, string name)
        {
            if (string.IsNullOrEmpty(username) || username.Length > 100)
            {
                View.ShowMessage("Username invalid!");
                return false;
            }
            else if (string.IsNullOrEmpty(password) || password.Length > 100)
            {
                View.ShowMessage("Password invalid!");
                return false;
            }
            else if (string.IsNullOrEmpty(name) || name.Length > 100)
            {
                View.ShowMessage("Name invalid!");
                return false;
            }
            else return true;
        }

        private void NavigateToMainView(IViewParameter viewParam)
        {
            ViewDeactivator.Deactivate(this);
            ViewActivator.Activate<IMainView, IViewParameter>(viewParam);
        }
    }
}
