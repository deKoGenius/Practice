using System;
using System.Linq.Expressions;

namespace Lambda
{
    internal class ExpressionTreeViaLambda
    {
        static void Main(string[] args)
        {
            Expression<Func<int, int, int>> expression = (a, b) => 1 * 2 + (a - b);
            Func<int, int, int> func = expression.Compile();

            Console.WriteLine($"{func(7,8)}");
        }
    }
}
