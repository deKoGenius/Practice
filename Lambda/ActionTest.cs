using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class ActionTest
    {
        public static void Main(string[] args)
        {
            Action act1 = () => { Console.WriteLine($"act1 호출"); };
            act1 += () => Console.WriteLine("act1 한번더 호출");
            act1();

            int result = 0;
            Action<int> act2 = (x) => result = x * x;

            act2(3);
            Console.WriteLine($"result : {result}");

            Action<double, double> act3 = (x, y) =>
            {
                double pi = x / y;
                Console.WriteLine($"Action<T1, T2>({x},{y}) : {pi}");
            };
            act3(22, 7);

            Action<int, int> act4 = (x, y) =>
            {
                x = 2;
                y = 3;
                Console.WriteLine($"x={x}, y={y}");
            };
            int x = 6, y=8;
            act4(in x, in y);
        }
    }
}
