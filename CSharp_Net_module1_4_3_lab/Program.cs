using System;
using System.Collections;

namespace CSharp_Net_module1_4_3_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animalArray = new Animal[]
            {
            new Animal("Пнтера", 150),
            new Animal("Слон", 5000),
            new Animal("Жираф", 1500)
            };

            Animals animalCollection = new Animals(animalArray);

            Console.WriteLine("Животные в коллекции животных:");
            foreach (Animal animal in animalCollection)
            {
                Console.WriteLine($"{animal.Genus} - {animal.Weight} кг");
            }

            Console.WriteLine();

            Console.WriteLine("Отсортировано по роду (по возрастанию):");
            Array.Sort(animalArray);
            foreach (Animal animal in animalArray)
            {
                Console.WriteLine($"{animal.Genus} - {animal.Weight} кг");
            }

            Console.WriteLine();

            Console.WriteLine("Отсортировано по весу (по возрастанию):");
            Array.Sort(animalArray, Animal.SortWeightAscending());
            foreach (Animal animal in animalArray)
            {
                Console.WriteLine($"{animal.Genus} - {animal.Weight} кг");
            }

            Console.WriteLine();

            Console.WriteLine("Отсортировано по роду (по убыванию):");
            Array.Sort(animalArray, Animal.SortGenusDescending());
            foreach (Animal animal in animalArray)
            {
                Console.WriteLine($"{animal.Genus} - {animal.Weight} кг");
            }

        Console.ReadLine();
        }
    }
}
