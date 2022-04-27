using System;

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
            
        }
    }
}
