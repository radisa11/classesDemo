using System;
using System.Collections.Generic;

namespace classesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal("Lion", 250.5,"yellow");
            // Console.WriteLine(a.species);
            a.ShowStats();
            Animal b =new Animal("House Cat", 4, 8.4,true, "white");
            b.ShowStats();
            Console.WriteLine(b.Weight);
            b.feed();
            Console.WriteLine(b.Weight);
            Reptile Picolo = new Reptile("Namekian",2,185,"green","smooth",true);
            Picolo.feed();
            Picolo.ShowStats();

            Bird Kiwi = new Bird("Parrot",2,2.5,"green",true);

            List<Animal> allAnimals = new List<Animal>();
            allAnimals.Add(a);
            allAnimals.Add(b);
            allAnimals.Add(Picolo);
            allAnimals.Add(Kiwi);

            foreach(Animal anim in allAnimals)
            Console.WriteLine(anim.species);
        }
    }
}
