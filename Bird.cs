using System;
namespace classesDemo
{
    public class Bird : Animal
    {
        public bool canFly;
    public Bird(string sp, int numLegs, double wgh,string clr,bool Fly) : base(sp, numLegs,wgh,clr)
    {
        canFly = Fly;
    }

    }
}