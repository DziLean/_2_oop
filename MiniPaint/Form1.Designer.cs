namespace _2_oop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Draw = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_Rectangle = new System.Windows.Forms.Button();
            this.btn_Ellipse = new System.Windows.Forms.Button();
            this.btn_Triangle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.tby3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Line = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tby2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tby = new System.Windows.Forms.TextBox();
            this.tbx = new System.Windows.Forms.TextBox();
            this.btn_Dot = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_CanvasColor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.coords = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnl_Draw.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.pnl_Draw);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 433);
            this.panel1.TabIndex = 0;
            // 
            // pnl_Draw
            // 
            this.pnl_Draw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_Draw.Controls.Add(this.coords);
            this.pnl_Draw.Location = new System.Drawing.Point(0, 0);
            this.pnl_Draw.Name = "pnl_Draw";
            this.pnl_Draw.Size = new System.Drawing.Size(602, 430);
            this.pnl_Draw.TabIndex = 2;
            this.pnl_Draw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Draw_Paint);
            this.pnl_Draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseDown);
            this.pnl_Draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseMove);
            this.pnl_Draw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseUp);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumPurple;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(602, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(141, 27);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Canvas Color";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btn_Rectangle);
            this.panel7.Controls.Add(this.btn_Ellipse);
            this.panel7.Controls.Add(this.btn_Triangle);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.btn_Circle);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.tbx3);
            this.panel7.Controls.Add(this.tby3);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.btn_Line);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.tbx2);
            this.panel7.Controls.Add(this.tby2);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.tby);
            this.panel7.Controls.Add(this.tbx);
            this.panel7.Controls.Add(this.btn_Dot);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.b);
            this.panel7.Controls.Add(this.a);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(603, 66);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(141, 364);
            this.panel7.TabIndex = 3;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rectangle.Location = new System.Drawing.Point(-2, 250);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.Size = new System.Drawing.Size(141, 36);
            this.btn_Rectangle.TabIndex = 6;
            this.btn_Rectangle.Text = "Rectangle";
            this.btn_Rectangle.UseVisualStyleBackColor = false;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // btn_Ellipse
            // 
            this.btn_Ellipse.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Ellipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ellipse.Location = new System.Drawing.Point(-1, 210);
            this.btn_Ellipse.Name = "btn_Ellipse";
            this.btn_Ellipse.Size = new System.Drawing.Size(141, 34);
            this.btn_Ellipse.TabIndex = 5;
            this.btn_Ellipse.Text = "Ellipse";
            this.btn_Ellipse.UseVisualStyleBackColor = false;
            this.btn_Ellipse.Click += new System.EventHandler(this.btn_Ellipse_Click);
            // 
            // btn_Triangle
            // 
            this.btn_Triangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Triangle.Location = new System.Drawing.Point(-1, 150);
            this.btn_Triangle.Name = "btn_Triangle";
            this.btn_Triangle.Size = new System.Drawing.Size(141, 28);
            this.btn_Triangle.TabIndex = 18;
            this.btn_Triangle.Text = "Triagle";
            this.btn_Triangle.UseVisualStyleBackColor = true;
            this.btn_Triangle.Click += new System.EventHandler(this.btn_Triangle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "x3";
            // 
            // btn_Circle
            // 
            this.btn_Circle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Circle.Location = new System.Drawing.Point(-1, 292);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(141, 36);
            this.btn_Circle.TabIndex = 7;
            this.btn_Circle.Text = "Circle";
            this.btn_Circle.UseVisualStyleBackColor = false;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "y3";
            // 
            // tbx3
            // 
            this.tbx3.Location = new System.Drawing.Point(-2, 126);
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(47, 20);
            this.tbx3.TabIndex = 29;
            // 
            // tby3
            // 
            this.tby3.Location = new System.Drawing.Point(92, 126);
            this.tby3.Name = "tby3";
            this.tby3.Size = new System.Drawing.Size(47, 20);
            this.tby3.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "x";
            // 
            // btn_Line
            // 
            this.btn_Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Line.Location = new System.Drawing.Point(-1, 98);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(141, 23);
            this.btn_Line.TabIndex = 17;
            this.btn_Line.Text = "Line";
            this.btn_Line.UseVisualStyleBackColor = true;
            this.btn_Line.Click += new System.EventHandler(this.btn_Line_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 26;
            this.label9.Tag = "";
            this.label9.Text = "x2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 25;
            this.label8.Tag = "";
            this.label8.Text = "y2";
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(-2, 72);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(48, 20);
            this.tbx2.TabIndex = 24;
            // 
            // tby2
            // 
            this.tby2.Location = new System.Drawing.Point(92, 72);
            this.tby2.Name = "tby2";
            this.tby2.Size = new System.Drawing.Size(46, 20);
            this.tby2.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "y";
            // 
            // tby
            // 
            this.tby.Location = new System.Drawing.Point(92, 28);
            this.tby.Name = "tby";
            this.tby.Size = new System.Drawing.Size(49, 20);
            this.tby.TabIndex = 20;
            // 
            // tbx
            // 
            this.tbx.Location = new System.Drawing.Point(-2, 28);
            this.tbx.Name = "tbx";
            this.tbx.Size = new System.Drawing.Size(48, 20);
            this.tbx.TabIndex = 19;
            // 
            // btn_Dot
            // 
            this.btn_Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Dot.Location = new System.Drawing.Point(-2, 50);
            this.btn_Dot.Name = "btn_Dot";
            this.btn_Dot.Size = new System.Drawing.Size(142, 22);
            this.btn_Dot.TabIndex = 16;
            this.btn_Dot.Text = "Dot";
            this.btn_Dot.UseVisualStyleBackColor = true;
            this.btn_Dot.Click += new System.EventHandler(this.btn_Dot_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "b";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "a";
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(91, 184);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(47, 20);
            this.b.TabIndex = 12;
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(-2, 184);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(48, 20);
            this.a.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MediumPurple;
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(-1, -1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(141, 27);
            this.panel8.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Draw Figure";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_CanvasColor);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(603, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 60);
            this.panel2.TabIndex = 1;
            // 
            // btn_CanvasColor
            // 
            this.btn_CanvasColor.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CanvasColor.Location = new System.Drawing.Point(-3, 27);
            this.btn_CanvasColor.Name = "btn_CanvasColor";
            this.btn_CanvasColor.Size = new System.Drawing.Size(143, 32);
            this.btn_CanvasColor.TabIndex = 4;
            this.btn_CanvasColor.UseVisualStyleBackColor = false;
            this.btn_CanvasColor.Click += new System.EventHandler(this.btn_CanvasColor_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(-1, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 100);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 28);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(4, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "1";
            // 
            // button2
            // 
            this.button2.Image = global::_2_oop.Properties.Resources.pencil;
            this.button2.Location = new System.Drawing.Point(4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = "Pen Tool";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // coords
            // 
            this.coords.Location = new System.Drawing.Point(529, 0);
            this.coords.Multiline = true;
            this.coords.Name = "coords";
            this.coords.Size = new System.Drawing.Size(73, 31);
            this.coords.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 451);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Paint ";
            this.panel1.ResumeLayout(false);
            this.pnl_Draw.ResumeLayout(false);
            this.pnl_Draw.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Draw;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_CanvasColor;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Ellipse;
        private System.Windows.Forms.Button btn_Triangle;
        private System.Windows.Forms.Button btn_Line;
        private System.Windows.Forms.Button btn_Dot;
        private System.Windows.Forms.TextBox tby;
        private System.Windows.Forms.TextBox tbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx3;
        private System.Windows.Forms.TextBox tby3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.TextBox tby2;
        private System.Windows.Forms.TextBox coords;
    }
}

