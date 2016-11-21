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


        Size size = new Size();

        public event EnteringFigureEventHandler enteringFigureEventHandler;
        public event AddLayerEventHandler addLayerEventHandler;
        public event AddFigureEventHandler addFigureEventHandler;
        public event EnteringLayerEventHandler enteringLayerEventHandler;
        public event ChangePaintColorEventHandler changePaintColorEventHandler;
        public event ChangeBrushColorEventHandler changeBrushColorEventHandler;

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
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                panel1.BackgroundImage = Image.FromFile(ofd.FileName);
            }
        }

        private void retangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enteringFigureEventHandler?.Invoke("retangle");
        }

        private void ellipceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enteringFigureEventHandler?.Invoke("ellipce");
        }

        private void peintsColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePaintColorEventHandler(EnterColor());
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

          
                size.Width = Math.Abs(point.X - oldPoint.X);
          
            
                size.Height = Math.Abs(point.Y - oldPoint.Y);
           
            

            addFigureEventHandler?.Invoke(oldPoint, size);
        }

        private void brushsColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeBrushColorEventHandler(EnterColor());
        }

        private void LineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enteringFigureEventHandler?.Invoke("line");


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

        private void listBoxLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            enteringLayerEventHandler(listBoxLayer.SelectedIndex);
        }

        private void listBoxFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            enteringLayerEventHandler(listBoxFigure.SelectedIndex);
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

        }

        private void fillEllipceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enteringFigureEventHandler?.Invoke("fillEllipse");
        }

        private void fillRetangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enteringFigureEventHandler?.Invoke("fillRetangle");
        }

        public void Refresh(Bitmap img)
        {
            panel1.BackgroundImage = img;

            panel1.Refresh();
        }
    }
}
