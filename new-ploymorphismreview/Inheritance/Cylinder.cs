using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
 class Cylinder :Circle
    {
        public Cylinder(double Radius) : base(Radius)
        {
        }

        public double Height { get; set; }
        public double SurfaceArea()
        {
            return 2 * Math.PI * Radius * Height + 2 * Math.PI * Radius * Radius;
        }
        public double GetVolume()
        {
            return GetArea() * Height;
        }
    }
}
