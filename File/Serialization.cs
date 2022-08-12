using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace File
{
    [Serializable]
    class NameCard
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
    }
    class Serialization
    {
        static void Main(string[] args)
        {
            using (Stream ws = new FileStream("ser.dat", FileMode.Create))
            {
                BinaryFormatter serializer = new BinaryFormatter();

                NameCard nc = new NameCard()
                {
                    Name = "박상현",
                    Phone = "010-2372-2415",
                    Age = 33
                };

                serializer.Serialize(ws, nc);
            }

            using Stream rs = new FileStream("ser.dat", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();
            NameCard nc2 = (NameCard)deserializer.Deserialize(rs);

            Console.WriteLine(nc2.Age);
            Console.WriteLine(nc2.Name);
            Console.WriteLine(nc2.Phone);
        }
    }
}
