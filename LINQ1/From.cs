using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    class From
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[] { 9, 2, 6, 4, 5, 3, 7, 8, 11, 12 };

            var result = from n in numbers
                         where n % 2 == 0
                         orderby n descending
                         select n;

            foreach(int n in result)
            {
                Console.WriteLine($"짝수 : {n}");
            }
        }
    }
}
