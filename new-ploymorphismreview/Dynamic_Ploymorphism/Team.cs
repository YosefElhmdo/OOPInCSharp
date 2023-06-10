using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Ploymorphism
{
    public class Team
    {
        public List<Fighter> fighters { get; set; }
        public List<BkcFighter> bkcFighters { get; set; }
        public List<Tank> tanks { get; set; }
        public List<Plain> plains { get; set; }
    }
}
