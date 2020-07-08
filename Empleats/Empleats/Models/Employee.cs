using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empleats.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }       
        public string Surname { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
    }
}
