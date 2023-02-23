namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            L1T1_GreetName();
            L2T1_СalculateTwoNumbers();
            L2T2_DetermineTheRange();
            L2T3_TranslateFromRusToEng();
            L2T4_DetermineParityOfNumberVar1();
            L2T4_DetermineParityOfNumberVar2();
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

        public static void L2T3_TranslateFromRusToEng()
        {
            Console.WriteLine("\nPlease, enter your word in Russian:");

            string word = Console.ReadLine();
            string translate;
            switch (word)
            {
                case "дождь":
                    translate = "rain";
                    break;
                case "ветер":
                    translate = "wind";
                    break;
                case "солнце":
                    translate = "sun";
                    break;
                case "снег":
                    translate = "snow";
                    break;
                case "ураган":
                    translate = "hurricane";
                    break;
                case "мороз":
                    translate = "freezing";
                    break;
                case "зной":
                    translate = "heat";
                    break;
                case "туман":
                    translate = "fog";
                    break;
                case "метель":
                    translate = "blizzard";
                    break;
                case "морось":
                    translate = "drizzle";
                    break;
                default:
                    Console.WriteLine("Sorry, I don`t know this word :\\");
                    return;
            }

            Console.WriteLine(translate);
        }

        public static void L2T4_DetermineParityOfNumberVar1()
        {
            Console.WriteLine("\nPlease, enter an integer number:");

            bool canBeParsed = long.TryParse(Console.ReadLine(), out long number);
            if (canBeParsed)
                Console.WriteLine(number % 2 == 0 ? "Your number is even" : "Your number is uneven");
            else
                Console.WriteLine("You entered an invalid value!");
        }

        public static void L2T4_DetermineParityOfNumberVar2()
        {
            Console.WriteLine("\nPlease, enter an integer number:");

            bool canBeParsed = long.TryParse(Console.ReadLine(), out long number);
            if (canBeParsed)
            {
                Math.DivRem(number, 2, out long remainder);
                Console.WriteLine(remainder == 0 ? "Your number is even" : "Your number is uneven");
            }
            else
                Console.WriteLine("You entered an invalid value!");
        }
        #endregion
    }
}