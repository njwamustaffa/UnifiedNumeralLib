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
        /// Convert Decimal to Chinese
        /// </summary>
        /// <returns>Chinese string</returns>
        public string ToChinese()
        {
            int DecStr = _value;
            string[] chineseNumbers = { "零", "一", "二", "三", "四", "五", "六", "七", "八", "九" };
            string[] chineseUnit = { "", "十", "百", "千", "万", "十万", "百万", "千万", "亿" };

            string ChnStr = "";
            int i = 0;
            do
            {
                int numberAtUnit = DecStr % 10;
                if (numberAtUnit != 0 || (DecStr == 0 && ChnStr == ""))
                {
                    ChnStr = chineseNumbers[numberAtUnit] + chineseUnit[i] + ChnStr;
                }
                else if (numberAtUnit == 0 && ChnStr != "" && ChnStr[0] != '零')
                {
                    ChnStr = "零" + ChnStr;
                }
                i++;
                DecStr /= 10;
            } while (DecStr > 0);

            return ChnStr;
        }

        /// <summary>
        /// Convert Chinese to Decimal
        /// </summary>
        /// <param name="ChnStr">chinese character in string</param>
        public void FromChinese(string ChnStr)
        {
            string ChinStr = "";
            string[] chineseNumbers = { "零", "一", "二", "三", "四", "五", "六", "七", "八", "九" };
            string[] chineseUnit = { "", "十", "百", "千", "万", "十万", "百万", "千万", "亿" };
            int DecStr = 0, powten = 0, temp = 0;
            int c;

            for (c = 0; c < ChnStr.Length; c += 2)
            {
                if (c < ChnStr.Length - 1)
                {
                    if (ChnStr[c] == '零')
                    {
                        DecStr = 0;
                    }

                    else if (ChnStr[c] == '一')
                    {
                        DecStr = 1;
                    }

                    else if (ChnStr[c] == '二')
                    {
                        DecStr = 2;
                    }

                    else if (ChnStr[c] == '三')
                    {
                        DecStr = 3;
                    }

                    else if (ChnStr[c] == '四')
                    {
                        DecStr = 4;
                    }

                    else if (ChnStr[c] == '五')
                    {
                        DecStr = 5;
                    }

                    else if (ChnStr[c] == '六')
                    {
                        DecStr = 6;
                    }

                    else if (ChnStr[c] == '七')
                    {
                        DecStr = 7;
                    }

                    else if (ChnStr[c] == '八')
                    {
                        DecStr = 8;
                    }

                    else if (ChnStr[c] == '九')
                    {
                        DecStr = 9;
                    }

                    if (ChnStr[c + 1] == '零')
                    {
                        powten = 1;
                    }

                    else if (ChnStr[c + 1] == '十')
                    {
                        powten = 10;
                    }

                    else if (ChnStr[c + 1] == '百')
                    {
                        powten = 100;
                    }

                    else if (ChnStr[c + 1] == '千')
                    {
                        powten = 1000;
                    }

                    else if (ChnStr[c + 1] == '万')
                    {
                        powten = 10000;
                    }

                    temp += DecStr * powten;
                }

                else
                {
                    if (ChnStr[c] == '零')
                    {
                        DecStr = 0;
                    }

                    else if (ChnStr[c] == '一')
                    {
                        DecStr = 1;
                    }

                    else if (ChnStr[c] == '二')
                    {
                        DecStr = 2;
                    }

                    else if (ChnStr[c] == '三')
                    {
                        DecStr = 3;
                    }

                    else if (ChnStr[c] == '四')
                    {
                        DecStr = 4;
                    }

                    else if (ChnStr[c] == '五')
                    {
                        DecStr = 5;
                    }

                    else if (ChnStr[c] == '六')
                    {
                        DecStr = 6;
                    }

                    else if (ChnStr[c] == '七')
                    {
                        DecStr = 7;
                    }

                    else if (ChnStr[c] == '八')
                    {
                        DecStr = 8;
                    }

                    else if (ChnStr[c] == '九')
                    {
                        DecStr = 9;
                    }

                    temp += DecStr;
                }
            }
            _value = temp;


        }

    }
}
