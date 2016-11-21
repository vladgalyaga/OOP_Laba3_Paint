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

        public void Draw()
        {
            foreach (AFigure f in Figures)
            {
                f.Draw();
            }
        }

    }
}
