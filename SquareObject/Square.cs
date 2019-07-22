using System;
using System.Collections.Generic;
using System.Text;

namespace SquareObjects
{
    class Square
    {
        private int side;
        private int area;

        public Square(int side)
        {
            this.side = side;
            //this.area = area;
            calcArea();
        }

        private void calcArea()
        {
            this.area = side * side;
        }
        public int Side
        {
            get
            {
                return side;
            }
        }
        public int Area
        {
            get
            {
                return area;
            }
        }
    }
}
