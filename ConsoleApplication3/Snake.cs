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
            Point head = new Point(rnd.Next(1,81),rnd.Next(1,26));
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
        public void Movement()
        {
            //ConsoleKey amir = ConsoleKey.RightArrow;
        }
    }
}
