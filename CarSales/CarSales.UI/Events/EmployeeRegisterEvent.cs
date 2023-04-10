using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.UI.Events
{
    public class EmployeeRegisterEvent : EmployeeCredentialInputEvent
    {
        public string Name { get; set; }
        public EmployeeRegisterEvent(string usernameInput, string passwordInput, string name) : base(usernameInput, passwordInput)
        {
            Name = name;
        }
    }
}
