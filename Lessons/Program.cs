using Lessons.Lesson4Tasks;
using Lessons.Lesson5Tasks;
using Lessons.Lesson6Tasks;
using Lessons.Lesson8Tasks;
using Lessons.Lesson9Tasks;
using Lessons.Additional;


namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nLesson1.\n");
            Lesson1.Task1_GreetName();

            Console.WriteLine("\nLesson2.\n");
            Lesson2.Task1_СalculateTwoNumbers();
            Lesson2.Task2_DetermineTheRange();
            Lesson2.Task3_TranslateFromRusToEng();
            Lesson2.Task4_DetermineParityOfNumberVariant1();
            Lesson2.Task4_DetermineParityOfNumberVariant2();
            Lesson2.Task4_DetermineParityOfNumberVariant3();
            Lesson2.Task5_DetermineIfTriangleAcuteAngled();
            Lesson2.Task6_ChangeValuesOfNumbers();
            Lesson2.Task7_DetermineChessFieldsСorrespondence();

            Console.WriteLine("\nLesson3.\n");
            Lesson3.Task1_FindNumberInArray();
            Lesson3.Task2_DeleteNumberFromArray();
            Lesson3.Task3_FindMinMaxAverageValuesOfArray();
            Lesson3.Task4_CompareAverageValuesOfArrays();
            Lesson3.Task5_CopyEvenNumbersInNewArray();
            Lesson3.Task6_ReplaceElementsWithOddIndexToZero();
            Lesson3.Task7_SortStringArray();
            Lesson3.Task8_SortByBubble();
            Lesson3.Task9_MultiplyMatrices();
            Lesson3.Task10_CalculateMatrixElementsSum();
            Lesson3.Task11_PrintMatrixDiagonals();
            Lesson3.Task12_SortMatrixRows();

            Console.WriteLine("\nLesson4.\n");
            Lesson4.Task1_RemoveNumbersAndReplaceWord();
            Lesson4.Task2_PrintPhraseUsingConcatenation();
            Lesson4.Task3_TakeStringParts();
            Lesson4.Task4_FromBadDayToGoodDay();
            Lesson4.Task5_HandleDocumentIdOperations();

            Console.WriteLine("\nLesson5.\n");
            Lesson5.Task1_UsePhoneClass();
            Lesson5.Task2_UseCreditCardClass();
            Lesson5.Task3_UseATM();
            Lesson5.Task4_UseClinic();

            Console.WriteLine("\nLesson6.\n");
            Lesson6.Task1_UseGeometricFigures();
            Lesson6.Task2_UseClinic();
            Lesson6.Task3_UseTransportPark();
            Lesson6.Task4_UseAutoService();

            Console.WriteLine("\nLesson8.\n");
            Lesson8.Task1_UseRegistrationDataValidation();

            Console.WriteLine("\nLesson9.\n");
            Lesson9.Task0_CatchArgumentOutOfRangeException();
            Lesson9.Task0_PrintDictionary();
            Lesson9.Task1_UseStore();

            Console.WriteLine("\nAdditional tasks.\n");
            AdditionalTasks.Task1_FindSecondMaximumNumber();
            AdditionalTasks.Task2_SeparateZerosAndOnes();
            AdditionalTasks.Task3_FindSpecifiedSequenceBySum();
        }
    }
}