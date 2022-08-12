using System;
using System.Threading;

namespace ThreadD
{
    internal class ThreadS
    {
        static void DoSomething()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(DoSomething);
            t1.Start();

            for(int i=0; i< 10; i++)
            {
                Console.WriteLine($"Main : {i}");
                //Thread.Sleep(1);
            }

            Console.WriteLine("Wating until thread stops...");
            t1.Join();

            Console.WriteLine("Finished!!");
        }
    }
}
