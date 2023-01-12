using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnifiedNumeral
{
    public partial class UnifiedNumeral
    {
        static void Main(string[] args)
        {
            string s;
            s = "MMCCCLXV";
            Console.WriteLine("Original integer value: " + s);
            Console.WriteLine("Integer value of the said Roman numerals:");
            Console.WriteLine(roman_to_int(s));
            s = "CCLIV";
            Console.WriteLine("Original integer value: " + s);
            Console.WriteLine("Integer value of the said Roman numerals:");
            Console.WriteLine(roman_to_int(s));
            s = "XLV";
            Console.WriteLine("Original integer value: " + s);
            Console.WriteLine("Integer value of the said Roman numerals:");
            Console.WriteLine(roman_to_int(s));
            s = "VIII";
            Console.WriteLine("Original integer value: " + s);
            Console.WriteLine("Integer value of the said Roman numerals:");
            Console.WriteLine(roman_to_int(s));
        }
    }
}
