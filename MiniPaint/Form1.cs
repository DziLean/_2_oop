using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2_oop
{
    public partial class Form1 : Form
    {
        public static abstract class Factory
        {
            public void CreateFigure(string figure)
            {

                if (figure == "rectangle")
                {
                    //Use Solid Brush for filling the graphic shapes
                    SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
                    //setting the width and height same for creating square.
                    //Getting the width and Heigt value from Textbox(txt_ShapeSize)
                    g.FillEllipse(sb, e.X, e.Y, int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                    //setting startPaint and drawSquare value to false for creating one graphic on one click.
                    //startPaint = false;
                    //drawSquare = false;
                }
                if (figure == "circle")
                {
                    SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
                    //setting the width twice of the height
                    g.FillRectangle(sb, e.X, e.Y, e.X + int.Parse(textBox2.Text), e.Y + int.Parse(textBox3.Text));
                    //startPaint = false;
                    //drawRectangle = false;
                }
                if (figure == "ellipse")
                {
                    SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
                    g.FillEllipse(sb, e.X, e.Y, int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                    //startPaint = false;
                    //drawCircle = false;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            g = pnl_Draw.CreateGraphics();
        }
        bool startPaint = false;
        Graphics g;
        //nullable int for storing Null value
        int? initX = null;
        int? initY = null;
        bool drawEllipse = false;
        bool drawRectangle = false;
        bool drawCircle = false;
        //Event fired when the mouse pointer is moved over the Panel(pnl_Draw).
        private void pnl_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if(startPaint)
            {
                //Setting the Pen BackColor and line Width
                Pen p = new Pen(btn_PenColor.BackColor,2);
                //Drawing the line.
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
            }
        }
        //Event Fired when the mouse pointer is over Panel and a mouse button is pressed
        private void pnl_Draw_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                startPaint = true;
                if (drawEllipse)
                {
                    //Use Solid Brush for filling the graphic shapes
                    SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
                    //setting the width and height same for creating square.
                    //Getting the width and Heigt value from Textbox(txt_ShapeSize)
                    g.FillEllipse(sb, e.X, e.Y, int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                    //setting startPaint and drawSquare value to false for creating one graphic on one click.
                    //startPaint = false;
                    //drawSquare = false;
                }
                if (drawRectangle)
                {
                    SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
                    //setting the width twice of the height
                    g.FillRectangle(sb, e.X, e.Y, e.X + int.Parse(textBox2.Text), e.Y + int.Parse(textBox3.Text));
                    //startPaint = false;
                    //drawRectangle = false;
                }
                if (drawCircle)
                {
                    SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
                    g.FillEllipse(sb, e.X, e.Y, int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                    //startPaint = false;
                    //drawCircle = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid arguments!");
            }
        }
        //Fired when the mouse pointer is over the pnl_Draw and a mouse button is released.
        private void pnl_Draw_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }
        //Button for Setting pen Color
        private void button1_Click(object sender, EventArgs e)
        {
            //Open Color Dialog and Set BackColor of btn_PenColor if user click on OK
            ColorDialog c = new ColorDialog();
            if(c.ShowDialog()==DialogResult.OK)
            {
                btn_PenColor.BackColor = c.Color;
            }
        }
        //New 
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clearing the graphics from the Panel(pnl_Draw)
            g.Clear(pnl_Draw.BackColor);
            //Setting the BackColor of pnl_draw and btn_CanvasColor to White on Clicking New under File Menu
            pnl_Draw.BackColor = Color.White;
            btn_CanvasColor.BackColor = Color.White;
        }
       //Setting the Canvas Color
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
        //Exit under File Menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to Exit?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //About under Help Menu
        private void aboutMiniPaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Draw_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_ShapeSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
