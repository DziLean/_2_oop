using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_oop
{
    public class Rectangle : Figure
    {        
        public int a { get; set; }
        public int b { get; set; }
        public Rectangle(int x1, int y1,int x2, int y2):base(x1,y1)
        {                   
            this.a = x2;
            this.b = y2;
        }       
    }
}
