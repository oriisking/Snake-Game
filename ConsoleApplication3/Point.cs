using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Point
    {
        private int X;
        private int Y;
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public void setX(int x)
        {
            this.X = x;
        }

        public void setY(int y)
        {
            this.Y = y;
        }

        public int getX()
        {
            return this.X;
        }
        public int getY()
        {
            return this.Y;
        }
        public bool isEqual(Point p)
        {
            if (this.X == p.getX() && this.Y == p.getY())
                return true;
            return false;
            

        }
    }
}
