using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba3_Paint.Model.Figures
{
    class Line : AFigure
    {
        public Line(Point point, Size size, Color paintColor, Color brushColor) : base(point, size, paintColor, brushColor)
        {
        }

        public override void Draw()
        {
            Pen p = new Pen(PaintColor, 5);
            Rectangle rect = new Rectangle(Point, Size);
            Point point = new Point();
            point.X = Point.X + Size.Width;
            point.Y= Point.Y + Size.Height;

            p_ModelController.g.DrawLine(p, Point, point);
        }
    }
}
