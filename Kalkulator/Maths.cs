using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class Maths
    {
        public float plus(string i1, string i2)
        {
            float f1, f2;
            if (Single.TryParse(i1, out f1) && Single.TryParse(i2, out f2))
            {
                float result = f1 + f2;
                return result;
            }
            return 0;
           
        }
        public float minus(string i1, string i2)
        {
            float f1, f2;
            if (Single.TryParse(i1, out f1) && Single.TryParse(i2, out f2))
            {
                float result = f1 - f2;
                return result;
            }
            return 0;
        }
        public float multi(string i1, string i2)
        {
            float f1, f2;
            if (Single.TryParse(i1, out f1) && Single.TryParse(i2, out f2))
            {
                float result = f1 * f2;
                return result;
            }
            return 0;
        }
        public float div(string i1, string i2)
        {
            float f1, f2;
            if (Single.TryParse(i1, out f1) && Single.TryParse(i2, out f2))
            {
                float result = f1 / f2;
                return result;
            }
            return 0;
        }
    }
}
