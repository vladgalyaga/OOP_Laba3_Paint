using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Laba3_Paint
{

    public partial class Form1 : Form, IEventOfView
    {
        Point point, oldPoint;
        bool redacting;

        Size size = new Size();

        public event EnteringFigureEventHandler enteringFigureEventHandler;
        public event AddLayerEventHandler addLayerEventHandler;
        public event AddFigureEventHandler addFigureEventHandler;
        public event EnteringLayerEventHandler enteringLayerEventHandler;


        public event ChangeColorEventHandler changePaintColorEventHandler;
        public event ChangeColorEventHandler changeBrushColorEventHandler;
        public event DeleteObjectEventHandler deleteLayerEventHandler;
        public event EnteringCreateFigureEventHandler enteringCreateFigureEventHandler;
        public event DeleteObjectEventHandler deleteFigureEventHandler;
        public event ChangeColorEventHandler changeFiguresBrushColorEventHandler;
        public event ChangeColorEventHandler changeFiguresPaintColorEventHandler;
        public event ChangeColorEventHandler changeLayerBrushColorEventHandler;
        public event ChangeColorEventHandler changeLayerPaintColorEventHandler;
        public event ActionOnFigureEventHandler cutFigureEventHandler;
        public event ActionOnFigureEventHandler putFigureEventHandler;
        public event MovingOnObjEventHandler movingOnFigureEventHandler;
        public event MovingOnObjEventHandler movingOnLayerEventHandler;

        DeleteObjectEventHandler deletObj;
        ChangeColorEventHandler changeObjBrushColor, changeObjPaintColor;
        MovingOnObjEventHandler movingOnObjEventHandler;

        public Form1()
        {
            InitializeComponent();
        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectangle r = panel1.RectangleToScreen(panel1.ClientRectangle);
            Bitmap b = new Bitmap(r.Width, r.Height);
            Graphics g = Graphics.FromImage(b);
            g.CopyFromScreen(r.Location, new Point(0, 0), r.Size);
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.AddExtension = true;
            dlg.OverwritePrompt = true;
            dlg.CheckPathExists = true;
            dlg.ShowHelp = true;
            dlg.Filter = "All Files|*.*" +
            "|Bitmap (.BMP)|*.BMP" +
            "|JPEG (.JPEG)|*.JPEG" +
            "|JPG (.JPG)|*.JPG" +
            "|GIF (.GIF)|*.GIF" +
            "|PNG (.PNG)|*.PNG";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    b.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch
                {
                    MessageBox.Show("Impossible to save image", "FATAL ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                panel1.BackgroundImage = Image.FromFile(ofd.FileName);
            }
        }


        #region enteringfigure
        private void retangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enteringCreateFigureEventHandler?.Invoke("retangle");
        }

        private void ellipceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enteringCreateFigureEventHandler?.Invoke("ellipce");
        }
        private void LineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enteringCreateFigureEventHandler?.Invoke("line");


        }
        private void fillEllipceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enteringCreateFigureEventHandler?.Invoke("fillEllipse");
        }

        private void fillRetangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enteringCreateFigureEventHandler?.Invoke("fillRetangle");
        }
        #endregion


        private void peintsColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePaintColorEventHandler(EnterColor());
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (redacting)
            {
                int x = point.X - oldPoint.X;


                int y = point.Y - oldPoint.Y;
                 movingOnObjEventHandler?.Invoke(x, y);

            }
            else
            {
                size.Width = Math.Abs(point.X - oldPoint.X);


                size.Height = Math.Abs(point.Y - oldPoint.Y);



                addFigureEventHandler?.Invoke(oldPoint, size);
            }







        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            oldPoint.X = e.X;
            oldPoint.Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            point.X = e.X;
            point.Y = e.Y;
        }



        private void brushsColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeBrushColorEventHandler(EnterColor());
        }





        private void listBoxLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            enteringLayerEventHandler(listBoxLayer.SelectedIndex);
            deletObj = null;
            deletObj += deleteLayerEventHandler;
            changeObjBrushColor = null;
            changeObjBrushColor += changeLayerBrushColorEventHandler;
            changeObjPaintColor = null;
            changeObjPaintColor += changeLayerPaintColorEventHandler;
            movingOnObjEventHandler = null;
            movingOnObjEventHandler += movingOnLayerEventHandler;
        }

        private void listBoxFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            enteringFigureEventHandler(listBoxFigure.SelectedIndex);
            deletObj = null;
            deletObj += deleteFigureEventHandler;
            changeObjBrushColor = null;
            changeObjBrushColor += changeFiguresBrushColorEventHandler;
            changeObjPaintColor = null;
            changeObjPaintColor += changeFiguresPaintColorEventHandler;
            movingOnObjEventHandler = null;
            movingOnObjEventHandler += movingOnFigureEventHandler;
        }

        private Color EnterColor()
        {
            Color currentColor = Color.Black;
            DialogResult d = colorDialog1.ShowDialog();
            if (d == System.Windows.Forms.DialogResult.OK)
            {
                currentColor = colorDialog1.Color;
            }
            return currentColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            putFigureEventHandler?.Invoke();
        }



        public void Refresh(Bitmap img)
        {
            panel1.BackgroundImage = img;

            panel1.Refresh();
        }

        private void addLayerButton_Click(object sender, EventArgs e)
        {
            addLayerEventHandler?.Invoke();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deletObj();
        }

        private void brushColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeObjBrushColor(EnterColor());
        }

        private void paintColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeObjPaintColor(EnterColor());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cutFigureEventHandler?.Invoke();
        }

        private void addFigureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redacting = false;
        }

        private void motionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redacting = true;
        }

        public void RefreshLayers(string[] layers)
        {
            listBoxLayer.Items.Clear();
            listBoxLayer.Items.AddRange(layers);
        }

        public void RefreshFigures(string[] figures)
        {
            listBoxFigure.Items.Clear();
            listBoxFigure.Items.AddRange(figures);
        }
    }
}
