namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            L1T1_HelloName();
            L2T1_Сalculator();
        }


        #region Lesson_1
        public static void L1T1_HelloName()
        {
            Console.WriteLine("Who do you want to greet?:");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
        }
        #endregion


        #region Lesson_2
        public static void L2T1_Сalculator()
        {
            int operand1 = 420;
            int operand2 = 5;
            string sign;
            int result;

            Console.WriteLine("\nPlease, enter arithmetic operation sign (+, -, * or /)");
            sign = Console.ReadLine();

            switch(sign)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("You can't divide by zero!");
                        return;
                    }
                    else
                    {
                        result = operand1 / operand2;
                    }
                    break;
                default:
                    Console.WriteLine("You entered an invalid character.");
                    return;
            }

            Console.WriteLine($"Result: {result}");
        }
        #endregion
    }
}