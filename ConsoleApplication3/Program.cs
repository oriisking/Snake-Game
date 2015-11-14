﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;

public enum direction { Down, Left, Right, Up };

namespace ConsoleApplication3
{
    class Program
    {
        static ConsoleKey cki = new ConsoleKey();
        static Snake snk = new Snake();
        static Fruit fru = new Fruit();
        static Thread thr = new Thread(new ThreadStart(checkTheKey));
        static Timer tmr;
        static int speed = 100;
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
                    snk.setDir2(direction.Down);
                    break;
                case ConsoleKey.LeftArrow:
                    snk.makeASingleMove(direction.Left);
                    snk.setDir2(direction.Left);
                    break;
                case ConsoleKey.RightArrow:
                    snk.makeASingleMove(direction.Right);
                    snk.setDir2(direction.Right);
                    break;
                case ConsoleKey.UpArrow:
                    snk.makeASingleMove(direction.Up);
                    snk.setDir2(direction.Up);
                    break;
                default:
                    snk.continueTODirection();
                    break;

            }
        }
        public static void renderSnake()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            switch (snk.getDir2())
            {

                case direction.Down:
                    Console.SetCursorPosition(snk.getBuddy()[0].getX(), snk.getBuddy()[0].getY());
                    Console.Write("V");
                    break;
                case direction.Left:
                    Console.SetCursorPosition(snk.getBuddy()[0].getX(), snk.getBuddy()[0].getY());
                    Console.Write("<");
                    break;
                case direction.Right:
                    Console.SetCursorPosition(snk.getBuddy()[0].getX(), snk.getBuddy()[0].getY());
                    Console.Write(">");
                    break;
                case direction.Up:
                    Console.SetCursorPosition(snk.getBuddy()[0].getX(), snk.getBuddy()[0].getY());
                    Console.Write("^");
                    break;
                default:
                    break;
            }
            for (int i = 1; i <= snk.getBuddy().Count - 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(snk.getBuddy()[i].getX(), snk.getBuddy()[i].getY());
                Console.Write("X");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(fru.getLocation().getX(), fru.getLocation().getY());
            Console.Write("O");
        }

        static void OnTimedEvent(Object obj)
        {
            Console.Clear();
            renderSnake();
            checkIfEatHimself();
            makeMove();
            if (snk.getHead().isEqual(fru.getLocation()))
            {
                snk.addNewNode(snk.getLastNode());
                fru.setLocation();
                if (speed > 10)
                {
                    tmr.Change(1, speed - 5);
                    speed -= 5;
                }
            }
        }
        public static void checkIfEatHimself()
        {
            for (int i = 1; i < snk.getBuddy().Count - 1; i++)
            {
                if (snk.getHead().isEqual(snk.getBuddy()[i]))
                {
                    snk.Dead();
                    thr.Abort();
                    tmr.Change(10000000, 10000000);
                    Console.Clear();
                    #region fuck_you
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("FUCK YOU!!!!!");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("FUCK YOU!!!!!");
                    #endregion
                    Console.ReadKey();
                }
            }
        }

        public static void Main(string[] args)
        {

            cki = ConsoleKey.RightArrow;
            Console.WindowHeight = 50;
            Console.WindowWidth = 100;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            thr.Start();
            AutoResetEvent are = new AutoResetEvent(true);
            TimerCallback tcb = OnTimedEvent;
            tmr = new Timer(tcb, are, 1000, speed);
            fru.setLocation();
        }
    }
}
