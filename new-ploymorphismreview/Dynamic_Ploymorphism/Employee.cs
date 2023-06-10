using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Ploymorphism
{

    public class Employee

    {
        public Employee
       (int id, string fullName)

        {
            Id = id;
            this.fullName = fullName;
            salaries = new List<Salary>();

        }
        public int Id { get; set; }
        public string fullName { get; set; }
        public List<Salary> salaries { get; set; }

    }
}
