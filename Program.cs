using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using Section9;

namespace Main
{
    enum Color
    {
        Red,
        Blue,
        Yellow,
        Green,
        Purple,
        Brown,
        White,
        Black
    }

    struct BoldLine
    {
        public const int LineWidth = 10;
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            
            BirdShelter birdShelter = new BirdShelter();

            foreach (Bird bird in birdShelter) {
                if(!bird.IsNaughtyBird) {
                    bird.GiveTreat(2);
                } else {
                    bird.GiveTreat(1);
                }
            }

        }

        
    }
}
