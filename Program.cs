using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using Section7;

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
            // Program.ListItems(1, 2, "Hello", "Worlds", true, false, 'c', 'l');
            Collections c = new Collections();
            c.Dict();

            // int[] happiness = new int[] { 5, 10, 25, 1, 30 };

            // Happiness(happiness);

            // foreach (int happy in happiness)
            // {
            //     Console.WriteLine(happy);
            // }

            /*
            #Arrays
                - Stores a fixed size sequential collection of elements
                - ONLY of the same type (unless you use the dynamic type, tho it is not recommneded)
                - All kinds of types: int, string, object, etc.
                - Great to store a collection of data - easier to think of a collection of variables of the same type stored at contiguous memeory locations

                Declaring an Array:
                - <type>[] <arrayName>;
                    int[] grades;

                Initializing an Array:
                - <type>[] <arrayName> = new <type>[<length/ammountOfEntries>]
                    int[] grades = new int[5];

                Assigning values to an array:
                - <arrayName>[<index>] = <value>
                    grades[0] = 15;
                    grades[1] = 12;

                    For Loop: Start Step, End Step, Step Size
            
            - Adding a underscore for the second agruement of .TryParse() tells the complier you'll like to ignore the value

            - out _ => This tells the computer that we are not interested in the converted number int.TryParse(intput, out _)

            */
        }

        
    }
}
