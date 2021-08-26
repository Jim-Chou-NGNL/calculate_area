using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public double transform(string r)
        {
            double ret;
            try
            {
                ret = Convert.ToDouble(r);
            }
            catch
            {
                ret = -1;

            }
            return ret;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string r = textBox1.Text;
            double a = transform(r);
            if (a == -1)
                MessageBox.Show("非法数值，请重新输入");
            else
            {
                a = 3.14 * a * a;
                MessageBox.Show("圆的面积是" + a.ToString("f3"));
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
