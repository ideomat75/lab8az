using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using lab08;

namespace des
{


    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\Users\\andre\\source\\repos\\lab08\\lab08\\bin\\Debug\\res.xml", FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(Animal));
            Animal res = (Animal)serializer.Deserialize(fs);

            Console.WriteLine($"{res.Name}\t{res.Country}\t{res.ClassificationAnimal}\t{res.HideFromOtherAnimals}");
        }
    }
}
