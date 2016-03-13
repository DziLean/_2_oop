using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop_2
{
    public class Circle : Figure
    {     
        private int R;
        public Circle(int x, int y, int r):base(x,y)
        {           
            R = r;
        }
        public override void Draw()
        {
            
        }
    }
}
