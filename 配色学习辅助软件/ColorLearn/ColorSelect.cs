using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyEvent;

namespace ColorLearn
{
    public partial class ColorSelect : UserControl
    {
        public event ColorClick colorClick;
        int Num = 100;
        public Bitmap m_Bitmap;
        public ColorSelect()
        {
            InitializeComponent();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            m_Bitmap = new Bitmap(this.Width, this.Height);
            Bitmap bitmap = m_Bitmap;
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                for (int i = 0; i < Num; i++)
                {
                    for (int j = 0; j < Num; j++)
                    {
                        var w=(i +1)* this.Width / Num-i * this.Width / Num;
                        var h = (j + 1) * this.Height / Num - (j) * this.Height / Num;
                        g.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, i * 255 / Num, j * 255 / Num)), i * this.Width / Num, j * this.Height / Num,w ,h);
                    }
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (m_Bitmap == null)
            {
                return;
            }
            Bitmap bitmap = m_Bitmap;
            e.Graphics.DrawImage(bitmap, 0, 0);
            //bitmap.Dispose();
            
            
        }
       
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
             if (colorClick != null)
            {
                colorClick(new ColorClickEventArgs(){color= Color.FromArgb(255,0,e.X*Num/this.Width*255/Num,e.Y*Num/this.Height*255/Num)});
            }
        }
    }
}
