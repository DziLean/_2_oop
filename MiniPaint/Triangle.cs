using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _2_oop
{
    public class Triangle : Figure
    {
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int x3 { get; set; }
        public int y3 { get; set; }
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
            : base(x1, y1)
        {
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }
    }
}
