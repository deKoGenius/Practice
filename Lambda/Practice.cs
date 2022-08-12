using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Practice
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 11, 22, 33, 44, 55 };

            foreach(int a in array)
            {
                Action action = () => { Console.WriteLine($"{a*a}"); };
                action.Invoke();
            }
        }
    }
}
