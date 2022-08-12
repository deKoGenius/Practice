using System;
using System.IO;

namespace File
{
    internal class TextStream
    {
        static void Main(string[] args)
        {
            string path = "text.txt";

            using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create)))
            {
                sw.WriteLine("안녕하세욤~");
                sw.WriteLine(int.MaxValue);
                sw.WriteLine("hello ASCII!");
            }

            using StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open));
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }

        }
    }
}
