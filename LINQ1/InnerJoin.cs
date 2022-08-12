using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }
    }

    class InnerJoin
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

            Product[] arrProduct = new Product[]
            {
                new Product(){Title = "비트", Star="정우성"},
                new Product(){Title = "CF 다수", Star="김태희"},
                new Product(){Title = "아이리스", Star="김태희"},
                new Product(){Title = "모래시계", Star="고현정"},
                new Product(){Title = "Solo예찬", Star="이문세"},
            };

            var innerJoin = from original in arrProfiles
                            join target in arrProduct on original.Name equals target.Star
                            select new
                            {
                                Name = original.Name,
                                Height = original.Height,
                                Title = target.Title
                            };

            foreach(var i in innerJoin)
            {
                Console.WriteLine($"{i.Name}, {i.Title}, {i.Height}");
            }


        }
    }
}
