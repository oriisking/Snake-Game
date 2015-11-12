using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Fruit
    {
        private Point fruit;
        private Random rnd = new Random();
        public Fruit()
        {
            this.fruit = new Point(rnd.Next(1,81),rnd.Next(1,26));
        }
        public void setLocation()
        {
            this.fruit.setX(rnd.Next(1, 81));
            this.fruit.setY(rnd.Next(1, 26));
        }
        public bool checkIfIsOnFruit(Snake snk)
        {
            if (snk.getBuddy().First<Point>().isEqual(this.fruit))
                return true;
            return false;
            
        }
    }
}
