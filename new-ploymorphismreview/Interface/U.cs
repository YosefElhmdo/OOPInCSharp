using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    public class U : U1, U2
    {
        public void print()
        {
            Console.WriteLine("U");
        }
        void U1.print()
        {
            Console.WriteLine("U1");
        }
        void U2.print()
        {
            Console.WriteLine("U2");
        }
    }
}
