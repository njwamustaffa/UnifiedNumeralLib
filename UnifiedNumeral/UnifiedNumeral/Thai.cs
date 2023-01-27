using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnifiedNumeral
{
    /// <summary>
    /// partial class for unified number
    /// </summary>
    public partial class UnifiedNumeral
    {
        /// <summary>
        /// convert numeral to thai 
        /// </summary>
        /// <returns></returns>
        public string ToThai()
        {

            string ThaiStr = "";
            string DecStr = _value.ToString();

            for (int c = 0; c < DecStr.Length; c++)
            {
                if (DecStr[c] == '0')
                {
                    ThaiStr = ThaiStr + "๐";
                }
                else if (DecStr[c] == '1')
                {
                    ThaiStr = ThaiStr + "๑";
                }
                else if (DecStr[c] == '2')
                {
                    ThaiStr = ThaiStr + "๒";
                }
                else if (DecStr[c] == '3')
                {
                    ThaiStr = ThaiStr + "๓";
                }
                else if (DecStr[c] == '4')
                {
                    ThaiStr = ThaiStr + "๔";
                }
                else if (DecStr[c] == '5')
                {
                    ThaiStr = ThaiStr + "๕";
                }
                else if (DecStr[c] == '6')
                {
                    ThaiStr = ThaiStr + "๖";
                }
                else if (DecStr[c] == '7')
                {
                    ThaiStr = ThaiStr + "๗";
                }
                else if (DecStr[c] == '8')
                {
                    ThaiStr = ThaiStr + "๘";
                }
                else if (DecStr[c] == '9')
                {
                    ThaiStr = ThaiStr + "๙";
                }

            }
            return ThaiStr;
        }

        /// <summary>
        /// convert thai to numeral
        /// </summary>
        /// <param name="ThaiStr"></param>
        public void FromThai(string ThaiStr)
        {

            string DecStr = "";

            for (int c = 0; c < ThaiStr.Length; c++)
            {
                if (ThaiStr[c] == '๐')
                {
                    DecStr = DecStr + "0";
                }
                else if (ThaiStr[c] == '๑')
                {
                    DecStr = DecStr + "1";
                }
                else if (ThaiStr[c] == '๒')
                {
                    DecStr = DecStr + "2";
                }
                else if (ThaiStr[c] == '๓')
                {
                    DecStr = DecStr + "3";
                }
                else if (ThaiStr[c] == '๔')
                {
                    DecStr = DecStr + "4";
                }
                else if (ThaiStr[c] == '๕')
                {
                    DecStr = DecStr + "5";
                }
                else if (ThaiStr[c] == '๖')
                {
                    DecStr = DecStr + "6";
                }
                else if (ThaiStr[c] == '๗')
                {
                    DecStr = DecStr + "7";
                }
                else if (ThaiStr[c] == '๘')
                {
                    DecStr = DecStr + "8";
                }
                else if (ThaiStr[c] == '๙')
                {
                    DecStr = DecStr + "9";
                }

            }
            _value = Convert.ToInt32(DecStr);
        }
    }
}
