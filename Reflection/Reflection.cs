using System;
using System.Reflection;

namespace Reflection
{
    internal class Reflection
    {
        static void PrintInterfaces(Type type)
        {
            Console.WriteLine($"-------- Interfaces --------");

            Type[] interfaces = type.GetInterfaces();
            foreach (Type i in interfaces)
            {
                Console.WriteLine($"Name : {i.Name}");
            }
            Console.WriteLine();
        }

        static void PrintFields(Type type)
        {
            Console.WriteLine("-------- Fields --------");

            FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
            foreach (FieldInfo f in fields)
            {
                string accessLevel = "protected";
                if (f.IsPublic)
                {
                    accessLevel = "public";
                }
                else if (f.IsPrivate)
                {
                    accessLevel = "private";
                }

                Console.WriteLine($"Access : {accessLevel}, Type : {f.FieldType.Name}, Name : {f.Name}");
            }
            Console.WriteLine();
        }

        static void PrintMethods(Type type)
        {
            Console.WriteLine("-------- Methods  --------");

            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo m in methods)
            {
                Console.Write($"Type : {m.ReturnType.Name}, Name : {m.Name}, Parameter : ");

                ParameterInfo[] args = m.GetParameters();
                foreach(ParameterInfo p in args)
                {
                    Console.Write($"{p.ParameterType.Name}, ");
                }
                Console.WriteLine("\b\b");
            }
            Console.WriteLine();
        }

        static void PrintNestedTypes(Type type)
        {
            Console.WriteLine("-------- NestedTypes --------");

            Type[] NestedTypes = type.GetNestedTypes();
            foreach(Type n in NestedTypes)
            {
                Console.WriteLine($"Name : {n.Name}");
            }
            Console.WriteLine();
        }

        static void PrintProperties(Type type)
        {
            Console.WriteLine("-------- Properties  --------");

            PropertyInfo[] properties = type.GetProperties();
            foreach(PropertyInfo p in properties)
            {
                Console.WriteLine($"Type : {p.PropertyType.Name}, Name : {p.Name}");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int a = 0;
            Type type = a.GetType();

            PrintInterfaces(type);
            PrintFields(type);
            PrintMethods(type);
            PrintProperties(type);
            PrintNestedTypes(type);
        }
    }
}
