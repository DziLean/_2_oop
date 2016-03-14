using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2_oop
{
    class RectangleBuider : Painter //fabric of classes
    {
        void Draw(Rectangle rect, MouseEventArgs e, int length, int height)
        {
            Form1.g.FillRectangle(Form1.sb, e.X, e.Y, e.X + length, e.Y + height);
        }

        void Painter.Draw(Figure rect, MouseEventArgs e, int length, int height)
        {

        }
    }
    class CircleBuider : Painter //fabric of classes
    {
        void Draw(Circle rect, MouseEventArgs e, int length, int height)
        {
            Form1.g.FillEllipse(Form1.sb, e.X, e.Y, length, length);
        }

        void Painter.Draw(Figure rect, MouseEventArgs e, int length, int height)
        {

        }
    }
    class EllipseBuilder : Painter //fabric of classes
    {
        void Draw(Ellipse rect, MouseEventArgs e, int length, int height)
        {
            Form1.g.FillEllipse(Form1.sb, e.X, e.Y, length, height);
        }

        void Painter.Draw(Figure rect, MouseEventArgs e, int length, int height)
        {

        }
    }
    class DotBuider : Painter //fabric of classes
    {
        void Draw(Dot rect, MouseEventArgs e, int length, int height)
        {
            Form1.g.FillRectangle(Form1.sb, e.X, e.Y, e.X + length, e.Y + height);
        }

        void Painter.Draw(Figure rect, MouseEventArgs e, int length, int height)
        {

        }
    }
    class LineBuilder : Painter //fabric of classes
    {
        void Draw(Line rect, MouseEventArgs e, int length, int height)
        {
            Form1.g.FillRectangle(Form1.sb, e.X, e.Y, e.X + length, e.Y + height);
        }

        void Painter.Draw(Figure rect, MouseEventArgs e, int length, int height)
        {

        }
    }
    class TriangleBuilder : Painter
    {
        void Draw(Triangle rect, MouseEventArgs e, int length, int height)
        {
            Form1.g.FillRectangle(Form1.sb, e.X, e.Y, e.X + length, e.Y + height);
        }

        void Painter.Draw(Figure rect, MouseEventArgs e, int length, int height)
        {

        }
    }
    public partial  class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();
            g = pnl_Draw.CreateGraphics();
            startPaint = false;        
            initX = 0;
            initY = 0;
            drawEllipse = false;
            drawRectangle = false;
            drawCircle = false;
            sb = new SolidBrush(btn_PenColor.BackColor);
            RectangleBuider RB = new RectangleBuider();
            TriangleBuilder TB = new TriangleBuilder();
            DotBuider DB = new DotBuider();
            LineBuilder LB = new LineBuilder();
            EllipseBuilder EB = new EllipseBuilder();
            CircleBuilder CB = new CircleBuilder();
        }
        public bool startPaint {get;set;}
        public static Graphics g { get;set; }    
        public int initX { get;set; }
        public int initY { get;set; }
        public bool drawEllipse { get;set; }
        public bool drawRectangle { get;set; }
        public bool drawCircle { get;set; }
        public static SolidBrush sb { get; set; }
        private void pnl_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if(startPaint)
            {
                Pen p = new Pen(btn_PenColor.BackColor,2);                     
                g.DrawLine(p, new Point(e.X,e.Y), new Point(e.X, e.Y));                
            }
        }        
        private void pnl_Draw_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                startPaint = true;
                if (drawEllipse)
                {             
                                     
                }
                if (drawRectangle)
                {                                      
                    
                }
                if (drawCircle)
                {                    
                                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid arguments!");
            }
        }        
        private void pnl_Draw_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = 0;
            initY = 0;
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if(c.ShowDialog()==DialogResult.OK)
            {
                btn_PenColor.BackColor = c.Color;
            }
        } 
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            g.Clear(pnl_Draw.BackColor);
            pnl_Draw.BackColor = Color.White;
            btn_CanvasColor.BackColor = Color.White;
        }
        private void btn_CanvasColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if(c.ShowDialog()==DialogResult.OK)
            {
                pnl_Draw.BackColor = c.Color;
                btn_CanvasColor.BackColor = c.Color;
            }
        }
        private void btn_Square_Click(object sender, EventArgs e)
        {
            drawEllipse = true;
            drawRectangle = false;
            drawCircle = false;
        }
        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            drawEllipse = false;
            drawRectangle = true;
            drawCircle = false;
        }
        private void btn_Circle_Click(object sender, EventArgs e)
        {
            drawEllipse = false;
            drawRectangle = false;
            drawCircle = true;
        }        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to Exit?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }    
}
