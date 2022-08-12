using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class FriendList
    {
        private List<string> list = new List<string>();

        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);
        public void PrintAll()
        {
            foreach(var a in list)
            {
                Console.WriteLine(a);
            }
        }
        public FriendList() => Console.WriteLine("FriendList()");
        ~FriendList() => Console.WriteLine("~FriendList()");

        public int Capacity
        {
            get => list.Capacity;
            set => list.Capacity = value;
        }

        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }

        public void AllClear() => list.Clear();
    }
    internal class ExpressionBodiesMember
    {

        static void Main(string[] args)
        {
            FriendList friendList = new FriendList();
            friendList.Add("Eeny");
            friendList.Add("Meeny");
            friendList.Add("Miny");
            friendList.Remove("Eeny");
            friendList.Add("how");
            friendList.Add("much");
            friendList.Add("you");
            friendList.Add("can");
            friendList.Add("can");
            friendList.Add("can");
            friendList.Add("can");
            friendList.Add("can");
            friendList.PrintAll();
            friendList.AllClear();
            int[] array1 = new int[] { 3, 35, 2, 4 };
            foreach(int i in array1)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();    
            array1.Append<int>(3);
            foreach (int i in array1)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine($"{friendList.Capacity}");
            friendList.Capacity = 10;
            Console.WriteLine($"{friendList.Capacity}");

            Console.WriteLine($"{friendList[0]}");
            friendList[0] = "Moe";
            friendList.PrintAll();
        }
    }
}
