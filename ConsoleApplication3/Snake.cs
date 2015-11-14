using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Snake
    {
        private List<Point> Nodes = new List<Point>();
        private direction dir2 = new direction();
        private bool isAlive;
        private Point lastNode;
        //בונה נחש ריק בו רק ראש, שממוקמת במקום רנדומאלי על המפה
        public Snake()
        {
            this.isAlive = true;
            this.dir2 = direction.Up;
            Random rnd = new Random();
            Point head = new Point(rnd.Next(1, Console.WindowWidth - 1), rnd.Next(1, Console.WindowHeight - 1));
            this.Nodes.Add(head);
            this.lastNode = new Point(getHead().getX(), getHead().getY());
        }
        //מחזיר את רשימת החוליות שמרכיבות את הנחש
        public List<Point> getBuddy()
        {
            return this.Nodes;
        }
        //מחזיר את הנקודה שבה נמצא ראש הנחש
        public Point getHead()
        {
            return this.Nodes.First<Point>();
        }
        //מוסיפה נקודה לסוף הנחש
        public void addNewNode(Point p)
        {
            this.Nodes.Add(p);
        }
        public void Dead()
        {
            this.isAlive = false;
        }

        public Point getLastNode()
        {
            return this.lastNode;
        }
        public void setLastNode(Point p)
        {
            this.lastNode = new Point(p.getX(), p.getY());
        }
        //פעולה שמזיזה את הנחש בהתאם לכיוון שהיא מקבלת
        public void makeASingleMove(direction dir)
        {
            this.lastNode = new Point(getBuddy()[getBuddy().Count - 1].getX(), getBuddy()[getBuddy().Count - 1].getY());
            switch (dir)
            {
                case direction.Up:
                    for (int i = this.Nodes.Count - 1; i > 0; i--)
                    {
                        this.Nodes[i].setLocationByPoint(this.Nodes[i - 1]);
                        this.dir2 = dir;
                    }
                    this.Nodes[0].setY(this.Nodes[0].getY() - 1);

                    break;
                case direction.Down:
                    for (int i = this.Nodes.Count - 1; i > 0; i--)
                    {
                        this.Nodes[i].setLocationByPoint(this.Nodes[i - 1]);
                        this.dir2 = dir;
                    }
                    this.Nodes[0].setY(this.Nodes[0].getY() + 1);
                    break;
                case direction.Right:
                    for (int i = this.Nodes.Count - 1; i > 0; i--)
                    {
                        this.Nodes[i].setLocationByPoint(this.Nodes[i - 1]);
                        this.dir2 = dir;
                    }
                    this.Nodes[0].setX(this.Nodes[0].getX() + 1);
                    break;
                case direction.Left:
                    for (int i = this.Nodes.Count - 1; i > 0; i--)
                    {
                        this.Nodes[i].setLocationByPoint(this.Nodes[i - 1]);
                        this.dir2 = dir;
                    }
                    this.Nodes[0].setX(this.Nodes[0].getX() - 1);
                    break;
            }
        }

        public direction getDir2()
        {
            return this.dir2;
        }
        public void setDir2(direction dir)
        {
            this.dir2 = dir;
        }
        public void continueTODirection()
        {
            makeASingleMove(this.dir2);
        }
    }
}
