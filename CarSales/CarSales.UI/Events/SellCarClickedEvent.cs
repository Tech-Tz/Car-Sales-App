using CarSales.Core.Entities;
using CarSales.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.UI.Events
{
    public class SellCarClickedEvent
    {
        public int CarId { get; set; }
        public string VIN { get; set; }

        public SellCarClickedEvent(int carId, string VIN)
        {
            CarId = carId;
            this.VIN = VIN;
        }
    }
}
