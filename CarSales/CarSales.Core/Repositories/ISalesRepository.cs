using CarSales.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Core.Repositories
{
    public interface ISalesRepository : IRepository<SalesEntity>
    {
        IEnumerable<SalesEntity> GetByCustomer(int customerId);
        IEnumerable<SalesEntity> GetByCustomerName(string customerName);
        SalesEntity GetByCar(int carId);
        IEnumerable<SalesEntity> GetByCarModel(string carModel);
        IEnumerable<SalesEntity> GetByEmployeeName(string employeeName);
        IEnumerable<SalesEntity> GetByEmployeeId(string employeeId);
        IEnumerable<SalesEntity> GetByPurchaseDate(DateTime purchaseDate);
    }
}
