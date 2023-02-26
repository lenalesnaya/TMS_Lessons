namespace Lessons
{
    public static class Lesson2
    {
        public static void Task1_СalculateTwoNumbers()
        {
            int operand1 = 420;
            int operand2 = 5;
            int result;
            string sign;

            Console.WriteLine("\nPlease, enter arithmetic operation sign (+, -, * or /)");
            sign = Console.ReadLine();
            switch (sign)
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

        public static void Task2_DetermineTheRange()
        {
            Console.WriteLine("\nPlease, enter a number in a range from 0 to 100:");
            bool numberIsParsed = int.TryParse(Console.ReadLine(), out int number);

            if (numberIsParsed && (number >= 0) && (number <= 100))
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

        public static void Task3_TranslateFromRusToEng()
        {
            string word;
            string translate;

            Console.WriteLine("\nPlease, enter your word in Russian:");
            word = Console.ReadLine();
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

        public static void Task4_DetermineParityOfNumberVariant1()
        {
            Console.WriteLine("\nPlease, enter an integer number:");
            bool numberIsParsed = long.TryParse(Console.ReadLine(), out long number);

            if (numberIsParsed)
            {
                Console.WriteLine(IsEven(number) ?
                    "Your number is even" :
                    "Your number is uneven");
            }
            else
            {
                Console.WriteLine("You entered an invalid value!");
            }
        }

        public static void Task4_DetermineParityOfNumberVariant2()
        {
            Console.WriteLine("\nPlease, enter an integer number:");
            bool numberIsParsed = long.TryParse(Console.ReadLine(), out long number);

            if (numberIsParsed)
            {
                Math.DivRem(number, 2, out long remainder);
                Console.WriteLine(remainder == 0 ?
                    "Your number is even" :
                    "Your number is uneven");
            }
            else
            {
                Console.WriteLine("You entered an invalid value!");
            }
        }

        public static void Task4_DetermineParityOfNumberVariant3()
        {
            Console.WriteLine("\nPlease, enter an integer number:");
            bool numberIsParsed = long.TryParse(Console.ReadLine(), out long number);

            if (numberIsParsed)
            {
                Console.WriteLine((number & 1) == 0 ?
                    "Your number is even" :
                    "Your number is uneven");
            }
            else
            {
                Console.WriteLine("You entered an invalid value!");
            }
        }

        public static void Task5_DetermineIfTriangleAcuteAngled()
        {
            Console.WriteLine("\nFirst side of the triangle:");
            bool xIsParsed = double.TryParse(Console.ReadLine(), out double x);

            Console.WriteLine("Second side of the triangle:");
            bool yIsParsed = double.TryParse(Console.ReadLine(), out double y);

            Console.WriteLine("Third side of the triangle:");
            bool zIsParsed = double.TryParse(Console.ReadLine(), out double z);

            if (xIsParsed && yIsParsed && zIsParsed)
            {
                if ((x > 0) && (y > 0) && (z > 0) && ((x + y) > z) && ((y + z) > x) && ((x + z) > y))
                {
                    double maxSide = x;
                    double secondSide = y;
                    double thirdSide = z;

                    if (y > maxSide)
                    {
                        maxSide = y;
                        secondSide = x;
                        thirdSide = z;
                    }
                    if (z > maxSide)
                    {
                        maxSide = z;
                        secondSide = x;
                        thirdSide = y;
                    }

                    if (maxSide * maxSide == secondSide * secondSide + thirdSide * thirdSide)
                    {
                        Console.WriteLine("\nNo, it's a right triangle.");
                    }
                    else if (maxSide * maxSide > secondSide * secondSide + thirdSide * thirdSide)
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

        public static void Task6_ChangeValuesOfNumbers()
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
                if ((a <= b) && (b <= c) && (c <= d))
                {
                    double maxValue = Math.Max(Math.Max(a, b), Math.Max(c, d));
                    a = b = c = d = maxValue;
                }
                else if (!((a > b) && (b > c) && (c > d)))
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

        public static void Task7_DetermineChessFieldsСorrespondence()
        {
            Console.WriteLine("\nVertical coordinate of the first field (1-8):");
            bool firstFieldVerticalIsParsed = sbyte.TryParse(Console.ReadLine(),
                out sbyte firstFieldVertical);

            Console.WriteLine("Horizontal coordinate of the first field (1-8):");
            bool firstFieldHorizontalIsParsed = sbyte.TryParse(Console.ReadLine(),
                out sbyte firstFieldHorizontal);

            Console.WriteLine("Vertical coordinate of the second field (1-8):");
            bool secondFieldVerticalIsParsed = sbyte.TryParse(Console.ReadLine(),
                out sbyte secondFieldVertical);

            Console.WriteLine("Horizontal coordinate of the second field (1-8):");
            bool secondFieldHorizontalIsParsed = sbyte.TryParse(Console.ReadLine(),
                out sbyte secondFieldHorizontal);

            if (firstFieldVerticalIsParsed && firstFieldHorizontalIsParsed &&
                secondFieldVerticalIsParsed && secondFieldHorizontalIsParsed)
            {
                if ((firstFieldVertical > 0) && (firstFieldVertical < 9) &&
                    (firstFieldHorizontal > 0) && (firstFieldHorizontal < 9) &&
                    (secondFieldVertical > 0) && (secondFieldVertical < 9) &&
                    (secondFieldHorizontal > 0) && (secondFieldHorizontal < 9))
                {
                    int firstFieldSum = firstFieldVertical + firstFieldHorizontal;
                    int secondFieldSum = secondFieldVertical + secondFieldHorizontal;

                    if (IsEven(firstFieldSum) == IsEven(secondFieldSum))
                    {
                        Console.WriteLine("\nThese fields are the same color.");
                    }
                    else
                    {
                        Console.WriteLine("\nThese fields are not the same color.");
                    }

                    int verticalDistance = Math.Abs(firstFieldVertical - secondFieldVertical);
                    int horizontalDistance = Math.Abs(firstFieldHorizontal - secondFieldHorizontal);

                    if (((verticalDistance == 1) && (horizontalDistance == 2)) ||
                        ((verticalDistance == 2) && (horizontalDistance == 1)))
                    {
                        Console.WriteLine("\nA khight from the first field threaten the second field!");
                    }
                    else
                    {
                        Console.WriteLine("\nA khight from the first field doesn`t threaten the second field.");
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


        private static bool IsEven(long value)
        {
            return value % 2 == 0;
        }
    }
}