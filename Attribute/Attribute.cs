using System;

namespace Attribute
{
    class MyClass
    {
        [Obsolete("OldMethod는 폐기되었습니다. NewMethod()를 이용하세요.")]
        public void OldMethod()
        {
            Console.WriteLine("I'm Old");
        }

        public void NewMethod()
        {
            Console.WriteLine("I'm New");
        }
    }
    class Attribute
    {
        static void Main(string[] args)
        {
            MyClass Obj = new MyClass();
            Obj.OldMethod();
            Obj.NewMethod();
        }
    }
}
