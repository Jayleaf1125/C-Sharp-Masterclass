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
