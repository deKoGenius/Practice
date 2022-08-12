using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace Files
{
    internal class Touch
    {
        static void OnWrongPathType(string type)
        {
            Console.WriteLine($"{type} is wrong type");
            return;
        }

        static void ParsingString(string str, out string path, out string type)
        {
            if(str == null || str == String.Empty)
            {
                Console.WriteLine("입력값이 없습니다.");
                throw new Exception();
            }

            string[] parsing = str.Split(" ");
            if(parsing.Length == 1)
            {
                path = parsing[0];
                type = "File";
            }
            else if(parsing.Length == 2)
            {
                path = parsing[0];
                type = parsing[1];
            }
            else
            {
                Console.WriteLine("형식을 지켜주세요!");
                throw new Exception("형식 오류");
            }
            
        }

        static void CreateFileOrDirectory(string path, string type)
        {
            if(type.ToUpper() == "FILE")
            {
                if (File.Exists(path))
                {
                    File.SetLastWriteTime(path, DateTime.Now);
                }
                else
                {
                    File.Create(path);
                }
            }
            else if(type.ToUpper() == "DIRECTORY")
            {
                if (Directory.Exists(path))
                {
                    Directory.SetLastWriteTime(path, DateTime.Now);
                }
                else
                {
                    Directory.CreateDirectory(path);
                }
            }
            else
            {
                OnWrongPathType(type);
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine($"usage : <Path> [File | Directory]");
            string input = Console.ReadLine();
            try
            {
                ParsingString(input, out string path, out string type);
                CreateFileOrDirectory(path, type);

            }
            catch (Exception e)
            {
                return;
            }

            
        }
    }
}
