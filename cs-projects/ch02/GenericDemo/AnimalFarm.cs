using GenericDemo;
using System.Collections.Generic;


namespace AnimalFarm
{
    class AnimalFarm<T> where T : Animal
    {
        private List<T> animals = new List<T>();
        public AnimalFarm(T animal) { animals.Add(animal); }
        public AnimalFarm() : this(new Cow { } as T) { }
        public List<T> Animals => animals;
        public List<T> GetMoreAnimals(T animal) => animals.GetMoreAnimals(animal);

        public IEnumerator<T> GetEnumerator() => animals.GetEnumerator();
    }

    internal static class ListExt
    {
        internal static List<T> GetMoreAnimals<T>(this List<T> list, T animal)
        {
            list.Add(animal);
            return list;
        }
    }
}
