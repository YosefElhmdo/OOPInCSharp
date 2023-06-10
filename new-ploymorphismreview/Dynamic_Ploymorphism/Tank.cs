using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Ploymorphism
{

    public class Tank : Machine
    {
        public override void print()
        {
            Console.WriteLine("Tank Started");
        }
        public override void fire()
        {
            power -= 15;
        }
        public override void unHealth(int n)
        {
            health -= n;
        }
        public override void Move()
        {
            currentSpeed = 30;
        }
    }
}
