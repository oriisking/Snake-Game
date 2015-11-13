using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

enum direction { Up, Down, Left, Right };
namespace ConsoleApplication3
{
    class Program
    {
        static Timer tm = new Timer(500.0);
        static Snake snk = new Snake();
        static Fruit fru = new Fruit();
        static ConsoleKey csk = new ConsoleKey();
        public static void renderTheMap(Snake snk, Fruit fru)
        {
            Console.Clear();
            string str = "";
            for (int i = 1; i < 26; i++)
            {
                for (int j = 1; j < 81; j++)
                {
                    foreach (Point p in snk.getBuddy())
                    {
                        if (p.isEqual(new Point(j, i)))
                        {
                            str += "O";
                            break;
                        }
                        else
                        {
                            if (fru.getLocation().isEqual(new Point(j, i)))
                            {
                                str += "X";
                                break;
                            }
                            else
                            {
                                str += " ";
                                break;
                            }
                        }
                        
                    }
                    
                }
            }
            Console.WriteLine(str);
            
        }
        static void makeMove()
        {
            
        }
        static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            
            renderTheMap(snk,fru);
            

        }

        static void Main(string[] args)
        {
            fru.setLocation();
            tm.Elapsed += OnTimedEvent;
            Random rnd = new Random();
            fru.setLocation();
            tm.Start();
            //renderTheMap(snk, fru);
            Console.Read();

        }
        
    }
}
