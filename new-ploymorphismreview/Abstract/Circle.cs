using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Circle : Shape
    {
        public Circle()
        {
        }
        public Circle(int r)
        {
            R = r;
        }
        public int R { get; set; }
        public override double getArea()
        {
            return Math.PI * R * R;
        }
    }
}
