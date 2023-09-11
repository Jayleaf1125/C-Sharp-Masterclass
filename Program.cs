using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
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
            Program.Dict();

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

        static void TestingWhileLoop()
        {
            string input;

            do
            {
                Console.Write("Please enter a valid number: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out _));
        }

        static void TypesOfArrays()
        {
            // 2-Dimensional Arrays
            string[,] matrix2D;
            matrix2D = new string[,] { { "Hello World", "It's is me" } };

            // 3-Dimensional Arrays
            int[,,] matrix3D;
            matrix3D = new int[,,]
            {
                { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } },
                { { 9, 10, 11 }, { 11, 12, 13 }, { 12, 13, 14 } },
                { { 15, 16, 17 }, { 16, 17, 18 }, { 17, 18, 19 }, }
            };

            // Console.WriteLine(matrix2D);
            foreach (string sentence in matrix2D)
            {
                Console.WriteLine(sentence);
            }

            Console.WriteLine("---------");

            // foreach (int number in matrix3D) {
            //     Console.WriteLine(number);
            // }

            // for (int i = 0; i < matrix3D.Length; i++) {
            //     Console.WriteLine(matrix3D[i,1,1]);

            // }
            // Console.WriteLine(matrix3D[1,1,2]);

            string[,] array2DString = new string[3, 2]
            {
                { "one", "two" },
                { "three", "four" },
                { "five", "six" }
            };

            // for(int i = 0; i < array2DString.Length; i++) {
            //     Console.WriteLine(array2DString[i,i]);
            // }

            // foreach (string number in array2DString)
            // {
            //     Console.WriteLine(number);
            // }

            // array2DString[1, 1] = "chicken";
            // Console.WriteLine("------");

            // foreach (string number in array2DString)
            // {
            //     Console.WriteLine(number);
            // }

            int dimensions = matrix3D.Rank;
            Console.WriteLine("matrix3D has {0} dimensions", dimensions);

            bool[,,,] bools = { { { { true, false }, { true, false } } } };
        }

        static void NestedLoops()
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine("Before: ");

            foreach (int number in matrix)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine("After: ");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }

                    // Console.Write(matrix[i, j] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("After Diagonal: ");

            // for(int i = 0; i < matrix.GetLength(0); i++) {
            //     for (int j = 0; j < matrix.GetLength(1); j++) {
            //         Console.WriteLine(matrix[i,i]);
            //         Console.WriteLine(matrix[i,matrix.GetLength(1)-1]);
            //         Console.WriteLine();
            //     }
            // }

            for (int i = 0, j = matrix.GetLength(1) - 1; i < matrix.GetLength(0); i++, j--)
            {
                Console.WriteLine(matrix[i, i]);
                Console.WriteLine(matrix[i, j]);
            }
        }

        static void TicTacToeGame()
        {
            string[,] board = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

            int turns = 0;

            while (true)
            {
                Console.WriteLine(
                    @"
┌───┬───┬───┐
│ {0} │ {1} │ {2} │ 
├───┼───┼───┤
│ {3} │ {4} │ {5} │ 
├───┼───┼───┤
│ {6} │ {7} │ {8} │ 
└───┴───┴───┘
                ",
                    board[0, 0],
                    board[0, 1],
                    board[0, 2],
                    board[1, 0],
                    board[1, 1],
                    board[1, 2],
                    board[2, 0],
                    board[2, 1],
                    board[2, 2]
                );

                Console.Write("Player 1: Choose your tile!");
                string playerOneInput = Console.ReadLine();
                if (playerOneInput == "end")
                    return;

                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        if (board[i, j] == playerOneInput)
                        {
                            board[i, j] = "X";
                            break;
                        }
                    }
                }

                Console.Write("Player 2: Choose your tile!");
                string playerTwoInput = Console.ReadLine();
                if (playerTwoInput == "end")
                    return;

                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        if (board[i, j] == playerTwoInput)
                        {
                            board[i, j] = "O";
                            break;
                        }
                    }
                }

                // if(++turns > 3) {


                dynamic currentStatus = Program.TicTacToeChecker(board);

                // if (currentStatus == 0)
                // {
                //     Console.WriteLine("Nobody Wins!");
                //     return;
                // }

                if (currentStatus == "X")
                {
                    Console.WriteLine(
                        @"
┌───┬───┬───┐
│ {0} │ {1} │ {2} │ 
├───┼───┼───┤
│ {3} │ {4} │ {5} │ 
├───┼───┼───┤
│ {6} │ {7} │ {8} │ 
└───┴───┴───┘
                ",
                        board[0, 0],
                        board[0, 1],
                        board[0, 2],
                        board[1, 0],
                        board[1, 1],
                        board[1, 2],
                        board[2, 0],
                        board[2, 1],
                        board[2, 2]
                    );
                    Console.WriteLine("Player One Wins");
                    return;
                }

                if (currentStatus == "O")
                {
                    Console.WriteLine("Player Two Wins");
                    Console.WriteLine(
                        @"
┌───┬───┬───┐
│ {0} │ {1} │ {2} │ 
├───┼───┼───┤
│ {3} │ {4} │ {5} │ 
├───┼───┼───┤
│ {6} │ {7} │ {8} │ 
└───┴───┴───┘
                ",
                        board[0, 0],
                        board[0, 1],
                        board[0, 2],
                        board[1, 0],
                        board[1, 1],
                        board[1, 2],
                        board[2, 0],
                        board[2, 1],
                        board[2, 2]
                    );
                    return;
                }

                if (currentStatus == "Z")
                {
                    continue;
                }
                // }
            }
        }

        static dynamic TicTacToeChecker(dynamic[,] board)
        {
            // int sum = 0;

            // for (int i = 0; i < board.GetLength(0); i++)
            // {
            //     for (int j = 0; j < board.GetLength(1); j++)
            //     {
            //         if (board[i, j] is int)
            //         {
            //             sum += board[i, j];
            //         }
            //     }
            // }

            // if (sum == 0)
            //     return 0;

            // Console.WriteLine(sum);
            // return true;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return board[i, 0];
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return board[0, i];
            }

            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return board[0, 0];
            if (
                board[0, board.GetLength(1) - 1] == board[1, board.GetLength(1) - 2]
                && board[1, 1] == board[2, board.GetLength(1) - 3]
            )
                return board[0, board.GetLength(1) - 1];

            return "Z";
        }

        static void JaggedArray()
        {
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5] { 1, 2, 3, 4, 5 };
            jaggedArray[2] = new int[4] { 22, 23, 25, 21 };
            jaggedArray[1] = new int[3] { 69, 96, 108 };

            // for(int i = 0; i < jaggedArray.Length; i++) {
            //     for(int j = 0; j < jaggedArray[i].Length; j++) {
            //         Console.Write(jaggedArray[i][j] + " ");
            //     }
            // }

            string[][] peopleILove = new string[3][]
            {
                new string[] { "Elijah A", "Kenya C", "Amish P" },
                new string[] { "Ronny V", "Renato M", "Eliot P", "Matthew P" },
                new string[] { "Khalia P", "Jason", "John", "Jason", "Oscar P" }
            };

            // foreach (string[] arrays in peopleILove) {
            //     foreach(string people in arrays) {
            //         Console.WriteLine(people);
            //     }
            // }

            // Console.WriteLine("I will like to introduce {0} to {1}", peopleILove[0][0], peopleILove[1][2]);
            // Console.WriteLine("I will like to introduce {0} to {1}", peopleILove[1][1], peopleILove[2][2]);
        }

        static void Happiness(int[] happiness)
        {
            for (int i = 0; i < happiness.Length; i++)
            {
                happiness[i] += 2;
            }
        }

        static void praticing()
        {
            // IEnumerable<T> Reverse<T>(ICollection<T> data)
            // {
            //     var current = data.Count;
            //     while (current >= 1)
            //     {
            //         current -= 1;
            //         yield return data.ElementAt(current);
            //     }
            // }

            // foreach (var i in Reverse("string".ToList()))
            // {
            //     Console.Write(i + " ");
            // }

            // Color red = Color.Red;

            // Console.WriteLine(red);


            Console.WriteLine(BoldLine.LineWidth);
        }

        public static void ParamsKeyWord(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }

        public static void ListItems(params int[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("{0}) {1}", i, args[i]);
            }
            foreach (object item in args)
            {
                Console.Write(item + " ");
            }
        }

        public static int LowestNumber(params int[] numbers)
        {
            int min = Int32.MaxValue;

            foreach (int number in numbers)
            {
                min = Math.Min(min, number);
            }

            return min;
        }

        static void ArrList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hello World");
            arrayList.Add(100);
            arrayList.Add(true);
            arrayList.Add(50);
            arrayList.Add(25);
            arrayList.Add(false);

            int sumOfArrayList = 0;

            foreach (object item in arrayList)
            {
                if (item is int)
                {
                    sumOfArrayList += (Int32)item;
                }
                else
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("{0} is the sum of the ArrayList", sumOfArrayList);

            ArrayList aL = new ArrayList() { 1, 2, "Hello", true, false };
            aL.Remove(true);
            aL.RemoveAt(0);
            // aL.AddRange(25, 50, 75, 100, 125, 150, 175, 200);
            aL.RemoveRange(0, 2);

            // foreach (object item in aL)
            // {
            //     Console.Write(item + " ");
            // }
        }

        static void hashTables()
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Elijah", 80);
            Student stud3 = new Student(3, "Kenya", 75);
            Student stud4 = new Student(4, "Jason", 45);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);
            studentsTable.Add(5, new Student(5, "Matthew", 25));

            // Console.WriteLine(studentsTable[3].Name); // Error
            Student storedStudent1 = (Student)studentsTable[3];
            Student storedStudent2 = (Student)studentsTable[5];
            // Console.WriteLine(storedStudent2.Name);

            // foreach (DictionaryEntry item  in studentsTable) {
            //     Student student = (Student) item.Value;

            //     Console.WriteLine("Student ID: {0} | Name: {1} | GPA: {2}", student.Id, student.Name, student.GPA);
            // }

            // Console.WriteLine("--------------");

            // foreach (Student student in studentsTable.Values) {
            //     Console.WriteLine("Student ID: {0} | Name: {1} | GPA: {2}", student.Id, student.Name, student.GPA);
            // }

            Student[] students = new Student[5]
            {
                new Student(1, "Denis", 88),
                new Student(2, "Olaf", 97),
                new Student(6, "Ragner", 65),
                new Student(1, "Lusie", 73),
                new Student(4, "Levi", 58),
            };

            Hashtable atte = new Hashtable();

            for (int i = 0; i < students.Length; i++)
            {
                int ID = students[i].Id;

                if (atte.ContainsKey(ID))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Sorry, a student with the same ID:{0} already exits", ID);
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                atte.Add(ID, students[i]);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0} has been registered", students[i].Name);
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine();

            foreach (Student student in atte.Values)
            {
                Console.WriteLine(
                    "Student ID: {0} | Name: {1} | GPA: {2}",
                    student.Id,
                    student.Name,
                    student.GPA
                );
            }
        }

        static void Dict() {

        }
    }
}
