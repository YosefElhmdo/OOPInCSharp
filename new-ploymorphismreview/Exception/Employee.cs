using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    public class Employee
    {
        private int Id;
        public Employee(int id)
        {
            Id = id;
        }
        public void printData()
        {
            Console.WriteLine($"{Id}");
        }
        public int id
        {
            get { return Id; }
            set
            {
                if (value > 0)
                {
                    Id = value;
                }
                else
                {
                    throw new System.Exception("Erorr");
                }
            }
        }
    }
}
