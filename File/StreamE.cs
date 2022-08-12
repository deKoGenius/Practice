using System;
using System.IO;
using System.Collections.Generic;

namespace Files
{
    internal class StreamE
    {
        static void WriteValue(string path, FileMode mode, Int64 value)
        {
            Console.WriteLine($"FileWrite Execute!");
            Console.WriteLine($"Source Value : {value:X}");

            Stream WriteStream = new FileStream(path, mode, FileAccess.Write);

            byte[] wBytes = BitConverter.GetBytes(value);

            foreach (byte b in wBytes)
            {
                Console.Write($"{b:X} ");
            }

            Console.WriteLine();

            WriteStream.Write(wBytes);
            WriteStream.Close();
        }

        static Int64 ReadValue(string path)
        {
            Stream ReadStream = new FileStream(path, FileMode.Open);
            List<Byte> rBytes = new List<byte>();

            while (ReadStream.Position < ReadStream.Length)
            {
                rBytes.Add((byte)ReadStream.ReadByte());
            }

            ReadStream.Close();
            return BitConverter.ToInt64(rBytes.ToArray(), 0);

        }


        static void Main(string[] args)
        {
            string path = "a.txt";

            WriteValue(path, FileMode.Create, 0x123456789ABCDEF0);
            Console.Write($"Read Data : {ReadValue(path):X}");
        }
    }
}
