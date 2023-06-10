using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception
{

    public class Test
    {
        public static int IsExist(int[] arr, int item)
        {
            int outpot = 0;
            foreach (var i in arr)
            {
                if (i == item)
                {
                    outpot = item;
                }
            }
            if (outpot != 0)
            {
                return outpot;
            }
            else
            {
                throw new System.Exception("Erorr");
            }
        }
    }
}
