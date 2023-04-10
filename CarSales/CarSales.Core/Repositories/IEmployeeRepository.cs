using CarSales.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Core.Repositories
{
    public interface IEmployeeRepository : IRepository<EmployeeEntity>
    {
        bool UsernameExists(string userName);

        EmployeeEntity GetByCredentials(string userName, string password);

        EmployeeEntity GetByName(string name);
    }
}
