using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnifiedNumeral
{
    public partial class UnifiedNumeral
    {
        public static UnifiedNumeral operator +(UnifiedNumeral op1, UnifiedNumeral op2)
        {
            UnifiedNumeral temp = new UnifiedNumeral();

            temp._value = op1._value + op2._value;  

            return temp;
        }

        public static UnifiedNumeral operator -(UnifiedNumeral op1, UnifiedNumeral op2)
        {
            UnifiedNumeral temp = new UnifiedNumeral();

            temp._value = op1._value - op2._value;

            return temp;
        }

        public static UnifiedNumeral operator *(UnifiedNumeral op1, UnifiedNumeral op2)
        {
            UnifiedNumeral temp = new UnifiedNumeral();

            temp._value = op1._value * op2._value;

            return temp;
        }

        public static UnifiedNumeral operator /(UnifiedNumeral op1, UnifiedNumeral op2)
        {
            UnifiedNumeral temp = new UnifiedNumeral();

            temp._value = op1._value / op2._value;

            return temp;
        }
    }
}
