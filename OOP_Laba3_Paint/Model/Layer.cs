using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Laba3_Paint.Model.Figures;

namespace OOP_Laba3_Paint
{
    class Layer
    {
        public List<AFigure> Figures = new List<AFigure>();
        public string NumberOfLayer;
        static int m_CountOfLayer=0;

        public void Draw()
        {
            foreach (AFigure f in Figures)
            {
                f.Draw();
            }
        }


        public Layer()
        {
            m_CountOfLayer++;
            NumberOfLayer = m_CountOfLayer.ToString();
        }
    }
}
