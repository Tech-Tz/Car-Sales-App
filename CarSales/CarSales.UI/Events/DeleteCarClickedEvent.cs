using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.UI.Events
{
    public class DeleteCarClickedEvent
    {
        public int CarId { get; set; }
        public DeleteCarClickedEvent(int carId)
        {
            CarId = carId;
        }
    }
}
