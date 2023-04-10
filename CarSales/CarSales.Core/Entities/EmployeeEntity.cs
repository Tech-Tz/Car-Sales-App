using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Core.Entities
{
    public class EmployeeEntity : IEntity
    {
        public EmployeeEntity() { }

        public EmployeeEntity(string name, string userName, string passwordString)
        {
            Name = name;
            Username = userName;
            PasswordString = passwordString;
        }

        public int? Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string PasswordString { get; set; }

        public byte[] Password { get; set; }
    }
}
