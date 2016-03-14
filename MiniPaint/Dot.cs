using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_oop
{
    public class Dot : Figure
    {        
        public int x { get; set; }
        public int y { get; set; }
        public Dot(int x, int y):base(x , y)
        {            
            
        }        
    }
}
