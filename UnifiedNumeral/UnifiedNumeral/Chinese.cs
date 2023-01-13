using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnifiedNumeral
{
    public partial class UnifiedNumeral
    {
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

     
    }
}
