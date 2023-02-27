namespace Lessons
{
    public class Lesson3
    {
        public static void Task1_FindNumberInArray()
        {
            Console.WriteLine("\nTask 1.\n");
            var random = new Random();
            var array = new long[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextInt64();
                Console.WriteLine($"{array[i]} ");
            }

            Console.WriteLine("\nEnter a number you want to find:");
            var numberIsParsed = long.TryParse(Console.ReadLine(), out long number);

            if(!numberIsParsed)
            {
                Console.WriteLine("\nYou entered an invalid value!");
                return;
            }

            var isNumberInArray = false;
            foreach (long element in array)
            {
                if(element == number)
                {
                    Console.WriteLine($"\nNumber {number} is in the array ;)");
                    isNumberInArray = true;
                    break;
                }
            }

            if (isNumberInArray == false)
            {
                Console.WriteLine($"\nThere isn`t number {number} in the array.");
            }
        }

        public static void Task2_DeleteNumberFromArray()
        {
            Console.WriteLine("\nTask 2.\n");
            var array = new int[] { 8, 10, 7778, 7778, 7778, 8, 25885, 28, 6354, 401, 28, 6, 7, 8, 5695, 8, 12, 8 };

            Console.WriteLine("Initial array:");
            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine("\n\nEnter a number you want to delete:");
            var numberIsParsed = int.TryParse(Console.ReadLine(), out int number);

            if (!numberIsParsed)
            {
                Console.WriteLine("\nYou entered an invalid value!");
                return;
            }

            var newArrayElementsCounter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != number)
                {
                    array[newArrayElementsCounter++] = array[i];
                }
            }

            if(newArrayElementsCounter == array.Length)
            {
                Console.WriteLine("\nThis number is not in the array.");
                return;
            }

            Console.WriteLine("Final array:");
            var newArray = new int[newArrayElementsCounter];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i];
                Console.Write($"{newArray[i]} ");
            }
        }

        public static void Task3_FindMinMaxAverageValuesOfArray()
        {
            Console.WriteLine("\nTask 3.\n");
            Console.WriteLine("\nHow many elements will be in your array?");

            var numberOfElementsIsParsed = int.TryParse(Console.ReadLine(), out int numberOfElements);
            if (!numberOfElementsIsParsed)
            {
                Console.WriteLine("\nYou entered an invalid value!");
                return;
            }

            var random = new Random();
            var array = new int[numberOfElements];

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 50);
                Console.WriteLine($"{array[i]} ");
            }

            var maxValue = array[0];
            var minValue = array[0];
            var sumOfElements = array[0];

            for(int i = 1; i < array.Length; i++)
            {
                sumOfElements += array[i];
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
                else if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            var averageValue = (double)sumOfElements / (double)array.Length;

            Console.WriteLine($"\nMax value: {maxValue}\nMin value: {minValue}\nAverage value: {averageValue}");
        }

        public static void Task4_CompareAverageValuesOfArrays()
        {
            Console.WriteLine("\nTask 4.\n");

            var firstArray = new double[] { 55.0, 28.123, 70.2, 50.028, 3.7 };
            var secondArray = new double[] { 775.23, 88.1, 90.0, 80.8, 5.7 };
            var sumOfFirstArrayElements = 0.0;
            var sumOfSecondArrayElements = 0.0;

            Console.WriteLine("First array:");
            for (int i = 0; i < firstArray.Length; i++)
            {
                sumOfFirstArrayElements += firstArray[i];
                Console.Write($"{firstArray[i]} ");
            }

            Console.WriteLine("\nSecond array:");
            for (int i = 0; i < secondArray.Length; i++)
            {
                sumOfSecondArrayElements += secondArray[i];
                Console.Write($"{secondArray[i]} ");
            }

            var firstArrayAverageValue = Math.Round(sumOfFirstArrayElements / firstArray.Length, 2);
            var secondArrayAverageValue = Math.Round(sumOfSecondArrayElements / secondArray.Length, 2);

            Console.WriteLine();
            if (firstArrayAverageValue > secondArrayAverageValue)
            {
                Console.WriteLine(
                    $"\nAn average value of the first array ({firstArrayAverageValue}) is greater than of the second array ({secondArrayAverageValue}).");
            }
            else if (firstArrayAverageValue < secondArrayAverageValue)
            {
                Console.WriteLine(
                    $"\nAn average value of the first array ({firstArrayAverageValue}) is less than of the second array ({secondArrayAverageValue}).");
            }
            else
            {
                Console.WriteLine(
                    $"\nAverage values ​​of the first ({firstArrayAverageValue}) and second ({secondArrayAverageValue}) arrays are equal.");
            }
        }
    }
}