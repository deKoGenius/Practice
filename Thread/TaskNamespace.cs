using System;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class TaskNamespace
    {
        static void Main(string[] args)
        {
            //Action someAction = () =>
            //    {
            //        Thread.Sleep(1000);
            //        Console.WriteLine("Asynchronously.");
            //    };

            var myTask = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Asynchronously.");
            });
            

            Console.WriteLine("Synchronously.");

            myTask.Wait();

        }
    }
}
