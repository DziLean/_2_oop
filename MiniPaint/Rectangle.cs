using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_oop
{
    public class Rectangle : Figure
    {        
        private int rightX;
        private int rightY;
        public Rectangle(int xl, int yl,int xr, int yr):base(xl,yl)
        {                   
            rightX = xr;
            rightY = yr;
        }       
    }
}
