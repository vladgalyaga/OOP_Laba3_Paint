namespace OOP_Laba3_Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFigureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peintsColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushsColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxLayer = new System.Windows.Forms.ListBox();
            this.listBoxFigure = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fillEllipceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillRetangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addFigureToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(581, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "File...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // addFigureToolStripMenuItem
            // 
            this.addFigureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retangleToolStripMenuItem,
            this.ellipceToolStripMenuItem,
            this.LineToolStripMenuItem,
            this.fillEllipceToolStripMenuItem,
            this.fillRetangleToolStripMenuItem});
            this.addFigureToolStripMenuItem.Name = "addFigureToolStripMenuItem";
            this.addFigureToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.addFigureToolStripMenuItem.Text = "Add Figure...";
            // 
            // retangleToolStripMenuItem
            // 
            this.retangleToolStripMenuItem.Name = "retangleToolStripMenuItem";
            this.retangleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.retangleToolStripMenuItem.Text = "Retangle";
            this.retangleToolStripMenuItem.Click += new System.EventHandler(this.retangleToolStripMenuItem_Click);
            // 
            // ellipceToolStripMenuItem
            // 
            this.ellipceToolStripMenuItem.Name = "ellipceToolStripMenuItem";
            this.ellipceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ellipceToolStripMenuItem.Text = "Ellipce";
            this.ellipceToolStripMenuItem.Click += new System.EventHandler(this.ellipceToolStripMenuItem_Click);
            // 
            // LineToolStripMenuItem
            // 
            this.LineToolStripMenuItem.Name = "LineToolStripMenuItem";
            this.LineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LineToolStripMenuItem.Text = "Line";
            this.LineToolStripMenuItem.Click += new System.EventHandler(this.LineToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peintsColorToolStripMenuItem,
            this.brushsColorToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.optionsToolStripMenuItem.Text = "Options...";
            // 
            // peintsColorToolStripMenuItem
            // 
            this.peintsColorToolStripMenuItem.Name = "peintsColorToolStripMenuItem";
            this.peintsColorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.peintsColorToolStripMenuItem.Text = "Peint`s color";
            this.peintsColorToolStripMenuItem.Click += new System.EventHandler(this.peintsColorToolStripMenuItem_Click);
            // 
            // brushsColorToolStripMenuItem
            // 
            this.brushsColorToolStripMenuItem.Name = "brushsColorToolStripMenuItem";
            this.brushsColorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.brushsColorToolStripMenuItem.Text = "Brush`s color";
            this.brushsColorToolStripMenuItem.Click += new System.EventHandler(this.brushsColorToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(581, 297);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 291);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.listBoxLayer, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.listBoxFigure, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button4, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(390, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(188, 291);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // listBoxLayer
            // 
            this.listBoxLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLayer.FormattingEnabled = true;
            this.listBoxLayer.Location = new System.Drawing.Point(3, 144);
            this.listBoxLayer.Name = "listBoxLayer";
            this.listBoxLayer.Size = new System.Drawing.Size(88, 144);
            this.listBoxLayer.TabIndex = 0;
            this.listBoxLayer.SelectedIndexChanged += new System.EventHandler(this.listBoxLayer_SelectedIndexChanged);
            // 
            // listBoxFigure
            // 
            this.listBoxFigure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFigure.FormattingEnabled = true;
            this.listBoxFigure.Location = new System.Drawing.Point(97, 144);
            this.listBoxFigure.Name = "listBoxFigure";
            this.listBoxFigure.Size = new System.Drawing.Size(88, 144);
            this.listBoxFigure.TabIndex = 1;
            this.listBoxFigure.SelectedIndexChanged += new System.EventHandler(this.listBoxFigure_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cut";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Put";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Combine";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(97, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // fillEllipceToolStripMenuItem
            // 
            this.fillEllipceToolStripMenuItem.Name = "fillEllipceToolStripMenuItem";
            this.fillEllipceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fillEllipceToolStripMenuItem.Text = "Fill Ellipce";
            this.fillEllipceToolStripMenuItem.Click += new System.EventHandler(this.fillEllipceToolStripMenuItem_Click);
            // 
            // fillRetangleToolStripMenuItem
            // 
            this.fillRetangleToolStripMenuItem.Name = "fillRetangleToolStripMenuItem";
            this.fillRetangleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fillRetangleToolStripMenuItem.Text = "Fill retangle";
            this.fillRetangleToolStripMenuItem.Click += new System.EventHandler(this.fillRetangleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 321);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFigureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LineToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peintsColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brushsColorToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox listBoxLayer;
        private System.Windows.Forms.ListBox listBoxFigure;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem fillEllipceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillRetangleToolStripMenuItem;
    }
}

