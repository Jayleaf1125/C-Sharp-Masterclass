namespace Section5
{
    class Sec5
    {
        static int highScore = 100;
        static string highScorePlayerName = "Jason";

        public static void CalculateAverageScore()
        {
            int averageScore = 0,
                numOfStudents = 0;

            while (true)
            {
                Console.Write("Enter student grade: ");
                int inputVal;

                if (Int32.TryParse(Console.ReadLine(), out inputVal))
                {
                    if (inputVal == -1)
                        break;
                    if (inputVal > 20 || inputVal < -1)
                    {
                        Console.WriteLine("Grades can only be in the range of 0 and 20");
                        continue;
                    }

                    averageScore += inputVal;
                    numOfStudents += 1;
                }
                else
                {
                    Console.WriteLine("Only enter numbers");
                }
            }

            Console.WriteLine(
                "Average Score is {0} among a class of {1}",
                (averageScore / numOfStudents),
                numOfStudents
            );
        }

        public static void ChainingTernaryOpereators()
        {
            /*
                Ternary Operators:
                condition ? iftrue : iffalse
            */

            Console.Write("Enter temperature: ");
            string userInput = Console.ReadLine();
            int temperature;

            if (int.TryParse(userInput, out temperature))
            {
                Console.WriteLine(
                    temperature <= 15
                        ? "it is too cold here"
                        : (temperature >= 16 && temperature <= 28)
                            ? "it is ok"
                            : temperature > 28
                                ? "it is hot here"
                                : ""
                );
            }
            else
            {
                Console.WriteLine("Not a valid Temperature.");
            }
        }

        public static void GameCheck(int score, string playerName)
        {
            if (score > highScore)
            {
                Console.WriteLine("New highscore: {0}", score);
                Console.WriteLine("New highscore holder: {0}", playerName);
                highScore = score;
                highScorePlayerName = playerName;
            }
            else
            {
                Console.WriteLine(
                    "The old highscore of {0} could not be broken and is still held by {1}",
                    highScore,
                    highScorePlayerName
                );
            }
        }

        // Account Hard-Code Login/Sign-Up

        public static void AccountSystem()
        {
            string userNameDataBase = "Jayleaf1125";
            string passwordDataBase = "Password123";

            bool runAccount = true;

            while (runAccount)
            {
                Console.WriteLine("Login or Register?");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "Login":
                        Login(userNameDataBase, passwordDataBase);
                        break;
                    case "Register":
                        string[] newInfo = Register();
                        userNameDataBase = newInfo[0];
                        passwordDataBase = newInfo[1];
                        Console.WriteLine(
                            "You have registered a new account. Existing account has been terminated"
                        );
                        break;
                    case "end":
                        return;
                    default:
                        break;
                }
            }
        }

        public static string[] Register()
        {
            Console.Write("New Login: ");
            string newUserName = Console.ReadLine();
            Console.Write("New Password: ");
            string newPassword = Console.ReadLine();

            return new string[2] { newUserName, newPassword };
        }

        public static void Login(string userName, string password)
        {
            Console.Write("Enter Login: ");
            string userNameInputVal = Console.ReadLine();
            Console.Write("Enter Password: ");
            string passwordInputVal = Console.ReadLine();

            Console.WriteLine("");

            if ((userName == userNameInputVal) && (password == passwordInputVal))
            {
                Console.WriteLine("User Logged In!");
            }
            else
            {
                Console.WriteLine("User cannot be logged in!");
            }
        }

        public static void LearnTryParse()
        {
            Console.WriteLine("Type in a value: ");
            string inputVal = Console.ReadLine();
            int val;

            if (int.TryParse(inputVal, out val))
            {
                Console.WriteLine("We converted {0} into a number type", val);
            }
            else
            {
                Console.WriteLine("We cannot convert {0} into a number", val);
                val = 0;
            }

            Console.WriteLine("---------------");

            if (val < 21)
            {
                Console.WriteLine("You cannot drink!");
            }
            else
            {
                Console.WriteLine("You can drink! Take a shot with me!");
            }
        }
    }
}
