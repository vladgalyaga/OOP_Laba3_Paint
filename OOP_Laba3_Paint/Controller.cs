using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Laba3_Paint.Model;
using System.Drawing;

namespace OOP_Laba3_Paint
{
    class Controller
    {
        private IEventOfView m_view;
        private ModelController m_model;


        public Controller(Form1 view)
        {
            m_view = view;
            m_view.enteringCreateFigureEventHandler += View_enteringFigureEventHandler;
            m_view.enteringLayerEventHandler += M_view_enteringLayerEventHandler;
            m_view.changePaintColorEventHandler += M_view_changePaintColorEventHandler;
            m_view.changeBrushColorEventHandler += M_view_changeBrushColorEventHandler;
            m_view.addLayerEventHandler += M_view_addLayerEventHandler;
            m_view.addFigureEventHandler += M_view_addFigureEventHandler;
            m_view.deleteLayerEventHandler += M_view_deleteLayerEventHandler;



            m_model = new ModelController();
            m_model.changeIMGEventHandler += M_model_changeIMGEventHandler;
            m_model.changeLayersEventHandler += M_model_changeLayersEventHandler;




            m_model.changeFiguresEventHandler += m_view.RefreshFigures;



            m_view.enteringFigureEventHandler += m_model.EnteringFigure;

        }

        private void M_view_deleteLayerEventHandler()
        {
            m_model.DeleteLayers();
        }

        private void M_model_changeLayersEventHandler(string[] layers)
        {
            m_view.RefreshLayers(layers);
        }

        private void M_model_changeIMGEventHandler(Bitmap img)
        {
            m_view.Refresh(img);
        }

        private void M_view_addFigureEventHandler(Point point, Size size)
        {
            
            m_model.AddFigure(point, size);
        }

        private void M_view_addLayerEventHandler()
        {
            m_model.AddLayer();
        }

        private void M_view_changeBrushColorEventHandler(System.Drawing.Color color)
        {
            m_model.ChangeBrushColor(color);
        }

        private void M_view_changePaintColorEventHandler(System.Drawing.Color color)
        {
            m_model.ChangePaintColor(color);
        }

        private void M_view_enteringLayerEventHandler(int layerNumber)
        {
            m_model.EnteringLayer(layerNumber);
        }

        private void View_enteringFigureEventHandler(string s)
        {
            m_model.EnteringFigure(s);
        }

    }
}
