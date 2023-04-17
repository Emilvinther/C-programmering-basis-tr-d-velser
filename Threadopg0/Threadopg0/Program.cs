using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threadopg0
{
    internal class Program
    {
        // Method with loop that prints current thread name
        public void WorkThreadFunction()
        {
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name);
                }
            }
        }


    }

    class theprog
    {
        public static void Main()
        {
            // Making new instance of Program
            Program pg = new Program();
            // Making threads That uses the loop in Program 
            Thread thread = new Thread(new ThreadStart(pg.WorkThreadFunction));
            Thread t = new Thread(new ThreadStart(pg.WorkThreadFunction));
            // Thread names
            thread.Name = "One";
            t.Name = "Two";
            // Thread priorities
            //thread.Priority = ThreadPriority.Highest;
            //t.Priority = ThreadPriority.Lowest;
            // Thread start
            thread.Start();
            t.Start();
            Console.Read();
        }
    }
}
