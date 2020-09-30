using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图表控件
{
    public partial class LineChart : UserControl
    {
        public List<double> DataList;
        public int scale = 1;
        public LineChart()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DoubleBuffer doubleBuffer = new DoubleBuffer(this.Width,this.Height);
           
            if(DataList!=null&&DataList.Count!=0){
                 var points = new List<PointF>();
                int i=0;
                DataList.ForEach(x=>{
                    points.Add(new PointF(i*100,(float)(x*scale)));
                    i++;
                });
                doubleBuffer.g.DrawLines(new Pen(Brushes.Black), points.ToArray());
                for (int j = 0; j < points.Count; j++)
                {
                    doubleBuffer.g.DrawEllipse(new Pen(Brushes.Black), new Rectangle((int)points[j].X,(int)points[j].Y, 2, 2));
                }
            }
            e.Graphics.DrawImage(doubleBuffer.pic,0,0);
            doubleBuffer.Dispose();
            
        }
    }
}
