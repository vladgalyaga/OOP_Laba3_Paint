using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba3_Paint
{
    public delegate void EnteringCreateFigureEventHandler(string s);
    public delegate void AddLayerEventHandler();
    public delegate void AddFigureEventHandler(Point point, Size size);
    public delegate void EnteringLayerEventHandler(int layerNumber);
    public delegate void EnteringFigureEventHandler(int figureName);
    public delegate void ChangeColorEventHandler(Color color);
    public delegate void ActionOnFigureEventHandler();

    public delegate void DeleteObjectEventHandler();
    public delegate void MovingOnObjEventHandler(int x, int y);


    public interface IEventOfView
    {
        event EnteringFigureEventHandler enteringFigureEventHandler;
        event EnteringCreateFigureEventHandler enteringCreateFigureEventHandler;
        event AddLayerEventHandler addLayerEventHandler;
        event DeleteObjectEventHandler deleteLayerEventHandler;
        event DeleteObjectEventHandler deleteFigureEventHandler;
        event AddFigureEventHandler addFigureEventHandler;
        event EnteringLayerEventHandler enteringLayerEventHandler;
        event ChangeColorEventHandler changePaintColorEventHandler;
        event ChangeColorEventHandler changeBrushColorEventHandler;
        event ChangeColorEventHandler changeFiguresBrushColorEventHandler;
        event ChangeColorEventHandler changeFiguresPaintColorEventHandler;
        event ChangeColorEventHandler changeLayerBrushColorEventHandler;
        event ChangeColorEventHandler changeLayerPaintColorEventHandler;
        event ActionOnFigureEventHandler cutFigureEventHandler;
        event ActionOnFigureEventHandler putFigureEventHandler;
        event MovingOnObjEventHandler movingOnFigureEventHandler;
        event MovingOnObjEventHandler movingOnLayerEventHandler;


        void RefreshLayers(string[] layers);
        void RefreshFigures(string[] figures);
        void Refresh(Bitmap img);
    }
}
