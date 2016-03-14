using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2_oop
{
    
    public partial  class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();
            g = pnl_Draw.CreateGraphics();
            startPaint = false;        
            initX = 0;
            initY = 0;
            figure = null;
            sb = new SolidBrush(btn_PenColor.BackColor);
            RB = new RectangleBuider();
            TB = new TriangleBuilder();
            DB = new DotBuider();
            LB = new LineBuilder();
            EB = new EllipseBuilder();
            CB = new CircleBuilder();
            drawEllipse = false;
            drawRectangle  = false;
            drawCircle  = false;
            drawLine  = false;
            drawDot  = false;
            drawTriangle = false;
        }
        Figure figure {get;set;}
        public bool startPaint {get;set;}
        public static Graphics g { get;set; }    
        public int initX { get;set; }
        public int initY { get;set; }
        public bool drawEllipse { get;set; }
        public bool drawRectangle { get;set; }
        public bool drawCircle { get;set; }
        public bool drawLine { get; set; }
        public bool drawDot { get; set; }
        public bool drawTriangle { get; set; }
        public static SolidBrush sb { get; set; }
        RectangleBuider RB;
        TriangleBuilder TB;
        DotBuider DB;
        LineBuilder LB;
        EllipseBuilder EB;
        CircleBuilder CB;
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
                
                if (drawEllipse)
                {
                    Ellipse ellipse = new Ellipse(e.X, e.Y, int.Parse(textBox2.Text.ToString().Trim()), int.Parse(textBox3.Text.ToString().Trim()));
                    EB.Draw(ellipse);
                }
                if (drawRectangle)
                {                                      
                    
                }
                if (drawCircle)
                {                   
                
                }
                if (drawDot)
                {

                }
                if (drawLine)
                {

                }
                if (drawTriangle)
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
        private void btn_Ellipse_Click(object sender, EventArgs e)
        {
            drawEllipse = true;
            drawRectangle = false;
            drawCircle = false;
            drawLine = false;
            drawDot = false;
            drawTriangle = false;
        }
        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            drawEllipse = false;
            drawRectangle = true;
            drawCircle = false;
            drawLine = false;
            drawDot = false;
            drawTriangle = false;
        }
        private void btn_Circle_Click(object sender, EventArgs e)
        {
            drawEllipse = false;
            drawRectangle = false;
            drawCircle = true;
            drawLine = false;
            drawDot = false;
            drawTriangle = false;
        }       
        
        private void pnl_Draw_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Dot_Click(object sender, EventArgs e)
        {
            drawEllipse = false;
            drawRectangle = false;
            drawCircle = true;
            drawLine = false;
            drawDot = true;
            drawTriangle = false;
        }

        private void btn_Line_Click(object sender, EventArgs e)
        {
            drawEllipse = false;
            drawRectangle = false;
            drawCircle = true;
            drawLine = true;
            drawDot = false;
            drawTriangle = false;
        }

        private void btn_Triangle_Click(object sender, EventArgs e)
        {
            drawEllipse = false;
            drawRectangle = false;
            drawCircle = false;
            drawLine = false;
            drawDot = false;
            drawTriangle = true;
        }
    }    
}
