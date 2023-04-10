using CarSales.Core.Entities;
using CarSales.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.UI.Events
{
    public class EditCarClickedEvent
    {
        public CarModel Car { get; set; }
        public EditCarClickedEvent(CarModel car)
        {
            Car = car;
        }
    }
}
