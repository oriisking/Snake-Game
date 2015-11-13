using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Web;

public enum direction { Up, Down, Left, Right };

namespace ConsoleApplication3
{
    class Program
    {
        static Timer tm = new Timer(1000.0);
        static Snake snk = new Snake();
        static Fruit fru = new Fruit();
        static ConsoleKey cki = new ConsoleKey();
        static void makeMove()
        {
            if (Console.KeyAvailable)
                cki = Console.ReadKey().Key;
            do
            {
                snk.makeASingleMove(direction.Right);
            } while (cki == ConsoleKey.RightArrow && snk.getBuddy()[0].getX() < 100);
            do
            {
                snk.makeASingleMove(direction.Left);
            } while (cki == ConsoleKey.LeftArrow);
            do
            {
                snk.makeASingleMove(direction.Up);
            } while (cki == ConsoleKey.UpArrow);
            do
            {
                snk.makeASingleMove(direction.Down);
            } while (cki == ConsoleKey.DownArrow);    
            //switch (cki)
            //{

            //    case ConsoleKey.DownArrow:
            //        snk.makeASingleMove(direction.Down);
            //        break;
            //    case ConsoleKey.LeftArrow:
            //        snk.makeASingleMove(direction.Left);
            //        break;
            //    case ConsoleKey.RightArrow:
            //        snk.makeASingleMove(direction.Right);
            //        break;
            //    case ConsoleKey.UpArrow:
            //        snk.makeASingleMove(direction.Up);
            //        break;

            //}
            
            
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
   
        static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            
            Console.Clear();
            renderSnake();
            makeMove();
        }

        static void Main(string[] args)
        {

            
            Console.WindowHeight = 50;
            Console.WindowWidth = 100;

            
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            cki = ConsoleKey.UpArrow;
            fru.setLocation();
            tm.Elapsed += OnTimedEvent;
            tm.Start();
            Console.Read();

        }
        
    }
}
