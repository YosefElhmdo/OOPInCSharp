using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespace_Indexer
{
    public class Employee
    {
        public Employee(int id, string name, int baseSalary)
        {
            Id = id;
            Name = name;
            this.baseSalary = baseSalary;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int baseSalary { get; set; }
        public Department department { get; set; }
        public void printData()
        {
            Console.WriteLine($"{Id},{Name},{baseSalary}");
        }
    }
}
