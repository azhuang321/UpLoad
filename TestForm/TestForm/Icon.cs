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
    public partial class Icon : UserControl
    {
        public Icon()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int width = 20;
            var pic = DrawPicture(new Size(10, 10), PictureType.CircleEmpty, Color.Red);
            e.Graphics.DrawImage(pic, 0, 0);
            pic = DrawPicture(new Size(10, 10), PictureType.CircleEntity, Color.Red);
            e.Graphics.DrawImage(pic, 0, width);
            pic = DrawPicture(new Size(10, 10), PictureType.RactangleEntity, Color.Red);
            e.Graphics.DrawImage(pic, 0, 2*width);
            pic = DrawPicture(new Size(10, 10), PictureType.RactangleEmpty, Color.Red);
            e.Graphics.DrawImage(pic, 0, 3*width);
        }
        /// <summary>
        /// 画图片
        /// </summary>
        /// <param name="size">大小</param>
        /// <param name="pictureType">图片类型</param>
        /// <param name="color">颜色</param>
        /// <returns></returns>
        public Bitmap DrawPicture(Size size,PictureType pictureType,Color color)
        {
            Bitmap pic = new Bitmap(size.Width,size.Height);
            Graphics g = Graphics.FromImage(pic);
            switch (pictureType)
            {
                case PictureType.CircleEmpty:
                    g.DrawEllipse(new Pen(new SolidBrush(color),2), new Rectangle(0, 0, pic.Width, pic.Height));
                    break;
                case PictureType.CircleEntity:
                    g.FillEllipse(new SolidBrush(color), new Rectangle(0, 0, pic.Width, pic.Height));
                    break;
                case PictureType.RactangleEmpty:
                    g.DrawRectangle(new Pen(new SolidBrush(color),2), new Rectangle(0, 0, pic.Width, pic.Height));
                    break;
                case PictureType.RactangleEntity:
                    g.FillRectangle(new SolidBrush(color), new Rectangle(0, 0, pic.Width, pic.Height));
                    break;
                default: break;
            }          
            g.Dispose();
            return pic;
        }
        /// <summary>
        /// 图片类型
        /// </summary>
        public enum PictureType
        {
            /// <summary>
            /// 空心圆
            /// </summary>
            CircleEmpty,
            /// <summary>
            /// 实体圆
            /// </summary>
            CircleEntity,
            /// <summary>
            /// 空心矩形
            /// </summary>
            RactangleEmpty,
            /// <summary>
            /// 实体矩形
            /// </summary>
            RactangleEntity
        }
        public class MyControl
        {
            /// <summary>
            /// 控件图片
            /// </summary>
            public Bitmap pic { get; set; }
            /// <summary>
            /// 控件位置
            /// </summary>
            public Point position { get; set; }

        }
    }
}
