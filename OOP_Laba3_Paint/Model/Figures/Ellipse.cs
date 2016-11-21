using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba3_Paint.Model.Figures
{
    class Ellipse : AFigure
    {
        public Ellipse(Point point, Size size, Color paintColor, Color brushColor ) : base(point, size, paintColor, brushColor)
        {
        }

        public override void Draw()
        {
            Pen p = new Pen(PaintColor, 5);

            Rectangle rect = new Rectangle(Point, Size);
            p_ModelController.g.DrawEllipse(p, rect);
            

        }
    }
}
