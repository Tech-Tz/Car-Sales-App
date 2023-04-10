using CarSales.UI.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.MVC;

namespace CarSales.UI.Views.Interfaces
{
    public interface ILoginView : IView
    {
        Action<EmployeeCredentialInputEvent> OnLogin { get; set; }
        Action<EmployeeRegisterEvent> OnRegister { get; set; }
    }
}
