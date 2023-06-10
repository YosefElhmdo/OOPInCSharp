using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Circle
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
            Console.WriteLine(" Circle");
        }
        public double Radius { get; set; }
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
