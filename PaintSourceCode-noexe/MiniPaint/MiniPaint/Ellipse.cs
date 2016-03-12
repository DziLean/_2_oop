using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop_2
{
    public class Ellipse : Figure
    {
        private int a;
        private int b;
        public Ellipse(int a, int b, int x, int y)
            : base(x, y)
        {
            this.a = a;
            this.b = b;           
        }
        public override void Draw()
        {
            //Console.WriteLine("Ellipse:({0},{1},{2},{3})", a, b, X, Y);
        }
    }
}
