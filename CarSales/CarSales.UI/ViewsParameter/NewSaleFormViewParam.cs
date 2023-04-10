using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.MVC;

namespace CarSales.UI.ViewsParameter
{
    public class NewSaleFormViewParam : SharedViewParam
    {
        public int CarId { get; set; }
        public string VIN { get; set; }

        public NewSaleFormViewParam(int carId, string vIN, int employeeId) : base(employeeId)
        {
            CarId = carId;
            VIN = vIN;
        }
    }
}
