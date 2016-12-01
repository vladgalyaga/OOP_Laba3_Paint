using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Laba3_Paint.Model.Figures;
using System.Drawing;
using OOP_Laba3_Paint.Model.Factories;

namespace OOP_Laba3_Paint
{
    public class ModelController : IModel
    {

        static ModelController fModelController;

        static Bitmap m_img = new Bitmap(2000, 2000);
        //   private Dictionary<string, Type> m_figuresType;
        private Dictionary<string, AFactory> m_figuresType;
        string m_figur;
        List<Layer> m_layers = new List<Layer>();
        Layer m_workLayer;
        AFigure m_workFigure;
        AFigure m_tmpFigure;



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

            m_figuresType = new Dictionary<string, AFactory>();
            m_figuresType.Add("line", new LineFactory());
            m_figuresType.Add("retangle", new RectangleFacrory());
            m_figuresType.Add("ellipce", new EllipseFactory());
            m_figuresType.Add("fillEllipse", new FillElipseFactory());
            m_figuresType.Add("fillRetangle", new FillRectangleFactory());
            m_figur = "retangle";
        }

        //public ModelController()
        //{
        //    g = Graphics.FromImage(Img);
        //    AFigure.p_ModelController = this;
        //    m_workLayer = new Layer();
        //    m_layers.Add(m_workLayer);
        //    m_figuresType = new Dictionary<string, Type>();
        //    m_figuresType.Add("line", typeof(Line));
        //    m_figuresType.Add("retangle", typeof(Model.Figures.CRectangle));
        //    m_figuresType.Add("ellipce", typeof(Ellipse));
        //    m_figuresType.Add("fillEllipse", typeof(FillEllipse));
        //    m_figuresType.Add("fillRetangle", typeof(FillRectangle));
        //    m_figur = typeof(Model.Figures.CRectangle);


        //}

        public void ChangePaintColor(Color color)
        {

            m_figuresType[m_figur].PaintColor = color;
        }
        public void ChangeBrushColor(Color color)
        {

            m_figuresType[m_figur].BrushColor = color;
        }
        public void AddFigure(Point point, Size size)
        {

            m_workLayer.Figures.Add(m_figuresType[m_figur].CreateProduct(point, size));

            RefreshIMG();

        }
        //public void AddFigure(Point point, Size size)
        //{

        //    //Img = new Bitmap(2000, 2000);
        //    //g = Graphics.FromImage(Img);
        //    object[] parametrs = new object[4];
        //    //  (Point point, Size size, Color color)
        //    parametrs[0] = point;
        //    parametrs[1] = size;
        //    parametrs[2] = m_paintColor;
        //    parametrs[3] = m_brushColor;


        //    AFigure figure = (AFigure)Activator.CreateInstance(m_figur, parametrs);

        //    m_workLayer.Figures.Add(figure);

        //    RefreshIMG();

        //}
        public void AddLayer()
        {
            m_layers.Add(new Layer());
            changeLayers();
        }
        public void EnteringFigure(int figureNumber)
        {
            m_workFigure = m_workLayer.Figures[figureNumber];
            changeLayers();
            changeFigures();
        }
        public void EnteringLayer(int layerNumber)
        {
            m_workLayer = m_layers[layerNumber];
            changeLayers();
            changeFigures();
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
            m_figur = nameOfFigure;

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
        public void ChangePaintColorLayer(Color color)
        {
            for (int i = 0; i < m_workLayer.Figures.Count; i++)
            {
                m_workLayer.Figures[i].PaintColor = color;
            }
            RefreshIMG();
        }
        public void ChangeBrushColorLayer(Color color)
        {
            for (int i = 0; i < m_workLayer.Figures.Count; i++)
            {
                m_workLayer.Figures[i].BrushColor = color;
            }
            RefreshIMG();
        }
        public void ChangeBrushColorFigure(Color color)
        {
            m_workFigure.BrushColor = color;
            RefreshIMG();
        }
        public void ChangePaintColorFigure(Color color)
        {
            m_workFigure.PaintColor = color;
            RefreshIMG();
        }
        public void CutFigure()
        {
            m_tmpFigure = m_workFigure;
            DeleteFigure();

        }
        public void PutFigure()
        {
            m_workLayer.Figures.Add(m_tmpFigure);

            RefreshIMG();

        }
        public void FiguresMoving(int x, int y)
        {
            Point p = m_workFigure.Point;
            p.X += x;
            p.Y += y;
            m_workFigure.Point = p;
            RefreshIMG();
        }
        public void LayerMoving(int x, int y)
        {
            for (int i = 0; i < m_workLayer.Figures.Count; i++)
            {
                Point p = m_workLayer.Figures[i].Point; ;
                p.X += x;
                p.Y += y;
                m_workLayer.Figures[i].Point= p;
                
            }
            RefreshIMG();
        }

    }
}
