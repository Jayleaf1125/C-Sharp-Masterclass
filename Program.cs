﻿using System;
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
using Section10;
using SimpleProject2;

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

            TextFileManipulator tfm = new TextFileManipulator(@"C:\Users\Jason\Desktop\C# Masterclass\Masterclass\Section10\Assests\textFile.txt");

            // tfm.ReadAllText();
            // Console.WriteLine();
            tfm.ReadAllLines();

            Console.WriteLine();

            string[] lines = { "Hello World!", "Jason here"};
            tfm.WriteAllLines(lines);
            tfm.ReadAllLines();

           
        }








         static void SeeingHowAbstractClassesWork()
            {
                Shape[] shapes = { new Cube(5), new Sphere(5), new Cube(7), new Sphere(7), new Cube(10), new Sphere(10) };

                foreach (Shape shape in shapes)
                {
                    shape.GetInfo();

                    Cube iceCube = shape as Cube;

                    if (iceCube == null)
                    {
                        Console.WriteLine("This shape is not a cube");
                    }
                    else
                    {
                        Console.WriteLine("This shape is a cube");
                    }

                    object cub1 = new Cube(90);
                    Cube cub2 = (Cube)cub1;

                    Console.WriteLine("{0} has a volume of {1}", cub2.Name, cub2.Volume());
                }
            }


        // List<int> numsList = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8};
        // int[] numsArr = new int[] {10, 12, 34, 55};

        // CollectionSum(numsList);
        // CollectionSum(numsArr);

        static void CollectionSum(IEnumerable<int> anyCollection) {
            int sum = 0;

            foreach (int i in anyCollection) {
                sum += i;
            }

            Console.WriteLine("Sum: {0}", sum);
        }
        
            // IEnumerable<int> unknownCollection;
            // unknownCollection = GetCollection(1);

            // Console.WriteLine("This was a List<int>");
            // foreach (int num in unknownCollection) {
            //     Console.Write(num + " ");
            // }

        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numsList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numsQueue = new Queue<int>();
            numsQueue.Enqueue(6);
            numsQueue.Enqueue(7);
            numsQueue.Enqueue(8);
            numsQueue.Enqueue(9);
            numsQueue.Enqueue(10);

            switch (option)
            {
                case 1:
                    return numsList;
                case 2:
                    return numsQueue;
                default:
                    return new int[] { 11, 12, 13, 14, 15 };
            }
        }
    }
}
