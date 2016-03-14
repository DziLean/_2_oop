using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_oop
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
    }
}
