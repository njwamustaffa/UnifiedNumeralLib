using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnifiedNumeral
{
    public partial class UnifiedNumeral
    {
        /// <summary>
        /// Addition Operation
        /// </summary>
        /// <param name="op1">parameter 1</param>
        /// <param name="op2">parameter 2</param>
        /// <returns></returns>
        public static UnifiedNumeral operator +(UnifiedNumeral op1, UnifiedNumeral op2)
        {
            UnifiedNumeral temp = new UnifiedNumeral();

            temp._value = op1._value + op2._value;  

            return temp;
        }

        /// <summary>
        /// Subtraction Operation
        /// </summary>
        /// <param name="op1">Parameter 1</param>
        /// <param name="op2">Parameter 2</param>
        /// <returns></returns>
        public static UnifiedNumeral operator -(UnifiedNumeral op1, UnifiedNumeral op2)
        {
            UnifiedNumeral temp = new UnifiedNumeral();

            temp._value = op1._value - op2._value;

            return temp;
        }

        /// <summary>
        /// Multiplication Operation
        /// </summary>
        /// <param name="op1">Parameter 1</param>
        /// <param name="op2">Parameter 2</param>
        /// <returns></returns>
        public static UnifiedNumeral operator *(UnifiedNumeral op1, UnifiedNumeral op2)
        {
            UnifiedNumeral temp = new UnifiedNumeral();

            temp._value = op1._value * op2._value;

            return temp;
        }

        /// <summary>
        /// Division Operation
        /// </summary>
        /// <param name="op1">Parameter 1</param>
        /// <param name="op2">Parameter 2</param>
        /// <returns></returns>
        public static UnifiedNumeral operator /(UnifiedNumeral op1, UnifiedNumeral op2)
        {
            UnifiedNumeral temp = new UnifiedNumeral();

            temp._value = op1._value / op2._value;

            return temp;
        }
    }
}
