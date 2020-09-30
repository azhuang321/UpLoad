using System.Drawing;
namespace 图表控件
{
    public class DoubleBuffer
    {
        public Graphics g;
        public Bitmap pic;
        public DoubleBuffer(int w, int h)
        {
            pic = new Bitmap(w, h);
            g = Graphics.FromImage(pic);
        }
        public void Dispose()
        {
            g.Dispose();
            pic.Dispose();
        }
    }
}