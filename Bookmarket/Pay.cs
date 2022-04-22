using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookmarket
{
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(ptotal.Text);
            double num2 = Convert.ToDouble(moneybox.Text);
            double num3 = Convert.ToDouble(Change.Text);
            num3 = num2 - num1;
            Change.Text = num2.ToString();
        }
    }
}
