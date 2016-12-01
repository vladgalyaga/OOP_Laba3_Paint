using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Laba3_Paint.Model.Figures;

namespace OOP_Laba3_Paint.Model.Factories
{
    class LineFactory : AFactory
    {


        public override AFigure CreateProduct(Point point, Size size)
        {
            return new Line(point, size, PaintColor, BrushColor);
        }
    }
}
