using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Ploymorphism
{

    public class Machine
    {
        public virtual void print()
        {
            Console.WriteLine("Machine Started");
        }
        public int power { get; set; }
        public int health { get; set; }
        public int maxspeed { get; set; }
        public int currentSpeed { get; set; }
        public virtual void fire()
        {
            power -= 1;
        }
        public virtual void unHealth(int n)
        {
            health -= n;
        }
        public virtual void Move()
        {
            currentSpeed = 5;
        }
    }
}
