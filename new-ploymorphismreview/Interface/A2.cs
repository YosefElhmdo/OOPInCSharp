using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public abstract class A2 : A1
    {
        public abstract void print2();
        public void print3()
        {
            Console.WriteLine("abstract class A2");
        }
    }
}
