using System;
using System.Collections;

namespace CSharp_Net_module1_4_3_lab
{

    class Animals
    {
        private Animal[] animals;

        public Animals(Animal[] initialAnimals)
        {
            animals = initialAnimals;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Animal animal in animals)
            {
                yield return animal;
            }
        }
   
    }
}
