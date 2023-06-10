using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Ploymorphism
{
    public class BkcFighter : Fighter
    {
        public override void fire()
        {
            power -= 1000;
        }
    }
    public enum bump
    {
        Tank,
        Bkc,
    }
}
