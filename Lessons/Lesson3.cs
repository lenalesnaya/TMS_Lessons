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
    }
}