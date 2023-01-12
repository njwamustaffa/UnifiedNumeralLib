using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnifiedNumeral
{
    public partial class UnifiedNumeral
    {
        public static int roman_to_int(string NumStr)
        {
            var num = 0;
            for (int i = 0; i < NumStr.Length; i++)
            {
                if (i > 0 && find_value(NumStr[i]) > find_value(NumStr[i - 1]))
                {
                    num += find_value(NumStr[i]) - find_value(NumStr[i - 1]) * 2;
                }
                else
                {
                    num += find_value(NumStr[i]);
                }
            }

            return num;
        }

        public static int find_value(char ArbChr)
        {
            switch (ArbChr)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }
    }
}
