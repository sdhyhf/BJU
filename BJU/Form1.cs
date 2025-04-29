using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJU
{
    public partial class Form1 : Form
    {
        public double[] bju(int w, int h)
        {
            label3.Text = "Белки " + (w * 10 + h * 6.25 * 0.3).ToString();
            label4.Text = "Жиры " + (w * 10 + h * 6.25 * 0.3).ToString();
            label5.Text = "Углеводы " + (w * 10 + h * 6.25 * 0.4).ToString();
            return new double[] { (w * 10 + h * 6.25 * 0.3), (w * 10 + h * 6.25 * 0.3), (w * 10 + h * 6.25 * 0.4) };
        }
        public double wat(int w)
        {
            label6.Text = "Вода " + (w * 0.025).ToString() + " л.";
            return w * 0.025;
        }
        public bool oji(int w, int h)
        {
            if (w / (h * 2) >= 30)
            {
                label7.Text = "Ожирение есть";
                return true;
            }
            else
            {
                label7.Text = "Ожирения нет";
                return false;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bju(int.Parse(textBox2.Text), int.Parse(textBox1.Text));
            wat(int.Parse(textBox2.Text));
            oji(int.Parse(textBox2.Text), int.Parse(textBox1.Text));
        }
    }
}
