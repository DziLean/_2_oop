using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace _2_oop
{
    public abstract class Figure
    {
        private int _x;
        private int _y;
        public int x
        {
            get
            {
                return this._x;
            }
            private set
            {                
                if (value <= 0)
                    throw new Exception("Invalid parameter: less than zero!");
                this.x = value;
            }
        }
        public int y
        {
            get
            {
                return this._y;
            }
            private set
            {
                if (value <= 0)
                    throw new Exception("Invalid parameter: less than zero!");
                this.y = value;
            }
        }
        protected Figure(int x, int y)
        {
            x = _x;
            y = _y;
        }             
    }
    public interface Painter
    {
        void Draw();
    }
}
