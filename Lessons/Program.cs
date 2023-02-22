﻿namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            L1T1_GreetName();
            L2T1_СalculateTwoNumbers();
            L2T2_DetermineTheRange();
        }


        #region Lesson_1
        public static void L1T1_GreetName()
        {
            Console.WriteLine("Who do you want to greet?:");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
        }
        #endregion


        #region Lesson_2
        public static void L2T1_СalculateTwoNumbers()
        {
            int operand1 = 420;
            int operand2 = 5;
            int result;

            Console.WriteLine("\nPlease, enter arithmetic operation sign (+, -, * or /)");

            string sign = Console.ReadLine();
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

        public static void L2T2_DetermineTheRange()
        {
            Console.WriteLine("\nPlease, enter a number in a range from 0 to 100:");

            bool canBeParsed = int.TryParse(Console.ReadLine(), out int number);
            if (canBeParsed && number >= 0 && number <= 100)
            {
                if (number <= 14)
                    Console.WriteLine("Your number is in the range from 0 to 14");
                else if (number <= 35)
                    Console.WriteLine("Your number is in the range from 15 to 35");
                else if (number <= 50)
                    Console.WriteLine("Your number is in the range from 36 to 50");
                else
                    Console.WriteLine("Your number is in the range from 51 to 100");
            }
            else
                Console.WriteLine("You must enter a number in a range from 0 to 100!");
        }
        #endregion
    }
}