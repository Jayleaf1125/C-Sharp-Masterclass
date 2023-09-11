using TwoNumberCalculator;

namespace DeplouCalc
{
    class RunCalc
    {
        public static void DeployCalc()
        {
            Console.WriteLine("First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What operation do you want to run on the two numbers");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "addition":
                    Calculator.Addition(num1, num2);
                    break;
                case "subtraction":
                    Calculator.Subtraction(num1, num2);
                    break;
                case "multiplication":
                    Calculator.Multiplication(num1, num2);
                    break;
                case "divison":
                    Calculator.Division(num1, num2);
                    break;
                case "remainder":
                    Calculator.FindRemainder(num1, num2);
                    break;
                case "flip 1":
                    Calculator.FlipSign(num1);
                    break;
                case "flip 2":
                    Calculator.FlipSign(num2);
                    break;
            }
        }
    }
}
