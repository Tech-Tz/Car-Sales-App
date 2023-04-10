using CarSales.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Core.Repositories
{
    public interface ICustomerRepository : IRepository<CustomerEntity>
    {
        IEnumerable<CustomerEntity> GetByName(string name); // Two customers can have the same name
        CustomerEntity GetByEmail(string email);
        CustomerEntity GetByPhoneNumber(string phoneNumber);
    }
}
