using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlib
{
    public class Employee
    {

        public static List<Employee> list = new List<Employee>()
 {
 new Employee("khaled",400),
 new Employee("khaled",400),
 new Employee("khaled",400),
 new Employee("khaled",400),

 new Employee("khaled",400),
 };
        public Employee(string name, int baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }
        public string Name { get; set; }
        public int BaseSalary { get; set; }
        public Employee()
        {
        }
    }
}
