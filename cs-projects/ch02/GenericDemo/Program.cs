using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using SystemExt;
using AnimalFarm;

namespace GenericDemo
{
    class GenericDemoTesc
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal> { new Cow { }, new Chicken("Gemima") };
            foreach (var animal in animals)
            {
                Console.Write($"{animal} ");
                animal.Feed();
            }
            PrintCollections(animals);
            ///
            var farm = new AnimalFarm<Animal>(new Cow());
            farm.GetMoreAnimals(new Chicken("Mary")).GetMoreAnimals(
                new Cow { }).GetMoreAnimals<Animal>(new Cow());
            PrintCollections(farm.Animals);
        }

        static void PrintCollections<T>(IEnumerable<T> collections, string msg = "Printing Values..")
        {
            Console.WriteLine(msg);
            foreach (var collection in collections)
            {
                Console.Out.PrintLine(collection);
            }
            Console.Out.PrintLine(collections.Count());
        }
    }
}
