using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_ploymorphism
{
    class B : A
    {
        public override void printData()
        {
            Console.WriteLine("method class B");
        }
    }
}
