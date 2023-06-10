using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Ploymorphism
{

    public class Plain : Machine

    {
        public override void print()

        {
            Console.WriteLine("Plain Started");

        }
        public override void fire()

        {
            power
           -= 1;

        }
        public override void Move()

        {
            currentSpeed = 370;

        }
        public override void unHealth(int n)

        {
            health
           -= n;

        }

    }
}
