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
    public partial class Form3 : Form
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
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string r = textBox1.Text;
            double a = transform(r);
            if (a == -1)
                MessageBox.Show("非法数值，请重新输入");
            else
            {
                a = a * a;
                MessageBox.Show("正方形的面积是" + a.ToString("f3"));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
