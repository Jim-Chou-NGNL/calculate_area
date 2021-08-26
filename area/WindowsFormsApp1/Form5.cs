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
    public partial class Form5 : Form
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
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a, h;
            a = this.textBox1.Text;
            h = this.textBox2.Text;
            double ad = transform(a);
            double hd = transform(h);
            if (ad == -1 || hd == -1)
                MessageBox.Show("请重新输入");
            else
            {
                double s = ad * hd;
                MessageBox.Show("三角形的面积是" + s.ToString("f3"));
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
