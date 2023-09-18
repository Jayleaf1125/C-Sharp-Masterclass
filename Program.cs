using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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

            // Post post1 = new Post();
            // Post post2 = new Post("Thanks for the birthday wishes", true, "Jason Padilla");

            // Console.WriteLine(post1.ToString());
            // Console.WriteLine(post2.ToString());

            // ImagePost imagePost1 = new ImagePost();
            // ImagePost imagePost2 = new ImagePost("Checkout my new shoes", "Jason Padilla", "https://FreshShoes.com/Nike", true);

            // Console.WriteLine();

            // Console.WriteLine(imagePost1.ToString());
            // Console.WriteLine(imagePost2.ToString());

            VideoPost videoPost1 = new VideoPost();
            VideoPost videoPost2 = new VideoPost("Check out my first ever video", "Jason Padilla", true, "https://FirstVideoBro.com", 15);

            Console.WriteLine(videoPost1.ToString());
            Console.WriteLine(videoPost2.ToString());
            System.Console.WriteLine();

            videoPost2.Play();
            Console.ReadKey();
            videoPost2.Stop();
            
        }

        
    }
}
