using System;
using static System.Console;

namespace Event
{
    delegate void EventHandler(string message);
    class MyNotifier
    {
        public event EventHandler SomethingHappend;
            
        public void DoSomethin(int number)
        {
            int temp = number % 10;

            if(temp != 0 && temp % 3 == 0)
            {
                SomethingHappend(string.Format($"{number} : 짝"));
            }
        }
    }

    //class MainApp
    //{
    //    static void MyHandler(string ms)
    //    {
    //        WriteLine(ms);
    //    }
    //    static void Main(string[] args)
    //    {
    //        MyNotifier notifier = new MyNotifier();
    //        notifier.SomethingHappend += MyHandler;

    //        for (int i = 1; i < 30; i++)
    //        {
    //            notifier.DoSomethin(i);
    //        }
    //    }
    //}
}
