using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;

public enum direction { Up, Down, Left, Right };

namespace ConsoleApplication3
{
    class Program
    {
        static ConsoleKey cki = new ConsoleKey();
        static Snake snk = new Snake();
        static Fruit fru = new Fruit();
        static Thread thr = new Thread(new ThreadStart(checkTheKey));
        public static void checkTheKey()
        {
            while (true)
            {
                if (Console.KeyAvailable)
                    cki = Console.ReadKey().Key;
            }
        }
        public static void makeMove()
        {
            switch (cki)
            {
                case ConsoleKey.DownArrow:
                    snk.makeASingleMove(direction.Down);
                    break;
                case ConsoleKey.LeftArrow:
                    snk.makeASingleMove(direction.Left);
                    break;
                case ConsoleKey.RightArrow:
                    snk.makeASingleMove(direction.Right);
                    break;
                case ConsoleKey.UpArrow:
                    snk.makeASingleMove(direction.Up);
                    break;
            }
        }
        public static void renderSnake()
        {
            foreach (Point p in snk.getBuddy())
            {
                Console.SetCursorPosition(p.getX(), p.getY());
                Console.Write("X");
            }
            Console.SetCursorPosition(fru.getLocation().getX(), fru.getLocation().getY());
            Console.Write("O");
        }

        static void OnTimedEvent(Object obj)
        {
            Console.Clear();
            renderSnake();
            makeMove();
        }

        public static void Main(string[] args)
        {
            Console.WindowHeight = 50;
            Console.WindowWidth = 100;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            thr.Start();
            AutoResetEvent are = new AutoResetEvent(true);
            TimerCallback tcb = OnTimedEvent;
            Timer tmr = new Timer(tcb, are, 1000, 100);
            fru.setLocation();
        }
    }
}
