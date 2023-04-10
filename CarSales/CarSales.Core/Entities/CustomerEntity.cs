using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Core.Entities
{
    public class CustomerEntity : IEntity
    {
        public int? Id { get; set; }

        public string Name { get; }

        public string Email { get; }

        public string PhoneNumber { get; }

        public CustomerEntity() { }

        public CustomerEntity(string name, string email, string phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
