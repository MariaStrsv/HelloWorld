using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CF1;
using CF2;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CF1class.x2(Convert.ToInt32(textBox1.Text)).ToString());//
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CF2class.f(Convert.ToInt32(textBox1.Text)).ToString());//
        }
    }
}
