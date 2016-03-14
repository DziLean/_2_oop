using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _2_oop
{
    public class Triangle : Figure
    {
        private int rightX;
        private int rightY;
        private int upX;
        private int upY;
        public Triangle(int xl, int yl, int xr, int yr, int xu, int yu)
            : base(xl, yl)
        {
            rightX = xr;
            rightY = yr;
            upX = xu;
            upY = yu;
        }
    }
}
