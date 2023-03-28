namespace Lessons.Additional
{
    internal class AdditionalTasks
    {
        public static void Task1_FindSecondMaximumNumber()
        {
            int[] intArray = { 2, 1, 5, 3, 4, 5 };
            Console.WriteLine($"Second max value is {GetSecondMaxValue(intArray)}");
        }

        private static int GetSecondMaxValue(int[] array)
        {
            var maxValue = array[0];
            var secondMaxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
                if (array[i] < maxValue && array[i] > secondMaxValue)
                {
                    secondMaxValue = array[i];
                }
            }

            return secondMaxValue;
        }

        public static void Task2_MoveZerosLeft()
        {
            var array = new []{ 0, 1, 0, 1 };
            MoveZerosLeft(array);
            PrintArray(array);

            array = new[] { 1, 1, 0, 1, 1, 1, 0 };
            MoveZerosLeft(array);
            PrintArray(array);

            array = new[] { 0, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0 };
            MoveZerosLeft(array);
            PrintArray(array);
        }

        private static void MoveZerosLeft(int[] array)
        {
            var zerosCounter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    if (array[zerosCounter] == 1)
                    {
                        array[zerosCounter] = array[i];
                        array[i] = 1;
                    }

                    zerosCounter++;
                }
            }
        }

        private static void PrintArray(int[] array)
        {
            Console.WriteLine();
            foreach (var element in array)
            {
                Console.Write($"{element}\t");
            }
            Console.WriteLine();
        }

        public static void Task3_FindSpecifiedSequenceBySum()
        {
            var array = new int[] { 2, 3, 9, 4, 7, 16, 1, 18, 10, 4 };
            var number = 20;

            bool coincidence = false;
            var partialSum = 0;

            var list = new List<int>() { 0 };
            for (int i = 0; i < array.Length; i++)
            {
                partialSum += array[i];
                if (list.Contains(partialSum - number))
                {
                    coincidence = true;
                    break;
                }

                list.Add(partialSum);
            }

            Console.WriteLine(coincidence == true ?
                "\nSequence is found" :
                "\nSequence isn`t found");
        }
    }
}