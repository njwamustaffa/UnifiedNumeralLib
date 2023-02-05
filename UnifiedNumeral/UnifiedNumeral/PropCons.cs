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
        /// Field
        /// </summary>
        private int _value;

        /// <summary>
        /// Properties
        /// </summary>
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// Constructor without parameter
        /// </summary>
        public UnifiedNumeral()
        {
            _value = 0;
        }

        /// <summary>
        /// Constructor with parameter
        /// </summary>
        /// <param name="a"> Parameters</param>
        public UnifiedNumeral(int a)
        {
            _value = a;
        }
    }
}
