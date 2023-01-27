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
        /// field
        /// </summary>
        private int _value;

        /// <summary>
        /// properties
        /// </summary>
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// constructor without parameter
        /// </summary>
        public UnifiedNumeral()
        {
            _value = 0;
        }

        /// <summary>
        /// constructor with parameter
        /// </summary>
        /// <param name="a"></param>
        public UnifiedNumeral(int a)
        {
            _value = a;
        }
    }
}
