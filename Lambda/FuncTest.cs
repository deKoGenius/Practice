﻿using System;

namespace Lambda
{
    class FuncTest
    {
        static void Main(string[] args)
        {
            Func<string> func1 = () => { return new string("func1 호출"); };
            Console.WriteLine($"func1() : {func1()}");

            Func<int, int> func2 = (x) => x * 2;
            Console.WriteLine($"func2(4) : {func2(4)}");

            Func<double, double, double> func3 = (x, y) => x / y;
            Console.WriteLine($"func3(22,7) : {func3(22, 7)}");

        }
    }
}
