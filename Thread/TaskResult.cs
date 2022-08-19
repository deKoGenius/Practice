using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Threads
{
    internal class TaskResult
    {
        static bool IsPrime(long number)
        {
            if (number < 2)
                return false;

            if (number % 2 == 0 && number != 2)
                return false;

            for(long i=2;i<number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input Range and Task Count ([from] [to] [Task Count]) : ");
                string str = Console.ReadLine();
                if(str == "z")
                {
                    break;
                }

                string[] parsing = str.Split(' ');
                Int64.TryParse(parsing[0], out long from);
                Int64.TryParse(parsing[1], out long To);
                int.TryParse(parsing[2], out int taskCount);

                Func<object, List<long>> findPrimeFunc = (objRange) =>
                {
                    long[] range = (long[])objRange;
                    List<long> found = new List<long>();

                    for (long i = range[0]; i < range[1]; i++)
                    {
                        if (IsPrime(i))
                            found.Add(i);
                    }

                    return found;
                };

                Task<List<long>>[] tasks = new Task<List<long>>[taskCount];
                long currentFrom = from;
                long currentTo = To / tasks.Length;

                for (int i = 0; i < tasks.Length; i++)
                {
                    Console.WriteLine($"Task{i} : {currentFrom} ~ {currentTo}");

                    tasks[i] = new Task<List<long>>(findPrimeFunc, new long[] { currentFrom, currentTo });
                    currentFrom = currentTo + 1;

                    if (i == tasks.Length - 2)
                    {
                        currentTo = To;
                    }
                    else
                        currentTo = currentTo + (To / tasks.Length);
                }

                Console.WriteLine("Please press enter to start...");
                Console.ReadLine();
                Console.WriteLine("Strated...");

                DateTime startTime = DateTime.Now;

                foreach (Task<List<long>> task in tasks)
                    task.Start();

                List<long> total = new List<long>();

                foreach (Task<List<long>> task in tasks)
                {
                    task.Wait();
                    total.AddRange(task.Result.ToArray());
                }

                DateTime endTime = DateTime.Now;

                TimeSpan timeSpan = endTime - startTime;

                Console.WriteLine($"Prime Number Count between {from} and {To} : {total.Count}");
                Console.WriteLine($"Elapsed time : {timeSpan}");
                Console.WriteLine();


            }
        }
    }
}
