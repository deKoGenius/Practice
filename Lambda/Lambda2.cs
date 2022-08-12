using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    delegate string Concatenate(string[] args);
    class Lambda2
    {
        public static void Main(string[] args)
        {
            Concatenate concat = (arr) =>
            {
                string result = "";
                foreach (string s in arr)
                {
                    result += s;
                }

                return result;
            };


            Console.WriteLine(concat(args));
        }
    }
}
