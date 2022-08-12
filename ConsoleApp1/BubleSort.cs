using System.Collections.Generic;
using static System.Console;

namespace ConsoleApp1
{

    class BubleSort
    {
        delegate int Compare(int a, int b);

        static void BubbleSort(List<int> dataset, Compare comparer)
        {
            int temp = 0;
            for (int i = 0; i < dataset.Count - 1; i++)
            {
                for (int j = 0; j < dataset.Count - (i + 1); j++)
                {
                    if (comparer(dataset[j], dataset[j + 1]) > 0)
                    {
                        temp = dataset[j + 1];
                        dataset[j + 1] = dataset[j];
                        dataset[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 3, 7, 2, 4, 10 };

            WriteLine("Sorting Ascending");
            BubbleSort(data, delegate (int a, int b)
             {
                 if (a > b)
                     return 1;
                 else if (a == b)
                     return 0;
                 else
                     return -1;
             });

            foreach(int index in data)
            {
                Write($"{index} ");
            }
            WriteLine();

            WriteLine("Sorting Descending");
            BubbleSort(data, delegate (int a, int b)
            {
                if (a < b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });

            foreach (int index in data)
            {
                Write($"{index} ");
            }

        }
    }
}
