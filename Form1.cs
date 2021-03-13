using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            if (radioButton1.Checked)
                label1.Text = Convert.ToString(c1.add(a, b));
            else if (radioButton2.Checked)
                label1.Text = Convert.ToString(c1.sub(a, b));
            else if (radioButton3.Checked)
                label1.Text = Convert.ToString(c1.mul(a, b));
            else if (radioButton4.Checked)
                label1.Text = Convert.ToString(c1.div(a, b));
            else if (radioButton5.Checked)
                label1.Text = Convert.ToString(c1.mod(a, b));
            else if (radioButton6.Checked)
                label1.Text = Convert.ToString(c1.pow((int)a,(int)b));
        }




        private void Handledigit(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
                e.Handled = true;
        }

    }
}
