using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba3_Paint.Model.Figures
{
    class FillRectangle : CRectangle
    {
        public FillRectangle(Point point, Size size, Color paintColor, Color brushColor) : base(point, size, paintColor, brushColor)
        {
        }
        public override void Draw()
        {
            base.Draw();
            Rectangle rect = new Rectangle(Point, Size);
            Brush b = new SolidBrush(BrushColor);
            p_ModelController.g.FillRectangle(b, rect);
        }
    }
}
