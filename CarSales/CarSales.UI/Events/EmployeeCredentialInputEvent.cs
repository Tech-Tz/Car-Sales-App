using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.UI.Events
{
    public class EmployeeCredentialInputEvent
    {
        public string UsernameInput { get; set; }
        public string PasswordInput { get; set; } 
        public EmployeeCredentialInputEvent(string usernameInput, string passwordInput)
        {
            UsernameInput = usernameInput;
            PasswordInput = passwordInput;
        }
    }
}
