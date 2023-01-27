using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnifiedNumeral;

namespace DebuggingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UnifiedNumeral.UnifiedNumeral a = new UnifiedNumeral.UnifiedNumeral();

            a.FromChinese("一十二");
            label1.Text = a.Value.ToString();
        }
    }
}
