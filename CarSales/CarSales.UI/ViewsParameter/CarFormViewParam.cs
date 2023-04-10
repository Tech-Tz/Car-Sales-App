using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.MVC;

namespace CarSales.UI.ViewsParameter
{
    public class CarFormViewParam : SharedViewParam
    {
        public bool IsNewCar { get; set; }
        public string Manufacturer { get; set; }
        public int ManufacturedYear { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public decimal? DistanceCovered { get; set; }
        public string ImagePath { get; set; }
        public string VIN { get; set; }
        public int? Id { get; set; }

        public CarFormViewParam(bool isNewCar, int employeeId) : base(employeeId) => IsNewCar = isNewCar;
    }
}
