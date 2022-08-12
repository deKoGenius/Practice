using System;
using System.IO;

namespace File
{
    internal class BinaryClass
    {
        static void Main(string[] args)
        {

            string path = "c.dat";
            using (BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.Create)))
            {
                bw.Write(int.MaxValue);
                bw.Write("asssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss World!");
                bw.Write(uint.MaxValue);
                bw.Write("안녕");
                bw.Write(double.MaxValue);
            }

            using BinaryReader br = new BinaryReader(new FileStream(path, FileMode.Open));
            Console.WriteLine($"File Size : {br.BaseStream.Length} bytes");
            Console.WriteLine($"{br.ReadInt32()}");
            Console.WriteLine($"{br.ReadString()}");
            Console.WriteLine($"{br.ReadUInt32()}");
            Console.WriteLine($"{br.ReadString()}");
            Console.WriteLine($"{br.ReadDouble()}");
            
        }
    }
}
