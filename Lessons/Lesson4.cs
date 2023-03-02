using System.Text;

namespace Lessons
{
    public class Lesson4
    {
        public static void Task1_RemoveNumbersAndReplaceWord()
        {
            Console.WriteLine("\nTask 1.\n");

            var str = new StringBuilder("I 0like test, I l5ove te4st, I'7m tired of test, I ha22te test");
            Console.WriteLine(str);

            for (int i = 0; i < 10; i++)
            {
                str.Replace($"{i}", "");
            }

            Console.WriteLine(str);

            str.Replace("test", "testing");
            Console.WriteLine(str);
        }

        public static void Task2_PrintPhraseUsingConcatenation()
        {
            Console.WriteLine("\nTask 2.\n");
            Console.WriteLine("Welcome " + "to " + "the " + "TMS " + "lessons");
        }

        public static void Task3_TakeStringParts()
        {
            Console.WriteLine("\nTask 3.\n");

            var str = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            Console.WriteLine($"Initial string: \n{str}");

            var index = str.IndexOf("abc");
            var beforeAbc = str[..index];
            Console.WriteLine($"\nString before abc: \n{beforeAbc}");

            var afterAbc = str[(index + 3)..];
            Console.WriteLine($"\nString after abc: \n{afterAbc}");
        }

        public static void Task4_FromBadDayToGoodDay()
        {
            Console.WriteLine("\nTask 4.\n");

            var str = "Bad day";
            var index = str.IndexOf("Bad");
            var withoutBad = str.Substring(index + 3);

            var goodDay = new StringBuilder(withoutBad);
            goodDay.Insert(0, "Good");
            goodDay.Insert(goodDay.Length, "!!!!!!!!!");
            goodDay[^1] = '?';

            Console.WriteLine(goodDay);
        }

        public static void Task5_HandleDocumentIdOperations()
        {
            Console.WriteLine("\nTask 5.\n");

            var documentId = "5504-LLO-2200-ABC-1A2B";
            Console.WriteLine("Initial string:");
            Console.WriteLine(documentId);

            DocumentIdOperations.ShowNumericBlocks(documentId);
            DocumentIdOperations.ReplaceLettersByAsterisk(documentId);
            DocumentIdOperations.DeleteNumbersStrangeWay(documentId);
            DocumentIdOperations.DeleteNumbersNormalWay(documentId);
            DocumentIdOperations.IsContainAbc(documentId);
            DocumentIdOperations.IsStartWith555(documentId);
            DocumentIdOperations.IsEndWith1a2b(documentId);
        }
    }
}