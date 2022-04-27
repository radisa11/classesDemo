using System;

namespace classesDemo
{
    public class Animal 
    {
        private string species;
        public int numLegs;
        private double weight;
        public double Weight
        {
            get {return weight;}
        }
        public bool isMammal;
        public string color;

        public Animal(string sp, int legs, double wgh, bool isMam, string clr)
        {
            species = sp;
            numLegs = legs;
            weight = wgh;
            isMammal = isMam;
            color = clr;
        }

        public Animal(string sp, double wgh, string clr)
        {
            species = sp;
            numLegs = 4;
            isMammal = true;
            color = clr;
        }

        public Animal(string sp, double wgh,bool isMam, string clr)
        {
            species = sp;
            numLegs = 2;
            weight = wgh;
            isMammal = isMam;
            color = clr;
        }
        // Methods that the animal can do
        public void ShowStats()
        {
            Console.WriteLine($"Species:   {species}");
            Console.WriteLine($"# of Legs: {numLegs}");
            Console.WriteLine($"Weight:    {weight}");
            Console.WriteLine($"Mammal:    {isMammal}");
            Console.WriteLine($"Color:     {color}");
            Console.WriteLine("*****************");
        }
        
        public void feed()
        {
            weight += 1.2;
        }
    }
}