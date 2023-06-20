

namespace BuildGraphics
{
    partial class Graph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graph));
            this.leftpanel = new System.Windows.Forms.Panel();
            this.namemove = new System.Windows.Forms.TextBox();
            this.nameofMoving = new System.Windows.Forms.Label();
            this.moveOY = new System.Windows.Forms.TextBox();
            this.labelforcolor = new System.Windows.Forms.Label();
            this.Movegraph = new System.Windows.Forms.Button();
            this.moveOX = new System.Windows.Forms.TextBox();
            this.MoveY = new System.Windows.Forms.Label();
            this.MoveX = new System.Windows.Forms.Label();
            this.panelwithcolors = new System.Windows.Forms.Panel();
            this.btnPurple = new System.Windows.Forms.Button();
            this.btnDeepSkyBlue = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnDarkorange = new System.Windows.Forms.Button();
            this.btnMaroon = new System.Windows.Forms.Button();
            this.panelogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CreateGraphBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.nameOfGraph = new System.Windows.Forms.TextBox();
            this.agreebtn = new System.Windows.Forms.Button();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.pictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.groupofLegends = new System.Windows.Forms.GroupBox();
            this.leftpanel.SuspendLayout();
            this.panelwithcolors.SuspendLayout();
            this.panelogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            this.leftpanel.Controls.Add(this.namemove);
            this.leftpanel.Controls.Add(this.nameofMoving);
            this.leftpanel.Controls.Add(this.moveOY);
            this.leftpanel.Controls.Add(this.labelforcolor);
            this.leftpanel.Controls.Add(this.Movegraph);
            this.leftpanel.Controls.Add(this.moveOX);
            this.leftpanel.Controls.Add(this.MoveY);
            this.leftpanel.Controls.Add(this.MoveX);
            this.leftpanel.Controls.Add(this.panelwithcolors);
            this.leftpanel.Controls.Add(this.panelogo);
            this.leftpanel.Controls.Add(this.CreateGraphBtn);
            this.leftpanel.Controls.Add(this.ClearBtn);
            this.leftpanel.Controls.Add(this.nameOfGraph);
            this.leftpanel.Controls.Add(this.agreebtn);
            this.leftpanel.Controls.Add(this.OpenFileBtn);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Margin = new System.Windows.Forms.Padding(4);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(348, 760);
            this.leftpanel.TabIndex = 0;
            // 
            // namemove
            // 
            this.namemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namemove.Location = new System.Drawing.Point(148, 558);
            this.namemove.Name = "namemove";
            this.namemove.Size = new System.Drawing.Size(175, 26);
            this.namemove.TabIndex = 16;
            // 
            // nameofMoving
            // 
            this.nameofMoving.AutoSize = true;
            this.nameofMoving.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameofMoving.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameofMoving.Location = new System.Drawing.Point(3, 558);
            this.nameofMoving.Name = "nameofMoving";
            this.nameofMoving.Size = new System.Drawing.Size(130, 20);
            this.nameofMoving.TabIndex = 15;
            this.nameofMoving.Text = "Graph for move:";
            // 
            // moveOY
            // 
            this.moveOY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveOY.Location = new System.Drawing.Point(148, 643);
            this.moveOY.Name = "moveOY";
            this.moveOY.Size = new System.Drawing.Size(175, 26);
            this.moveOY.TabIndex = 18;
            // 
            // labelforcolor
            // 
            this.labelforcolor.AutoSize = true;
            this.labelforcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforcolor.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelforcolor.Location = new System.Drawing.Point(144, 236);
            this.labelforcolor.Name = "labelforcolor";
            this.labelforcolor.Size = new System.Drawing.Size(54, 20);
            this.labelforcolor.TabIndex = 17;
            this.labelforcolor.Text = "Color";
            this.labelforcolor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Movegraph
            // 
            this.Movegraph.FlatAppearance.BorderSize = 0;
            this.Movegraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movegraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movegraph.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Movegraph.Location = new System.Drawing.Point(3, 687);
            this.Movegraph.Name = "Movegraph";
            this.Movegraph.Size = new System.Drawing.Size(340, 43);
            this.Movegraph.TabIndex = 16;
            this.Movegraph.Text = "Move";
            this.Movegraph.UseVisualStyleBackColor = true;
            this.Movegraph.Click += new System.EventHandler(this.Movegraph_Click);
            // 
            // moveOX
            // 
            this.moveOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveOX.Location = new System.Drawing.Point(147, 600);
            this.moveOX.Name = "moveOX";
            this.moveOX.Size = new System.Drawing.Size(175, 26);
            this.moveOX.TabIndex = 14;
            // 
            // MoveY
            // 
            this.MoveY.AutoSize = true;
            this.MoveY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MoveY.Location = new System.Drawing.Point(33, 645);
            this.MoveY.Name = "MoveY";
            this.MoveY.Size = new System.Drawing.Size(37, 20);
            this.MoveY.TabIndex = 13;
            this.MoveY.Text = "OY:";
            // 
            // MoveX
            // 
            this.MoveX.AutoSize = true;
            this.MoveX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MoveX.Location = new System.Drawing.Point(29, 599);
            this.MoveX.Name = "MoveX";
            this.MoveX.Size = new System.Drawing.Size(38, 20);
            this.MoveX.TabIndex = 12;
            this.MoveX.Text = "OX:";
            // 
            // panelwithcolors
            // 
            this.panelwithcolors.Controls.Add(this.btnPurple);
            this.panelwithcolors.Controls.Add(this.btnDeepSkyBlue);
            this.panelwithcolors.Controls.Add(this.btnBlue);
            this.panelwithcolors.Controls.Add(this.btnGreen);
            this.panelwithcolors.Controls.Add(this.btnDarkorange);
            this.panelwithcolors.Controls.Add(this.btnMaroon);
            this.panelwithcolors.Location = new System.Drawing.Point(4, 273);
            this.panelwithcolors.Name = "panelwithcolors";
            this.panelwithcolors.Size = new System.Drawing.Size(340, 167);
            this.panelwithcolors.TabIndex = 11;
            // 
            // btnPurple
            // 
            this.btnPurple.BackColor = System.Drawing.Color.Purple;
            this.btnPurple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurple.Location = new System.Drawing.Point(250, 93);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(50, 50);
            this.btnPurple.TabIndex = 5;
            this.btnPurple.UseVisualStyleBackColor = false;
            this.btnPurple.Click += new System.EventHandler(this.btnMaroon_Click);
            // 
            // btnDeepSkyBlue
            // 
            this.btnDeepSkyBlue.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeepSkyBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeepSkyBlue.Location = new System.Drawing.Point(50, 93);
            this.btnDeepSkyBlue.Name = "btnDeepSkyBlue";
            this.btnDeepSkyBlue.Size = new System.Drawing.Size(50, 50);
            this.btnDeepSkyBlue.TabIndex = 4;
            this.btnDeepSkyBlue.UseVisualStyleBackColor = false;
            this.btnDeepSkyBlue.Click += new System.EventHandler(this.btnMaroon_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.Location = new System.Drawing.Point(150, 93);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(50, 50);
            this.btnBlue.TabIndex = 3;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnMaroon_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.Location = new System.Drawing.Point(250, 18);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(50, 50);
            this.btnGreen.TabIndex = 2;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnMaroon_Click);
            // 
            // btnDarkorange
            // 
            this.btnDarkorange.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDarkorange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarkorange.Location = new System.Drawing.Point(150, 18);
            this.btnDarkorange.Name = "btnDarkorange";
            this.btnDarkorange.Size = new System.Drawing.Size(50, 50);
            this.btnDarkorange.TabIndex = 1;
            this.btnDarkorange.UseVisualStyleBackColor = false;
            this.btnDarkorange.Click += new System.EventHandler(this.btnMaroon_Click);
            // 
            // btnMaroon
            // 
            this.btnMaroon.BackColor = System.Drawing.Color.Maroon;
            this.btnMaroon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaroon.Location = new System.Drawing.Point(50, 18);
            this.btnMaroon.Name = "btnMaroon";
            this.btnMaroon.Size = new System.Drawing.Size(50, 50);
            this.btnMaroon.TabIndex = 0;
            this.btnMaroon.UseVisualStyleBackColor = false;
            this.btnMaroon.Click += new System.EventHandler(this.btnMaroon_Click);
            // 
            // panelogo
            // 
            this.panelogo.Controls.Add(this.pictureBox1);
            this.panelogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelogo.Location = new System.Drawing.Point(0, 0);
            this.panelogo.Name = "panelogo";
            this.panelogo.Size = new System.Drawing.Size(348, 100);
            this.panelogo.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CreateGraphBtn
            // 
            this.CreateGraphBtn.FlatAppearance.BorderSize = 0;
            this.CreateGraphBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateGraphBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateGraphBtn.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.CreateGraphBtn.Location = new System.Drawing.Point(4, 447);
            this.CreateGraphBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateGraphBtn.Name = "CreateGraphBtn";
            this.CreateGraphBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CreateGraphBtn.Size = new System.Drawing.Size(340, 40);
            this.CreateGraphBtn.TabIndex = 8;
            this.CreateGraphBtn.Text = "Create graphic";
            this.CreateGraphBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateGraphBtn.UseVisualStyleBackColor = true;
            this.CreateGraphBtn.Click += new System.EventHandler(this.CreateGraphBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ClearBtn.Location = new System.Drawing.Point(4, 499);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ClearBtn.Size = new System.Drawing.Size(340, 40);
            this.ClearBtn.TabIndex = 7;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // nameOfGraph
            // 
            this.nameOfGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfGraph.Location = new System.Drawing.Point(13, 175);
            this.nameOfGraph.Margin = new System.Windows.Forms.Padding(4);
            this.nameOfGraph.Name = "nameOfGraph";
            this.nameOfGraph.Size = new System.Drawing.Size(193, 26);
            this.nameOfGraph.TabIndex = 6;
            this.nameOfGraph.Text = "Name of graph";
            // 
            // agreebtn
            // 
            this.agreebtn.FlatAppearance.BorderSize = 0;
            this.agreebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agreebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreebtn.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.agreebtn.Location = new System.Drawing.Point(222, 172);
            this.agreebtn.Margin = new System.Windows.Forms.Padding(4);
            this.agreebtn.Name = "agreebtn";
            this.agreebtn.Size = new System.Drawing.Size(100, 30);
            this.agreebtn.TabIndex = 1;
            this.agreebtn.Text = "Ok";
            this.agreebtn.UseVisualStyleBackColor = true;
            this.agreebtn.Click += new System.EventHandler(this.agreebtn_Click);
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.FlatAppearance.BorderSize = 0;
            this.OpenFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFileBtn.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.OpenFileBtn.Location = new System.Drawing.Point(4, 107);
            this.OpenFileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.OpenFileBtn.Size = new System.Drawing.Size(340, 47);
            this.OpenFileBtn.TabIndex = 0;
            this.OpenFileBtn.Text = "Open";
            this.OpenFileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // pictureBoxGraph
            // 
            this.pictureBoxGraph.Location = new System.Drawing.Point(355, 0);
            this.pictureBoxGraph.Name = "pictureBoxGraph";
            this.pictureBoxGraph.Size = new System.Drawing.Size(946, 560);
            this.pictureBoxGraph.TabIndex = 1;
            this.pictureBoxGraph.TabStop = false;
            // 
            // groupofLegends
            // 
            this.groupofLegends.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupofLegends.Location = new System.Drawing.Point(355, 589);
            this.groupofLegends.Name = "groupofLegends";
            this.groupofLegends.Size = new System.Drawing.Size(946, 119);
            this.groupofLegends.TabIndex = 2;
            this.groupofLegends.TabStop = false;
            this.groupofLegends.Text = "Legends";
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1314, 760);
            this.Controls.Add(this.groupofLegends);
            this.Controls.Add(this.pictureBoxGraph);
            this.Controls.Add(this.leftpanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Graph";
            this.RightToLeftLayout = true;
            this.Text = "Graph";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.panelwithcolors.ResumeLayout(false);
            this.panelogo.ResumeLayout(false);
            this.panelogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.Button agreebtn;
        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.TextBox nameOfGraph;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button CreateGraphBtn;
        private System.Windows.Forms.Panel panelogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelwithcolors;
        private System.Windows.Forms.Button btnPurple;
        private System.Windows.Forms.Button btnDeepSkyBlue;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnDarkorange;
        private System.Windows.Forms.Button btnMaroon;
        private System.Windows.Forms.PictureBox pictureBoxGraph;
        private System.Windows.Forms.TextBox moveOX;
        private System.Windows.Forms.Label MoveY;
        private System.Windows.Forms.Label MoveX;
        private System.Windows.Forms.Button Movegraph;
        private System.Windows.Forms.Label labelforcolor;
        private System.Windows.Forms.TextBox moveOY;
        private System.Windows.Forms.TextBox namemove;
        private System.Windows.Forms.Label nameofMoving;
        private System.Windows.Forms.GroupBox groupofLegends;
    }
}

