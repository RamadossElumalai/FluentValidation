using System;
using System.Collections.Generic;
using System.Linq;
namespace FluentValidationDemo.Models
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Date { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string MemberShip { get; set; }
    }
}
