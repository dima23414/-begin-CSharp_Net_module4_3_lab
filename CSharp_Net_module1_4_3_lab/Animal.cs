using System;
using System.Collections;

namespace CSharp_Net_module1_4_3_lab
{
    // 12) change methods of sorting to properties


    public class Animal : IComparable
    {

        public string Genus { get; set; }
        public double Weight { get; set; }

        public Animal(string genus, double weight)
        {
            Genus = genus;
            Weight = weight;
        }

        public int CompareTo(object obj)
        {
            if (obj is Animal otherAnimal)
            {
                return String.Compare(this.Genus, otherAnimal.Genus);
            }

            throw new ArgumentException("Объект не является экземпляром класса Animal");
        }


        public static IComparer SortWeightAscending()
        {
            return new SortWeightAscendingHelper();
        }

        public static IComparer SortGenusDescending()
        {
            return new SortGenusDescendingHelper();
        }

        private class SortWeightAscendingHelper : IComparer
        {
            public int Compare(object x, object y)
            {
                if (x is Animal animalX && y is Animal animalY)
                {
                    return animalX.Weight.CompareTo(animalY.Weight);
                }

                throw new ArgumentException("Объект не является экземпляром класса Animal");
            }
        }

        private class SortGenusDescendingHelper : IComparer
        {
            public int Compare(object x, object y)
            {
                if (x is Animal animalX && y is Animal animalY)
                {
                    return String.Compare(animalY.Genus, animalX.Genus);
                }

                throw new ArgumentException("Объект не является экземпляром класса Animal");
            }
        }
    }




        // 1) implement interface IComparable
        /* public class Animal
         {
             // 2) declare properties and parameter constructor

             // 3) implement method ComareTo()
             // it comares Genus of type string - return result of method String.Compare 
             // for this.genus and argument object
             // don't forget to cast object to Animal


             // 4) declare methods SortWeightAscending(), SortGenusDescending()
             // they are static and return IComparer
             // return type is custed from constructor of classes SortWeightAscendingHelper, 
             // SortGenusDescendingHelper calling 


             // 5) declare 2 nested private classes SortWeightAscendingHelper, SortGenusDescendingHelper 
             // they implement interface IComparer
             // every nested class has implemented method Comare with 2 parameters of object and return int
             // class SortWeightAscendingHelper sort weight by ascending
             // class SortGenusDescendingHelper sort genus by descending

           }*/
    }
