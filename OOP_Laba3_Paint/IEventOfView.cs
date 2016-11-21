using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba3_Paint
{
    public delegate void EnteringFigureEventHandler(string s);
    public delegate void AddLayerEventHandler();
    public delegate void AddFigureEventHandler(Point point, Size size);
    public delegate void EnteringLayerEventHandler(int layerNumber);
    public delegate void ChangePaintColorEventHandler(Color color);
    public delegate void ChangeBrushColorEventHandler(Color color);


    public interface IEventOfView
    {
        event EnteringFigureEventHandler enteringFigureEventHandler;
        event AddLayerEventHandler addLayerEventHandler;
        event AddFigureEventHandler addFigureEventHandler;
        event EnteringLayerEventHandler enteringLayerEventHandler;
        event ChangePaintColorEventHandler changePaintColorEventHandler;
        event ChangeBrushColorEventHandler changeBrushColorEventHandler;

   
        void Refresh(Bitmap img);
    }
}
