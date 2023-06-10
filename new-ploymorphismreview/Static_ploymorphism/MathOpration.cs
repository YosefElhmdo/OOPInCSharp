using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_ploymorphism
{
    public class MathOpration
    {
        public int Min(int x, int y)
        {
            return Math.Min(x, y);
        }
        public int Min(int x, int y, int z)
        {
            int min = x;
            if (min > y)
            {
                min = y;
            }
            else if (min > z)
            {
                min = z;
            }
            return min;
        }
        public double Min(double x, double y)
        {
            return Math.Min(x, y);
        }
        public int Min(int[] arr)
        {
            int min = arr[0];
            foreach (var item in arr)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
    }
}
