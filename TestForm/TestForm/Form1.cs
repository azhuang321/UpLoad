using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dynamic dynamicObject = GetData();
            
            Console.WriteLine(dynamicObject.Name);
            Console.WriteLine(dynamicObject.data);
            var form1 = new LoginForm();
            form1.TopLevel= false;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;
            panel7.Controls.Add(form1);
            form1.Show();
        }
        private object GetData()
        {
            return new { Name = "12", data = 10 };
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_DragEnter(object sender, DragEventArgs e)
        {
            var x = 1;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    public class DataNode
    {
        public DataNode Parent;
        public int Data;
        public int Tianshi;
        public int Dili;
        public int RenHe;
    }
}
