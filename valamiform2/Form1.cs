using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valamiform2
{
    public partial class Form1 : Form
    {
        int mozgas = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonfelul_Click(object sender, EventArgs e)
        {
            Top = 0;
        }

        private void buttonfel_Click(object sender, EventArgs e)
        {
            if (Screen.PrimaryScreen.WorkingArea.Height - Height > Top)
            {
                Top = -mozgas;
            }
        }

        private void kozep_Click(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void buttonle_Click(object sender, EventArgs e)
        {
            if (Screen.PrimaryScreen.WorkingArea.Height - Height > Top)
            {
                Top = -mozgas;
            }
        }
    }
}
