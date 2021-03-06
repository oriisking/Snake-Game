﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Fruit
    {
        private Point fruit;
        private Random rnd = new Random();
        //בונאי של פרי המציב אותו במקום רנדומאלי
        public Fruit()
        {
            this.fruit = new Point(rnd.Next(1,81),rnd.Next(1,26));
        }
        //פעולה שמשנה את מיקום הפרי
        public void setLocation()
        {
            this.fruit.setX(rnd.Next(1, 81));
            this.fruit.setY(rnd.Next(1, 26));
        }
        //בודק אם ראש הנחש נמצא באותו המיקום של הפרי
        public bool checkIfIsOnFruit(Snake snk)
        {
            if (snk.getHead().isEqual(this.fruit))
                return true;
            return false;            
        }
    }
}
