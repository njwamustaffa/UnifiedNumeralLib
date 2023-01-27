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
        /// convert numeral to arabic
        /// </summary>
        /// <returns></returns>
        public string ToArabic()
        {

            string ArbStr = "";
            string DecStr = _value.ToString();
            for (int c = 0; c < DecStr.Length; c++)
            {
                if (DecStr[c] == '0')
                {
                    ArbStr = ArbStr + "۰";
                }
                else if (DecStr[c] == '1')
                {
                    ArbStr = ArbStr + "۱";
                }
                else if (DecStr[c] == '2')
                {
                    ArbStr = ArbStr + "۲";
                }
                else if (DecStr[c] == '3')
                {
                    ArbStr = ArbStr + "۳";
                }
                else if (DecStr[c] == '4')
                {
                    ArbStr = ArbStr + "٤";
                }
                else if (DecStr[c] == '5')
                {
                    ArbStr = ArbStr + "۵";
                }
                else if (DecStr[c] == '6')
                {
                    ArbStr = ArbStr + "٦";
                }
                else if (DecStr[c] == '7')
                {
                    ArbStr = ArbStr + "٧";
                }
                else if (DecStr[c] == '8')
                {
                    ArbStr = ArbStr + "٨";
                }
                else if (DecStr[c] == '9')
                {
                    ArbStr = ArbStr + "٩";
                }
            }
            return ArbStr;
        }

        /// <summary>
        /// convert arabic to numeral
        /// </summary>
        /// <param name="ArbStr">Arabic character in string</param>
        public void FromArabic(string ArbStr)
        {

            string DecStr = "";

            for (int c = 0; c < ArbStr.Length; c++)
            {
                if (ArbStr[c] == '۰')
                {
                    DecStr = DecStr + "0";
                }
                else if (ArbStr[c] == '۱')
                {
                    DecStr = DecStr + "1";
                }
                else if (ArbStr[c] == '۲')
                {
                    DecStr = DecStr + "2";
                }
                else if (ArbStr[c] == '۳')
                {
                    DecStr = DecStr + "3";
                }
                else if (ArbStr[c] == '٤')
                {
                    DecStr = DecStr + "4";
                }
                else if (ArbStr[c] == '۵')
                {
                    DecStr = DecStr + "5";
                }
                else if (ArbStr[c] == '٦')
                {
                    DecStr = DecStr + "6";
                }
                else if (ArbStr[c] == '٧')
                {
                    DecStr = DecStr + "7";
                }
                else if (ArbStr[c] == '٨')
                {
                    DecStr = DecStr + "8";
                }
                else if (ArbStr[c] == '٩')
                {
                    DecStr = DecStr + "9";
                }

            }
            _value = Convert.ToInt32(DecStr);
        }
    }
}
