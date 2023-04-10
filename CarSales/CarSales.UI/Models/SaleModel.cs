using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.UI.Models
{
    public class SaleModel
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public int CustomerId { get; set; }

        public int EmployeeId { get; set; }

        public string CarModel { get; set; }

        public string CustomerName { get; set; }

        public string EmployeeName { get; set; }

        public DateTime PurchaseDate { get; set; }

        public string VIN { get; set; }

        public SaleModel(int id, int carId, int customerId, int employeeId, string carModel, string customerName, string employeeName, DateTime purchaseDate, string vIN)
        {
            Id = id;
            CarId = carId;
            CustomerId = customerId;
            EmployeeId = employeeId;
            CarModel = carModel;
            CustomerName = customerName;
            EmployeeName = employeeName;
            PurchaseDate = purchaseDate;
            VIN = vIN;
        }
    }
}
