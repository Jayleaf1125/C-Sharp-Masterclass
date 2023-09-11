namespace Section2
{
    class Section2
    {
        private static void TryAndCatch()
        {
            Console.Clear();
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            // try
            // {
            //     int userInputAsInt = Int32.Parse(userInput);

            //     Console.WriteLine("Your number is {0}", userInputAsInt);
            // }
            // catch (FormatException)
            // {
            //     Console.WriteLine("Format execption, please enter a number next time");
            // }
            // catch (OverflowException)
            // {
            //     Console.WriteLine(
            //         "Overflow execption, number was too long or too short for an int32"
            //     );
            // }
            // finally
            // {
            //     Console.WriteLine("I can still work");
            // }

            try
            {
                int userInputNumber = Int32.Parse(userInput);
                int quotinet = userInputNumber / 0;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Basic math bruh, u can't do that");
            }
        }

        public static int CalculateSum()
        {
            Console.WriteLine("Please enter the first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            return firstNumber + secondNumber;
        }

        static string LowUpper(string value)
        {
            string upper = value.ToUpper();
            string lower = value.ToLower();
            return String.Format("{0}{1}", lower, upper);
        }

        static void Count(string value)
        {
            Console.WriteLine(String.Format("The amount of characters is {0}", value.Length));
        }
    }
}
