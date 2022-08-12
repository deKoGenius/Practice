using System;
using System.IO;

namespace Files
{
    internal class RandomAndSequence
    {
        static void WriteByte(string path, int cnt)
        {
            Stream writeStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            Console.WriteLine($"Position : {writeStream.Position}");

            for(int i = 1; i <= cnt; i++)
            {
                if (i == 3)
                {
                    writeStream.Seek(5, SeekOrigin.Current);
                }
                writeStream.WriteByte((byte)i);
                Console.WriteLine($"Position : {writeStream.Position}");
            }

            writeStream.Close();
        }

        static void ReadByte(string path)
        {
            Stream readStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            
            for(int i = 0; i < readStream.Length; i++)
            {
                Console.WriteLine($"Position : {readStream.Position}, Value : {readStream.ReadByte():X}");
            }
            readStream.Close();

        }
        static void Main(string[] args)
        {
            string path = "b.txt";
            int cnt = 8;
            WriteByte(path, cnt);
            ReadByte(path);
        }
    }
}
