using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{


    public class Rectangle : Shape
    {
        public Rectangle()
        {
        }
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public int width { get; set; }
        public int height { get; set; }
        public override double getArea()
        {
            return width * height;
        }
    }
}
