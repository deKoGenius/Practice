using System;
using System.Reflection;

namespace Reflection
{
    class Profile
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public Profile() { }

        public Profile(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public void Print()
        {
            Console.WriteLine($"{Name}, {Phone}");
        }
    }
    class CreatingandUsingObject
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("Reflection.Profile");
            MethodInfo method = type.GetMethod("Print");

            PropertyInfo name = type.GetProperty("Name");
            PropertyInfo phone = type.GetProperty("Phone");

            object profile = Activator.CreateInstance(type, "박찬호", "512-2134");
            method.Invoke(profile, null);

            profile = Activator.CreateInstance(type);
            name.SetValue(profile, "김동현");
            phone.SetValue(profile, "234-2314");

            method.Invoke(profile, null);

            Console.WriteLine($"{name.GetValue(profile)}, {phone.GetValue(profile)}");
        }
    }
}
