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
            
            Employee employee = new Employee("Jason Padilla", "Jason", 100000);
            Boss boss = new Boss("Evan Darkleaf", "Evan", 120000, "Lotus");
            Trainee trainee = new Trainee("Matthew Padilla", "Matthew", 90000, 5, 8);

            // employee.Work();
            // employee.Pause();
            Console.WriteLine(employee.ToString());
            Console.WriteLine("---------------");
            // boss.Lead();
            Console.WriteLine(boss.ToString());
            Console.WriteLine("---------------");
            // trainee.Work();
            Console.WriteLine(trainee.ToString());
        }

        
    }
}
