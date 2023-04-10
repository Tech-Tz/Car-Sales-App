using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.MVC;

namespace CarSales.UI.ViewsParameter
{
    public class MainViewParam : SharedViewParam
    {
        public string EmployeeName { get; }

        public MainViewParam(string employeeName, int employeeId) : base(employeeId)
        {
            EmployeeName = employeeName;
        }
    }
}
