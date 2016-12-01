using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Laba3_Paint.Model.Figures;

namespace OOP_Laba3_Paint
{
    public abstract class AFactory
    {
        
        Point point;
        Size size;
        Color m_paintColor=Color.Black;
        Color m_brushColor = Color.Black;

        public Point Point
        {
            get
            {
                return point;
            }

            set
            {
                point = value;
            }
        }

        public Size Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        public Color PaintColor
        {
            get
            {
                return m_paintColor;
            }

            set
            {
                m_paintColor = value;
            }
        }

        public Color BrushColor
        {
            get
            {
                return m_brushColor;
            }

            set
            {
                m_brushColor = value;
            }
        }

        public abstract AFigure CreateProduct(Point point,Size size);



    }
}
