using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEGYSZIVESFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Top = 0;
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
            Left = 0;
        }
    }
}
