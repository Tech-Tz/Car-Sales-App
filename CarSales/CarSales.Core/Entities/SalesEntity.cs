using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Core.Entities
{
    public class SalesEntity : IEntity
    {
        public int? Id { get; set;  }

        public int CustomerId { get; }

        public int CarId { get; }

        public int EmployeeId { get; }

        public DateTime PurchaseDate { get; }

        public SalesEntity() { }

        public SalesEntity(int customerId, int carId, int employeeId)
        {
            CustomerId = customerId;
            CarId = carId;
            PurchaseDate = DateTime.Now;
            EmployeeId = employeeId;
        }
    }
}
