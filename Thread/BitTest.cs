using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread
{
    [Flags]
    enum MyEnum : int
    {
        Apple = 1 << 0,
        Orange = 1 << 1,
        Kiwi = 1 << 2,
        Mango = 1 << 3,
    }
    class BitTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine((MyEnum)1);
            Console.WriteLine((MyEnum)(4|1));

       
        }
    }
}
