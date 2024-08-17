using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions_1._Example
{
    public static class AdditonalExtension 
    {
        public static bool IsBiggerThan(this int num1, int num2)
        {
            return num1 > num2;
        }
    }
}
