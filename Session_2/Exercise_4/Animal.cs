using System;
using System.Collections.Generic;
using System.Collections;

namespace Exercise_4
{
    class Animal
    {


        static List<Animal> animals;
        static string type;
        static double weight;
        static int runSpeed;
        static int LIST_SIZE = 10;
        public Animal(string type, double weight, int runSpeed)
        {
            Animal.type = type;
            Animal.weight = weight;
            Animal.runSpeed = runSpeed;
            animals = new List<Animal>(LIST_SIZE);
        }

        static void main(String args)
        {
            animals.Add(new Animal("Cat", 3, 40));
            animals.Add(new Animal("Dog", 12, 35));
            animals.Add(new Animal("Human", 69, 30));
            animals.Add(new Animal("Frog", 0.9, 4));
            animals.Add(new Animal("Tiger", 102, 55));
            animals.Add(new Animal("Rabbit", 3, 25));
            animals.Add(new Animal("Elephant", 1200, 22));
            animals.Add(new Animal("Horse", 111, 50));
            animals.Add(new Animal("Zebra", 107, 44));
            animals.Add(new Animal("Monkey", 6, 10));
            animals.Add(new Animal("Chimp", 7, 11));
            getAnimals(animals);
            animals.Sort();
            animals.ForEach(Console.WriteLine);
            
        }

        public static void getAnimals(List<Animal> animals)
        {
            for (int i = 0; i <= LIST_SIZE; i++)
            {
                Console.WriteLine(animals[i]);
            }
        }

        public override string ToString()
        {
            return $"Type: {type} weight {weight} run speed: {runSpeed}";
        }
    }
}
