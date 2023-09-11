namespace Section1
{
    class Section1
    {
        public class IntMaxCompare : IComparer<int>
        {
            public int Compare(int x, int y) => y.CompareTo(x);
        }

        private static void DataType()
        {
            // Signed Interger: negatives and positives
            // Unsigned Interger: positives only

            // Byte: 0 to 255
            byte myByte = 1;
            // sbyte: -128 to 127
            sbyte mySbyte = 50;
            // int: -2,147,483,648 to 2,147,483,647
            int myInt = 1000000;
            // uint: 0 to 4294967295
            uint myUint = 5000;
            // short: -32,768 to 32,767
            short myShort = 32000;
            // ushort: 0 to 65535
            ushort myUshort = 16000;
            // long: -9223372036854775808 to 9223372036854775807
            long myLong = 90000000;
            // ulong: 0 to 18446744073709551615
            ulong myUlong = 55555;
            // float: -3.402823e38 to 3.402823e38
            float myFloat = 12.56f;
            // double: -1.79769313486232e308 to 1.79769313486232e308
            double myDouble = 50.67;
            // char: Unicode symbols used in text
            char myChar = 'k';
            // bool: True or false
            bool myBool = true;
            // decimal: ±1.0 × 10e−28 to ±7.9 × 10e28
            decimal myDecimal = 1567.895m;
        }

        private static void ChallengeString2()
        {
            Console.WriteLine("Enter a string: ");
            string inputVal = Console.ReadLine();

            Console.WriteLine("Enter the character: ");
            string inputChar = Console.ReadLine();

            Console.WriteLine(
                String.Format(
                    "{0} is located at index {1} in {2}",
                    inputChar,
                    inputVal.IndexOf(inputChar),
                    inputVal
                )
            );

            Console.WriteLine("Enter yout first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter yout last name: ");
            string lastName = Console.ReadLine();

            string fullName = String.Format("{0} {1}", firstName, lastName);
            Console.WriteLine("Full name: {0}", fullName);
        }

        private static void ChallengeString1()
        {
            string value;
            Console.WriteLine("Please enter your name and press enter:");
            value = Console.ReadLine(); // Hello World

            Console.WriteLine(
                @$"UpperCase: {value.ToUpper()}
LowerCase: {value.ToLower()}
No Trailing: {value.Trim()}
SubString: {value.Substring(6)}"
            );
        }

        private static void ConversionTypeAndChecking()
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            int intString = Int32.Parse(stringForInt);
            float floatString = float.Parse(stringForFloat);

            System.Console.WriteLine(
                "{0} has been parsed to {1}",
                stringForInt,
                intString.GetType()
            );
            System.Console.WriteLine(
                "{0} has been parsed to {1}",
                stringForFloat,
                floatString.GetType()
            );
        }

        private static void DealingWithPriorityQueue()
        {
            PriorityQueue<string, int> priorityQueue = new PriorityQueue<string, int>(
                new IntMaxCompare()
            );

            priorityQueue.Enqueue("John Lennon", 1948);
            priorityQueue.Enqueue("Oscar Padilla", 1968);
            priorityQueue.Enqueue("Jason Padilla", 1958);
            priorityQueue.Enqueue("Matthew Padilla", 2026);
            priorityQueue.Enqueue("Marria Padilla", 1987);

            while (priorityQueue.TryDequeue(out string item, out int priority))
            {
                System.Console.WriteLine($"{item} born in {priority}");
            }
        }

        /// <summary>
        /// This is a really cool method. I can document this, litt
        /// </summary>
        static void CoolMethod()
        {
            System.Console.WriteLine("I'm cool");
        }
    }
}
