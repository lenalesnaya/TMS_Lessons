using System.Text;
using System.Text.RegularExpressions;

namespace Lessons.Lesson4Tasks
{
    internal static class DocumentIdOperations
    {
        public static void ShowNumericBlocks(string documentId)
        {
            if (IsIdValid(documentId))
            {
                var stringArray = documentId.Split('-');

                Console.WriteLine("\nNumeric blocks:");
                Console.WriteLine($"{stringArray[0]} {stringArray[2]}");
            }
            else
            {
                Console.WriteLine("\nThe Id is unvalid.");
            }
        }

        public static void ReplaceLettersByAsterisk(string documentId)
        {
            if (IsIdValid(documentId))
            {
                var stringArray = documentId.Split('-');
                stringArray[1] = "***";
                stringArray[3] = "***";

                Console.WriteLine("\nThe Id with asterisks instead of letter blocks:");
                Console.WriteLine(String.Join('-', stringArray));
            }
            else
            {
                Console.WriteLine("\nThe Id is unvalid.");
            }
        }

        public static void DeleteNumbersStrangeWay(string documentId)
        {
            if (IsIdValid(documentId))
            {
                var newDocumentId = documentId.Remove(0, 4);
                newDocumentId = newDocumentId.Remove(5, 4);

                for (int i = 0; i < 10; i++)
                {
                    newDocumentId = newDocumentId.Replace($"{i}", "-");
                }

                var stringArray = newDocumentId.Split('-', StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine("\nThe Id without numbers:");
                Console.WriteLine(String.Join('/', stringArray).ToLower());
            }
            else
            {
                Console.WriteLine("\nThe number is unvalid.");
            }
        }

        public static void DeleteNumbersNormalWay(string documentId)
        {
            if (IsIdValid(documentId))
            {
                var str = new StringBuilder(documentId);
                for (int i = 0; i < 10; i++)
                {
                    str.Replace($"{i}", "-");
                }

                var stringArray = str.ToString().Split('-', StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine("\nLetters: " + String.Join('/', stringArray).ToUpper());
            }
            else
            {
                Console.WriteLine("\nThe number is unvalid.");
            }
        }

        public static void IsContainAbc(string documentId)
        {
            if (IsIdValid(documentId))
            {
                if (documentId.Contains("abc", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("\nThe Id contains \"abc\".");
                }
                else
                {
                    Console.WriteLine("\nThe Id doesn`t contain \"abc\".");
                }
            }
            else
            {
                Console.WriteLine("\nThe number is unvalid.");
            }
        }

        public static void IsStartWith555(string documentId)
        {
            if (IsIdValid(documentId))
            {
                if (documentId.StartsWith("555"))
                {
                    Console.WriteLine("\nThe Id starts with \"555\".");
                }
                else
                {
                    Console.WriteLine("\nThe Id doesn`t start with \"555\".");
                }
            }
            else
            {
                Console.WriteLine("\nThe number is unvalid.");
            }
        }

        public static void IsEndWith1a2b(string documentId)
        {
            if (IsIdValid(documentId))
            {
                if (documentId.EndsWith("1a2b", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("\nThe Id ends with \"1a2b\".");
                }
                else
                {
                    Console.WriteLine("\nThe Id doesn`t end with \"1a2b\".");
                }
            }
            else
            {
                Console.WriteLine("\nThe number is unvalid.");
            }
        }


        private static bool IsIdValid(string documentId)
        {
            var regex = new Regex("^\\d{4}-[A-Za-z]{3}-\\d{4}-[A-Za-z]{3}-(\\d[A-Za-z]){2}$", RegexOptions.IgnoreCase);
            return regex.IsMatch(documentId);
        }
    }
}