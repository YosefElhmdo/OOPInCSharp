using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_ploymorphismreview
{

    public class D : A
    {
        public new void print()
        {
            Console.WriteLine("welcom class D");
        }
    }
}
