using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab08
{
    public enum eClassificationAnimal
    {
        Herbivores,
        Carnivores,
        Omnivores
    }

    public enum eFavouriteFood
    {
        Meat,
        Plants,
        Everything
    }
    public class Animal
    {
        public string Name { get; set; }

        public string Country { get; set; }

        public string HideFromOtherAnimals { get; set; }

        public string WhatAnimal { get; set; }

        public eClassificationAnimal ClassificationAnimal = eClassificationAnimal.Omnivores;


        public Animal() { }

        public void Deconstruct() { }

        public eClassificationAnimal GetClassificationAnimal()
        {
            return ClassificationAnimal;
        }

        public eFavouriteFood GetFavouriteFood()
        {
            return eFavouriteFood.Everything;
        }

        public string SayHello()
        {
            return "hello";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Name = "bob";
            animal.Country = "moscow";
            animal.WhatAnimal = "pig";
            animal.HideFromOtherAnimals = "no";

            XmlSerializer xml = new XmlSerializer(typeof(Animal));
            FileStream fs = new FileStream("res.xml", FileMode.OpenOrCreate);

            xml.Serialize(fs, animal);
        }
    }
}
