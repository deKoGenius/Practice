using System;

namespace Lambda
{
    delegate int Calculate(int a, int b);
    class Lambda1
    {
        static void Main(string[] args)
        {
            Calculate Calc = (a, b) => a + b;

            Console.WriteLine($"{3} + {4} = {Calc(3, 4)}");
        }
    }
}
