using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_oop
{
    public class Circle : Figure
    {
        public int R { get; set; }
        public Circle(int x, int y, int r):base(x,y)
        {           
            R = r;
        }        
    }
}
