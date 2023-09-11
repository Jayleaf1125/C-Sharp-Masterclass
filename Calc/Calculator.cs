using System;

namespace TwoNumberCalculator
{
    class Calculator
    {
        public static void Addition(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static void Subtraction(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }

        public static void Multiplication(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }

        public static void Division(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }

        public static void FindRemainder(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }

        public static void FlipSign(int value)
        {
            Console.WriteLine(value * -1);
        }
    }
}
