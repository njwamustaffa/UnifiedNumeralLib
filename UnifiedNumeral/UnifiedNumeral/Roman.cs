using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnifiedNumeral
{
    public partial class UnifiedNumeral
    {
        public void FromRoman(string NumStr)
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
            _value = Convert.ToInt32(num);
            
        }

        private int find_value(char RomanChr)
        {
            switch (RomanChr)
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

        public string ToRoman()
        {
            int DecStr = _value;
            string RomanStr = string.Empty;
            string[] romanLetters = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] numbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            int i = 0;
            while (DecStr != 0)
            {
                if (DecStr >= numbers[i])
                {
                    DecStr -= numbers[i];
                    RomanStr += romanLetters[i];
                }
                else
                {
                    i++;
                }
            }
            return RomanStr;
        }
    }
}
