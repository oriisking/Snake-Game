using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Snake
    {
        private List<Point> Nodes;
        public Snake()
        {
            Random rnd = new Random();
            Point head = new Point(rnd.Next(1,81),rnd.Next(1,26));
            this.Nodes.Add(head);
        }
        public List<Point> getBuddy()
        {
            return this.Nodes;
        }
    }
}
