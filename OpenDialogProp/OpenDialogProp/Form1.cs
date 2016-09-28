using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenDialogProp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddX_Click(object sender, EventArgs e)
        {
            XEdit editForm = new XEdit();
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            labelX1.Text = editForm.X1.ToString();
            labelX2.Text = editForm.X2.ToString();

        }

       
    }
}
