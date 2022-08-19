using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Counter
    {
        const int LOOP_COUNT = 100;

        readonly object MyLock;

        private int count;
        public int Count
        {
            get { return count; }
        }

        public Counter()
        {
            MyLock = new object();
            count = 0;
        }

        public void Increase()
        {
            int loopCount = LOOP_COUNT;
            while(loopCount-- > 0)
            {

                lock (MyLock)
                {
                    count++;
                    Console.WriteLine($"Increase() : {count}"); 
                }
                Thread.Sleep(1);
            }
        }

        public void Decrease()
        {
            int loopCount = LOOP_COUNT;
            while(loopCount-- > 0)
            {
                lock (MyLock)
                {
                    
                    count--;
                    Console.WriteLine($"Decrease() : {count}");
                }
                Thread.Sleep(1);
            }
        }
    }
    internal class Synchronization
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            Thread incThread = new Thread(counter.Increase);
            Thread decThread = new Thread(counter.Decrease);

            incThread.Start();
            decThread.Start();

            incThread.Join();
            decThread.Join();

            Console.WriteLine(counter.Count);
        }
    }
}
