using System;
using System.Threading;

namespace Threadopg3
{
    internal class Program
    {
        static int rando;
        static void Main(string[] args)
        {
            // Making new thread
            Thread temp = new Thread(RandomTemp);
            // Starts Thread
            temp.Start();

            // While loop checking if the thread is terminated, and it will write a string when it happens every 1 secs
            while (true)
            {
                if (!temp.IsAlive)
                {
                    Console.WriteLine("Alarm-tråd termineret");
                    break;
                }

                Thread.Sleep(10000);
                
            }
            Console.ReadKey();
        }
        
        static void RandomTemp()
        {
            
            int a = 0;
            // While loop that makes a random and checks if its in the correct parameters and terminates if it gets too many errors
            while (a<3) {
                Random rnd = new Random();
                rando = rnd.Next(-20, 120);
                Console.WriteLine(rando);
                Thread.Sleep(2000);

                if (rando >= 100 || rando <= 0)
                {
                    a++;
                }

            }

           




        }

      
    }
}
