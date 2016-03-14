using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace _2_oop
{
    class RectangleBuider : Painter //fabric of classes
    {
        public void Draw(Rectangle rect)
        {
            Form1.g.FillRectangle(Form1.sb, rect.x, rect.y, rect.a, rect.b);
        }
        void Painter.Draw()
        {

        }
    }
    class CircleBuilder : Painter //fabric of classes
    {
        public void Draw(Circle circle)
        {
            Form1.g.FillEllipse(Form1.sb, circle.x, circle.y, circle.R, circle.R);
        }
        void Painter.Draw()
        {

        }
    }
    class EllipseBuilder : Painter //fabric of classes
    {
        public void Draw(Ellipse ellipse)
        {
            Form1.g.FillEllipse(Form1.sb, ellipse.x, ellipse.y, ellipse.a, ellipse.b);
        }
        void Painter.Draw()
        {

        }
    }
    class DotBuider : Painter //fabric of classes
    {
        public void Draw(Dot dot)
        {
            Form1.g.FillRectangle(Form1.sb, dot.x, dot.y,3,3);
        }

        void Painter.Draw()
        {

        }
    }
    class LineBuilder : Painter //fabric of classes
    {
        public void Draw(Line line)
        {
            Form1.g.FillRectangle(Form1.sb, line.x, line.y, line.x2, line.y2 );
        }

        void Painter.Draw()
        {

        }
    }
    class TriangleBuilder : Painter
    {
        public void Draw(Triangle triangle)
        {
            Form1.g.DrawLine(new Pen(Form1.sb,2), new Point(triangle.x, triangle.y), new Point(triangle.x2, triangle.y2));
            Form1.g.DrawLine(new Pen(Form1.sb, 2), new Point(triangle.x2, triangle.y2), new Point(triangle.x3, triangle.y3));
            Form1.g.DrawLine(new Pen(Form1.sb, 2), new Point(triangle.x3, triangle.y3), new Point(triangle.x, triangle.y));
        }

        void Painter.Draw()
        {

        }
    }
}
