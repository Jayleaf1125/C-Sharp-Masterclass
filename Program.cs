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
            
            // Ticket t1 = new Ticket(10);
            // Ticket t2 = new Ticket(10);
            // Ticket t3 = new Ticket(20);

            // Console.WriteLine(t1.Equals(t2));
            // Console.WriteLine(t1.Equals(t3));

            Player player = new Player();
            player.ReadStats();
            player.ReadSkills();

        }

        
    }
}
