using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnifiedNumeral
{
    public partial class UnifiedNumeral
    {
        private int _value;

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public UnifiedNumeral()
        {
            _value = 0;
        }

        public UnifiedNumeral(int a)
        {
            _value = a;
        }
    }
}
