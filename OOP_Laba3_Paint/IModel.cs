using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba3_Paint
{
    public delegate void ChangeIMGEventHandler(Bitmap img);
    public delegate void ChangeLayersEventHandler(string[] layers);
    public delegate void ChangeFiguresEventHandler(string[] figures);

    interface IModel
    {
        event ChangeIMGEventHandler changeIMGEventHandler;
        event ChangeLayersEventHandler changeLayersEventHandler;
        event ChangeFiguresEventHandler changeFiguresEventHandler;
    }
}
