using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class MyTree : UserControl
    {
        MyNode root;
        public MyTree()
        {
            InitializeComponent();
            root=InitMyNode();
            
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g =this.CreateGraphics();
            g.Clear(this.BackColor);
            DrawNodeHelper.init();
            DrawNodeHelper.DrawNode(g, root);
            
        }
        public class DrawNodeHelper
        {
            private static int now;
            public static void init()
            {
                now = 0;
            }
            public static void DrawNode(Graphics g, MyNode node)
            {
                //Console.WriteLine(node.text);
                g.DrawString(node.text, new Font("宋体", 10), Brushes.White, new PointF(node.depth * 10, now * 10));
                now++;
                if (!node.hasSons || node.isClosed)
                {
                    return;
                }
                else
                {
                    node.Sons.ForEach(x => DrawNode(g, x));

                }
            }
        }
        
        public MyNode InitMyNode()
        {
            MyNode myNode = new MyNode();
            myNode.text = "root";
            myNode.depth = 0;
            
            myNode.hasSons = true;
            myNode.Sons = new List<MyNode>();

            for (int i = 0; i < 10; i++)
            {
                var son = new MyNode();
                son.text = "son1-"+i;
                son.hasSons = true;
                son.Sons = new List<MyNode>();
                son.depth = 1;
                myNode.Sons.Add(son);
                for (int j = 0; j < 10; j++)
                {
                    var son2 = new MyNode();
                    son2.text = son.text + j;
                    son2.hasSons = false;
                    son2.depth = 2;
                    son.Sons.Add(son2);
                }
            }
            return myNode;
        }
    }
    public class MyNode
    {
        private bool m_isClosed=false;
        public string text { get; set; }
        public bool hasSons { get; set; }
        public bool isClosed { get { return m_isClosed; } set { m_isClosed = value; } }
        public List<MyNode> Sons { get; set; }
        public int depth { get; set; }
    }
    
    
}
