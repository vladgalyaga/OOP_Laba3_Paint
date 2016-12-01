using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_Laba3_Paint
{
    class FillEllipse : Ellipse
    {
        public FillEllipse(Point point, Size size, Color paintColor, Color brushColor) : base(point, size, paintColor, brushColor)
        {
        }
        public override void Draw()
        {
            base.Draw();
            Brush b = new SolidBrush(BrushColor);
            Rectangle rect = new Rectangle(Point, Size);
            p_ModelController.g.FillEllipse(b, rect);
        }
    }
}
