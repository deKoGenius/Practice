using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    internal class ParallelP
    {
        static bool IsPrime(long number)
        {
            if (number < 2)
                return false;

            if (number % 2 == 0 && number != 2)
                return false;

            for(long i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input Range and Task Count ([from] [to] : ");
            string str = Console.ReadLine();
            string[] parsing = str.Split(' ');
            Int64.TryParse(parsing[0], out long from);
            Int64.TryParse(parsing[1], out long To);

            Console.WriteLine("Please press enter to start...");
            Console.ReadLine();
            Console.WriteLine("Strated...");

            DateTime startTime = DateTime.Now;
            List<long> total = new List<long>();

            Parallel.For(from, To, (long i) =>
            {
                if (IsPrime(i))
                    lock(total)
                        total.Add(i);
            });

            DateTime endTime = DateTime.Now;

            TimeSpan elapsed = endTime - startTime;

            Console.WriteLine($"Prime Number count between {from} and {To} : {total.Count}");
            Console.WriteLine($"Elapsed Time : {elapsed}");

        }
    }
}
