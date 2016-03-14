using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    class CircleBuilder : Painter //fabric of classes
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
}
