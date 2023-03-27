namespace Lessons.Additional
{
    internal class AdditionalTasks
    {
        public static void Task1_FindSecondMaximumNumber()
        {
            int[] intArray = { 2, 1, 5, 3, 4, 5 };

            var maxValue = GetMaxValue(intArray);
            var secondMaxValue = GetSecondMaxValue(intArray, maxValue);

            Console.WriteLine($"Second max value is {secondMaxValue}");
        }

        private static int GetMaxValue(int[] array)
        {
            var maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }

        private static int GetSecondMaxValue(int[] array, int maxValue)
        {
            var secondMaxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > secondMaxValue)
                {
                    if (array[i] != maxValue)
                    {
                        secondMaxValue = array[i];
                    }
                }
            }

            return secondMaxValue;
        }

        public static void Task2_SeparateZerosAndOnes()
        {
            var array = new []{ 0, 1, 0, 1 };
            var zerosCount = MoveZerosLeft(array);
            MoveOnesRight(array, zerosCount);
            PrintArray(array);

            array = new[] { 1, 1, 0, 1, 1, 1, 0 };
            zerosCount = MoveZerosLeft(array);
            MoveOnesRight(array, zerosCount);
            PrintArray(array);
        }

        private static int MoveZerosLeft(int[] array)
        {
            var zerosCounter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    array[zerosCounter++] = array[i];
                }
            }

            return zerosCounter;
        }

        private static void MoveOnesRight(int[] array, int zerosCounter)
        {
            for (int i = zerosCounter; i < array.Length; i++)
            {
                array[i] = 1;
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

            int total = 0;
            int partialSum = 0;
            int arrayLength = array.Length;

            var dict = new Dictionary<int, int>
            {
                { 0, 1 }
            };

            for (int i = 0; i < arrayLength; i++)
            {
                partialSum += array[i];

                if (dict.ContainsKey(partialSum - number))
                {
                    total += dict[partialSum - number];
                }

                if (total > 1)
                {
                    break;
                }

                if (!dict.ContainsKey(partialSum))
                {
                    dict[partialSum] = 0;
                }
                dict[partialSum] += 1;
            }

            var result = total > 0 ?
                "\nSequence is found" :
                "\nSequence isn`t found";
            Console.WriteLine(result);
        }
    }
}