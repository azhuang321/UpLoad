using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorLearn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorSelect1_Load(object sender, EventArgs e)
        {

        }

        private void colorSelect1_colorClick(MyEvent.ColorClickEventArgs e)
        {
            this.textBox1.Text = "" + e.color.R +","+ e.color.G+"," + e.color.B;
            this.colorPanel1.BackColor = e.color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
