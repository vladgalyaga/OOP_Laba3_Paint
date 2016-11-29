using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Laba3_Paint.Model.Figures;
using System.Drawing;

namespace OOP_Laba3_Paint
{
    public class ModelController : IModel
    {

        static ModelController fModelController;

        static Bitmap m_img = new Bitmap(2000, 2000);
        private Dictionary<string, Type> m_figuresType;
        Type m_figur;
        List<Layer> m_layers = new List<Layer>();
        Layer m_workLayer;
        AFigure m_workFigure;
        Color m_brushColor = Color.Black;
        Color m_paintColor = Color.Black;
        public event ChangeIMGEventHandler changeIMGEventHandler;
        public event ChangeLayersEventHandler changeLayersEventHandler;
        public event ChangeFiguresEventHandler changeFiguresEventHandler;

        public Bitmap Img
        {
            get
            {
                return m_img;
            }

            set
            {
                m_img = value;

            }
        }
        public Graphics g;

        public static ModelController GetIstance()
        {
            if (fModelController != null)
            {

                fModelController = new ModelController();
            }
            return fModelController;
        }

        public ModelController()
        {
            g = Graphics.FromImage(Img);
            AFigure.p_ModelController = this;
            m_workLayer = new Layer();
            m_layers.Add(m_workLayer);
            m_figuresType = new Dictionary<string, Type>();
            m_figuresType.Add("line", typeof(Line));
            m_figuresType.Add("retangle", typeof(Model.Figures.CRectangle));
            m_figuresType.Add("ellipce", typeof(Ellipse));
            m_figuresType.Add("fillEllipse", typeof(FillEllipse));
            m_figuresType.Add("fillRetangle", typeof(FillRectangle));
            m_figur = typeof(Model.Figures.CRectangle);
            //   m_figuresType.Add("triangle", typeof(Triangle));

        }

        public void ChangePaintColor(Color color)
        {
            m_paintColor = color;
        }
        public void ChangeBrushColor(Color color)
        {
            m_brushColor = color;
        }
        public void AddFigure(Point point, Size size)
        {

            //Img = new Bitmap(2000, 2000);
            //g = Graphics.FromImage(Img);
            object[] parametrs = new object[4];
            //  (Point point, Size size, Color color)
            parametrs[0] = point;
            parametrs[1] = size;
            parametrs[2] = m_paintColor;
            parametrs[3] = m_brushColor;


            AFigure figure = (AFigure)Activator.CreateInstance(m_figur, parametrs);

            m_workLayer.Figures.Add(figure);

            RefreshIMG();

        }
        public void AddLayer()
        {
            m_layers.Add(new Layer());
            changeLayers();
        }
        public void EnteringFigure(int figureNumber)
        {
            m_workFigure = m_workLayer.Figures[figureNumber];
        }
        public void EnteringLayer(int layerNumber)
        {
            m_workLayer = m_layers[layerNumber];
        }
        public void DeleteLayers()
        {

            m_layers.Remove(m_workLayer);
            m_workLayer = m_layers[0];
            RefreshIMG();
        }
        public void DeleteFigure()
        {
            m_workLayer.Figures.Remove(m_workFigure);
            m_workFigure = m_workLayer.Figures[0];
            RefreshIMG();

        }

        public void EnteringFigure(string nameOfFigure)
        {
            m_figur = m_figuresType[nameOfFigure];

        }
        private void changeLayers()
        {
            int layersCount = m_layers.Count;
            string[] layersesNames = new string[layersCount];
            for (int i = 0; i < layersCount; i++)
            {
                layersesNames[i] = m_layers[i].NumberOfLayer;
            }



            changeLayersEventHandler?.Invoke(layersesNames);
        }
        private void changeFigures()
        {
            int FiguresCount = m_workLayer.Figures.Count;
            string[] figuresNames = new string[FiguresCount];
            for (int i = 0; i < FiguresCount; i++)
            {
                figuresNames[i] = m_workLayer.Figures[i].Name;
            }
            changeFiguresEventHandler(figuresNames);
        }


        private void RefreshIMG()
        {
            g.Clear(Color.White);
            foreach (Layer l in m_layers)
            {
                l.Draw();
            }
            changeIMGEventHandler?.Invoke(Img);
            changeLayers();
            changeFigures();
        }
    }
}
