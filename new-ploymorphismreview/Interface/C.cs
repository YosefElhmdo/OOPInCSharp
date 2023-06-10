using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    public class C : I1, I2
    {
        public void print()
        {
            Console.WriteLine("Welcome interface print");
        }
        public void print1()
        {
            Console.WriteLine("Welcome interface print1");
        }
        public void print2()
        {
            Console.WriteLine("Welcome interface print2");
        }
        public void print3()
        {
            Console.WriteLine("Welcome interface print3");
        }
    }
}
