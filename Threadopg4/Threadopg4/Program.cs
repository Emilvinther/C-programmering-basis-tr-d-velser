using System;
using System.Threading;

namespace Threadopg4
{
    
    internal class Program
    {
        // Static char valueable with value *
        static char ch = '*';
        static void Main(string[] args)
        {
            // Making threads 
            Thread output = new Thread(Putout);
            Thread input = new Thread(Putin);
            // Start threads
            output.Start();
            input.Start();
        }

        static void Putout()
        {
            // It keep printing whats in ch
            while (true)
            {
                Console.Write(ch);
                Thread.Sleep(50);
            }
            
        }

        static void Putin()
        {
            // Allows your to change the output of ch
            while (true)
            {
                char input = Console.ReadKey().KeyChar;
                ch = input;
            }
            

        }
   
    }
}
