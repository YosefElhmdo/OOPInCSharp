using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_ploymorphismreview
{
    public class A
    {
        public int max(int x, int y)
        {
            return (x > y) ? x : y;
        }
        public virtual void print()
        {
            Console.WriteLine("welcom class A");
        }
    }
}
