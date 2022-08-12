using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Event
{
    internal delegate int MyDelegate(int a, int b);
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        MyDelegate Callback;

    //        Callback = delegate (int a, int b)
    //        {
    //            return a + b;
    //        };

    //        WriteLine(Callback(3, 4));

    //        Callback = delegate (int a, int b)
    //        {
    //            return a - b;
    //        };

    //        WriteLine(Callback(7, 5));

    //    }
    //}
}
