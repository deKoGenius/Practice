using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ1
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class Basic
    {
        static void Main(string[] args)
        {
            Profile[] profile = new Profile[]{
                new Profile() { Name = "정우성", Height = 186 },
                new Profile() { Name = "김태희", Height = 158 },
                new Profile() { Name = "고현정", Height = 172 },
                new Profile() { Name = "이문세", Height = 178 },
                new Profile() { Name = "하동훈", Height = 171 },
            };

            var profiles = from pro in profile
                           where pro.Height > 175
                           orderby pro.Height ascending
                           select pro;

            foreach(var pro in profiles)
            {
                Console.WriteLine($"{pro.Name}, {pro.Height}");
            }
                      
        }
    }
}
