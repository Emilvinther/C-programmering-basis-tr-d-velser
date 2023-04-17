using System.Threading;
using System;

internal class Program
{

   


}

class theprog
{
    public static void Main()
    {
        // Making a new instance of Program
        Program pg = new Program();
        // Making Threads
        Thread thread = new Thread(new ThreadStart(Text1));
        Thread t = new Thread(new ThreadStart(Text2));
        // Thread Names
        thread.Name = "One";
        t.Name = "Two";
        // Starts Threads
        thread.Start();
        t.Start();
        Console.Read();
    }

    // Method with a look that write a string with a 1 sec delay

    static void Text1()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("C#-Trådning er nemt");
            Thread.Sleep(1000);
        }
        
    }

    // Method with a look that write a string with a 1 sec delay

    static void Text2()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Også med flere tråde..");
            Thread.Sleep(1000);
        }
    }

    
}