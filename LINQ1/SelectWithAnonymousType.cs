using System.Linq;
using System;

namespace LINQ1
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class SelectWithAnonymousType
    {
        public static void Main(string[] args)
        {
            Profile[] arrProfiles = new Profile[]
            {
                new Profile(){Name = "정우성", Height = 186},
                new Profile(){Name = "김태희", Height = 158},
                new Profile(){Name = "고현정", Height = 172},
                new Profile(){Name = "이문세", Height = 178},
                new Profile(){Name = "하하", Height = 171},
            };

            var profiles = from profile in arrProfiles
                           where profile.Height < 175
                           orderby profile.Height
                           select new
                           {
                               Name = profile.Name,
                               InchHeight = profile.Height * 0.393
                           };

            foreach(var profile in profiles)
            {
                Console.WriteLine($"{profile.Name}, {profile.InchHeight}");
            }
        }
    }
}
