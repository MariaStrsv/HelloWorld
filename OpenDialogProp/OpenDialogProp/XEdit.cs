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
    public partial class XEdit : Form
    {
        public XEdit()
        {
            InitializeComponent();
        }

        public int X1
        {
            get { return Convert.ToInt32(textBoxX1.Text); }
            set { textBoxX1.Text = value.ToString(); }
        }
        public int X2
        {
            get { return Convert.ToInt32(textBoxX2.Text); }
            set { textBoxX2.Text = value.ToString(); }
        }
    }
}
