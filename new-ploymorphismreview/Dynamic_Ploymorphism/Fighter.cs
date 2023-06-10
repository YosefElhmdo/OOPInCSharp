using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Ploymorphism
{
    public class Fighter : Machine
    {
        public override void print()
        {
            Console.WriteLine("Fighter Started");
        }
        public override void unHealth(int n)
        {
            health = 0;
        }
    }
}
