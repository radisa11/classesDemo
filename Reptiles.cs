using System;

namespace classesDemo
{
    public class Reptile : Animal
    {
        public bool isColdBlooded = true;
        public string scaleTexture;
        public bool canRegrowLimb;
        public Reptile(string sp, int numLegs, double wgh,string clr,string scale, bool regrow) : base(sp, numLegs,wgh,clr)
        {
            scaleTexture = scale;
            canRegrowLimb = regrow;
        }
        public override void ShowStats()
        {
            base.ShowStats();
            Console.WriteLine($"Cold-Blooded: {isColdBlooded}");
            Console.WriteLine($"Scale Texture: {scaleTexture}");
            Console.WriteLine($"Regrow Ability: {canRegrowLimb}");
        }
    }
}