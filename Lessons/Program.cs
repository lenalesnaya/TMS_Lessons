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
            L2T5_DetermineIfTriangleAcuteAngled();
            L2T6_ChangeValuesOfNumbers();
            L2T7_DetermineChessFieldsСorrespondence();
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
                {
                    Console.WriteLine("Your number is in the range from 0 to 14");
                }
                else if (number <= 35)
                {
                    Console.WriteLine("Your number is in the range from 15 to 35");
                }
                else if (number <= 50)
                {
                    Console.WriteLine("Your number is in the range from 36 to 50");
                }
                else
                {
                    Console.WriteLine("Your number is in the range from 51 to 100");
                }
            }
            else
            {
                Console.WriteLine("You must enter a number in a range from 0 to 100!");
            }
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
            {
                Console.WriteLine(number % 2 == 0 ? "Your number is even" : "Your number is uneven");
            }
            else
            {
                Console.WriteLine("You entered an invalid value!");
            }
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
            {
                Console.WriteLine("You entered an invalid value!");
            }
        }

        public static void L2T5_DetermineIfTriangleAcuteAngled()
        {
            Console.WriteLine("\nFirst side of the triangle:");
            bool xIsParsed = double.TryParse(Console.ReadLine(), out double x);

            Console.WriteLine("Second side of the triangle:");
            bool yIsParsed = double.TryParse(Console.ReadLine(), out double y);

            Console.WriteLine("Third side of the triangle:");
            bool zIsParsed = double.TryParse(Console.ReadLine(), out double z);

            if (xIsParsed && yIsParsed && zIsParsed)
            {
                if (x > 0 && y > 0 && z > 0 && (x + y) > z && (y + z) > x && (x + z) > y)
                {
                    double max = x;
                    double second = y;
                    double third = z;

                    if (y > max)
                    {
                        max = y;
                        second = x;
                        third = z;
                    }
                    if(z > max)
                    {
                        max = z;
                        second = x;
                        third = y;
                    }

                    if (max * max == second * second + third * third)
                    {
                        Console.WriteLine("\nNo, it's a right triangle.");
                    }
                    else if (max * max > second * second + third * third)
                    {
                        Console.WriteLine("\nNo, it's an obtuse triangle.");
                    }
                    else
                    {
                        Console.WriteLine("\nYes, it's an acute triangle.");
                    }
                }
                else
                {
                    Console.WriteLine("\nSuch a triangle cannot exist.");
                }
            }
            else
            {
                Console.WriteLine("\nYou entered an invalid value!");
            }
        }

        public static void L2T6_ChangeValuesOfNumbers()
        {
            Console.WriteLine("\nPlease, enter numbers:");
            Console.WriteLine("\nA:");
            bool aIsParsed = double.TryParse(Console.ReadLine(), out double a);

            Console.WriteLine("B:");
            bool bIsParsed = double.TryParse(Console.ReadLine(), out double b);

            Console.WriteLine("C:");
            bool cIsParsed = double.TryParse(Console.ReadLine(), out double c);

            Console.WriteLine("D:");
            bool dIsParsed = double.TryParse(Console.ReadLine(), out double d);

            if (aIsParsed && bIsParsed && cIsParsed && dIsParsed)
            {
                if(a <= b && b <= c && c <= d)
                {
                    double max = Math.Max(Math.Max(a, b), Math.Max(c, d));
                    a = b = c = d = max;
                }
                else if(!(a > b && b > c && c > d))
                {
                    a = Math.Pow(a, 2);
                    b = Math.Pow(b, 2);
                    c = Math.Pow(c, 2);
                    d = Math.Pow(d, 2);
                }

                Console.WriteLine($"Result: {a}, {b}, {c}, {d}");
            }
            else
            {
                Console.WriteLine("\nYou entered an invalid value!");
            }
        }

        public static void L2T7_DetermineChessFieldsСorrespondence()
        {
            Console.WriteLine("\nPlease, enter vertical coordinate of the first field (1-8):");
            bool kIsParsed = byte.TryParse(Console.ReadLine(), out byte fVert);

            Console.WriteLine("\nPlease, enter horizontal coordinate of the first field (1-8):");
            bool lIsParsed = byte.TryParse(Console.ReadLine(), out byte fHor);

            Console.WriteLine("\nPlease, enter vertical coordinate of the second field (1-8):");
            bool mIsParsed = byte.TryParse(Console.ReadLine(), out byte sVert);

            Console.WriteLine("\nPlease, enter horizontal coordinate of the second field (1-8):");
            bool nIsParsed = byte.TryParse(Console.ReadLine(), out byte sHor);

            if (kIsParsed && lIsParsed && mIsParsed && nIsParsed)
            {
                if(fVert > 0 && fVert < 9 && fHor > 0 && fHor < 9 && sVert > 0 && sVert < 9 && sHor > 0 && sHor < 9)
                {
                    if((IsEven(fVert) == IsEven(fHor) && IsEven(sVert) == IsEven(sHor)) ||
                        (IsEven(fVert) != IsEven(fHor) && IsEven(sVert) != IsEven(sHor)))
                    {
                        Console.WriteLine("\nThese fields are the same color.");
                    }
                    else
                    {
                        Console.WriteLine("\nThese fields are not the same color.");
                    }
                }
                else
                {
                    Console.WriteLine("\nYour numbers don`t match the given range!");
                }
            }
            else
            {
                Console.WriteLine("\nYou entered an invalid value!");
            }
        }

        private static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
        #endregion
    }
}