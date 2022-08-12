using System;
using System.IO;
using System.Linq;

namespace Files
{
    internal class Inquiry
    {
        static void Main(string[] args)
        {
            string directory;
            Console.WriteLine($"디렉터리 루트를 입력하세요 : ");
            directory = Console.ReadLine();

            if (directory == string.Empty)
            {
                directory = Environment.CurrentDirectory;
            }

            Console.WriteLine($"directory path : {directory}");

            var directories = from dir in Directory.GetDirectories(directory)
                              let info = new DirectoryInfo(dir)
                              select new
                              {
                                  Name = info.Name,
                                  Attributes = info.Attributes
                              };

            foreach(var d in directories)
            {
                Console.WriteLine($"{d.Name}, {d.Attributes}");
            }

            var files = from file in Directory.GetFiles(directory)
                        let info = new FileInfo(file)
                        select new
                        {
                            Name = info.Name,
                            Size = info.Length,
                            info.Attributes
                        };

            foreach(var f in files)
            {
                Console.WriteLine($"{f.Name}, {f.Size}, {f.Attributes}");
            }
        }
    }
}
