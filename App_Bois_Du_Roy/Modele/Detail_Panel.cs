using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Bois_Du_Roy.Modele
{
    public class Detail_Panel
    {

        public void RoundCorners(Control control, int radius)
        {
            Rectangle rectangle = new Rectangle(0, 0, control.Width, control.Height);
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphicsPath.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y + rectangle.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y + rectangle.Height - radius, radius, radius, 90, 90);
            graphicsPath.CloseFigure();
            control.Region = new Region(graphicsPath);
        }
    }
}
