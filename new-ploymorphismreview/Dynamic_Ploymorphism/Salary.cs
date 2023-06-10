using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Ploymorphism
{
    public class Salary
    {
        public int Id { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public int value { get; set; }
        public bool isToken { get; set; }
        public Employee employee { get; set; }

    }

}
