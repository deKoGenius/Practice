using System;
using System.Threading;

namespace Threads
{
    class Counter
    {
        const int LOOP_COUNT = 100;

        readonly object MyLock;

        private int count;
        bool lockedCount = false;
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
            while (loopCount-- > 0)
            {

                lock (MyLock)
                {
                    while(count >0 || lockedCount == true)
                    {
                        Monitor.Wait(MyLock);
                    }

                    lockedCount = true;
                    count++;
                    lockedCount = false;

                    Console.WriteLine($"Increase() : {count}");
                    Monitor.Pulse(MyLock);
                }
            }
        }

        public void Decrease()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0)
            {
                lock (MyLock)
                {
                    while(count < 0 || lockedCount == true)
                    {
                        Monitor.Wait(MyLock);
                    }

                    lockedCount = true;
                    count--;
                    lockedCount = false;

                    Console.WriteLine($"Decrease() : {count}");
                    Monitor.Pulse(MyLock);
                }
            }
        }
    }
    internal class SynchronizationMo
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
