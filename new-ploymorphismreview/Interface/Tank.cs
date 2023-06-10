using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    public class Tank : Machine, IMovable, IFireble
    {
        public void fire()
        {
            Console.WriteLine("firing");
        }
        public void move()
        {
            Console.WriteLine("moving");
        }
        public override void print()
        {
            Console.WriteLine("print of Machine absrtact class");
        }
    }

}
