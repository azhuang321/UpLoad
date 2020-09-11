using System.Drawing;
namespace MyEvent
{
    public delegate void ColorClick(ColorClickEventArgs e);
    public class ColorClickEventArgs
    {
        public Color color;
    }
}