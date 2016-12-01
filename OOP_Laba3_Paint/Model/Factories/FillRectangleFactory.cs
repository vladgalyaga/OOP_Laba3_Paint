﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Laba3_Paint.Model.Figures;

namespace OOP_Laba3_Paint.Model.Factories
{
    class FillRectangleFactory : AFactory
    {


        public override AFigure CreateProduct(Point point, Size size)
        {
            return new FillRectangle(point, size, PaintColor, BrushColor);
        }
    }
}
