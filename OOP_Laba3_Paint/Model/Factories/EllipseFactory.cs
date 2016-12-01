using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba3_Paint.Model.Factories
{
    class EllipseFactory : AFactory
    {

        public override AFigure CreateProduct(Point point, Size size)
        {
            return new Ellipse(point, size, PaintColor, BrushColor);
        }
    }
}
