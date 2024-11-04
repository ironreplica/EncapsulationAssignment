using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAssignment
{
    public class DoSomeRandomMath()
    {
        public float doRandomMath(float x)
        {
            Random random = new Random();
            float product = multipliedNum(x);
            float sum = addNum(product);

            float multipliedNum(float y)
            {
                return y * random.Next(1, 100);
            }
            float addNum(float y)
            {
                return y + random.Next(100, 1000);
            }
            return sum;
        }
        
    }
}
