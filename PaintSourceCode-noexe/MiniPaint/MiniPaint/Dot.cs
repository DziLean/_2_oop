using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop_2
{
    public class Dot : Figure
    {        
        public Dot(int x, int y):base(x , y)
        {            
            
        }
        public override void Draw()
        {
            //Console.WriteLine("Dot:({0},{1})", X, Y);
        }
    }
}
