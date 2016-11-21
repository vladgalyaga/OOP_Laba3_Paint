using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba3_Paint.Model.Figures
{
    public  delegate void AddFigureIMGEventHandler();


    public abstract class AFigure
    {
     
        public static ModelController p_ModelController;
        Point m_point;
        protected Color paintColor;
        private Color brushColor;

        Size m_size;



        protected Color PaintColor
        {
            get
            {
                return paintColor;
            }

            set
            {
                paintColor = value;
            }
        }

        protected Size Size
        {
            get
            {
                return m_size;
            }

            set
            {
                m_size = value;
            }
        }

        public Point Point
        {
            get
            {
                return m_point;
            }

            set
            {
                m_point = value;
            }
        }

        protected Color BrushColor
        {
            get
            {
                return brushColor;
            }

            set
            {
                brushColor = value;
            }
        }

        public abstract void Draw();





        public AFigure(Point point, Size size, Color paintColor, Color brushColor)
        {
            Point = point;
            Size = size;
            PaintColor = paintColor;
            BrushColor = brushColor;
        }


    }
}
