using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Snake
    {
        private List<Point> Nodes = new List<Point>();
        //בונה נחש ריק בו רק ראש, שממוקמת במקום רנדומאלי על המפה
        public Snake()
        {
            Random rnd = new Random();
            Point head = new Point(rnd.Next(1, Console.WindowHeight - 1), rnd.Next(1, Console.WindowWidth - 1));
            this.Nodes.Add(head);
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
        //בודק אם הנחש עולה על עצמו
        public bool checkIfIsOnself()
        {
            for (int i = 1; i < this.Nodes.Count-1; i++)
                if (this.Nodes[i].isEqual(this.getHead()))
                    return true;
            return false;
        }
        
        //פעולה שמזיזה את הנחש בהתאם לכיוון שהיא מקבלת
        public void makeASingleMove(direction dir)
        {

            switch (dir)
            {
                case direction.Up:
                    for (int i = this.Nodes.Count - 1; i > 0 ; i--)
                    {
                        this.Nodes[i].setLocationByPoint(this.Nodes[i - 1]);
                    }
                    this.Nodes[0].setY(this.Nodes[0].getY() - 1);
                    break;
                case direction.Down:
                    for (int i = this.Nodes.Count - 1; i > 0; i--)
                    {
                        this.Nodes[i].setLocationByPoint(this.Nodes[i - 1]);
                    }
                    this.Nodes[0].setY(this.Nodes[0].getY() + 1);
                    break;
                case direction.Right:
                    int x = 1;

                    for (int i = this.Nodes.Count - 1; i > 0; i--)
                    {
                        this.Nodes[i].setLocationByPoint(this.Nodes[i - 1]);
                    }
                    this.Nodes[0].setX(x + this.Nodes[0].getX());
                    break;
                case direction.Left:
                    for (int i = this.Nodes.Count - 1; i > 0; i--)
                    {
                        this.Nodes[i].setLocationByPoint(this.Nodes[i - 1]);
                    }
                    this.Nodes[0].setX(this.Nodes[0].getX() - 1);
                    break;
            }
        }
    }
}
