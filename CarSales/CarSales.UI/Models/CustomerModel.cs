using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.UI.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }

        public CustomerModel(int id, string name, string email, string phonenumber)
        {
            Id = id;
            Name = name;
            Email = email;
            Phonenumber = phonenumber;
        }
    }
}
