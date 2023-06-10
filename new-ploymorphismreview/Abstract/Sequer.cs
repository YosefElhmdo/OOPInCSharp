using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Sequer : Rectangle
    {
        public Sequer(int width)
        {
            this.width = width;
        }
        public int width { get; set; }
        public override double getArea()
        {
            return width * width;
        }
    }
}
