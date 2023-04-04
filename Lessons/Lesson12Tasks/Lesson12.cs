namespace Lessons.Lesson12Tasks
{
    internal class Lesson12
    {
        public static void Task1_UseLinq()
        {
            Console.WriteLine("\nTask 1.\n");

            Console.WriteLine(GetFirstOneLetterWord("I'm just a dreamer, I dream my life away.") ?? "No one-letter words.");
            Console.WriteLine(GetLastEeContainingWord("Sun is shining, the weather is sweet, yeeah.") ?? "No \"ee\" containing words.");
            Console.WriteLine(GetLastCertainLengthWord(
                "Don't worry about a thing,'cause every little thing gonna be all right!", 4, 5) ?? "No such length words.");
            Console.WriteLine(GetUniqueValuesCount(
                new string[] { "potato", "piano", "sun", "window", "fish", "eye", "potato", "piano", "sun", "window", "fish", "eye" }) ?? 0);
            Console.WriteLine(GetShortestWordLength("All in all, you're just another brick in the wall.") ?? 0);

            var dictionary = new Dictionary<string, string>()
            {
                { "pleasure", "pain" },
                { "fun", "boredom" },
                { "joy", "sadness" },
                { "love", "hate" }
            };

            var list = GetListFromDictionary(dictionary);
            Console.WriteLine();
            foreach (var element in list)
            {
                Console.WriteLine($"{element.Key} - {element.Value}");
            }

            var userList = new List<User>
            {
                new User("Aleksandr", "Petrovich", "Koryavyj"),
                new User("Roman", "Petrovich", "Koryavyj"),
                new User("Nina", "Petrovna", "Koryavaya"),
                new User("Pyotr", null, "Koryavyj"),
                new User("Zhanna", null, "Aguzarova"),
                new User("Aleksandr", "Sergeevich", "Pushkin")
            };

            var fullNames = GetFullNames(userList);
            Console.WriteLine();
            foreach (var fullName in fullNames)
            {
                Console.WriteLine(fullName);
            }

            Console.WriteLine();
            foreach (var user in GetDescendingOrderedByLastName(userList))
            {
                Console.WriteLine(user.LastName);
            }

            var intArray = new int[] { 24, 544, 12333, 600, 0, -564, -333, 6960, 366 };
            Console.WriteLine();
            foreach (var number in GetContaining3ElementsSince5th(intArray))
            {
                Console.WriteLine(number);
            }
        }

        private static string? GetFirstOneLetterWord(string sentence) =>
            GetArrayFromSentence(sentence)?.FirstOrDefault(s => s.Length == 1);

        private static string? GetLastEeContainingWord(string sentence) =>
            GetArrayFromSentence(sentence)?.LastOrDefault(s => s.Contains("ee"));

        private static string? GetLastCertainLengthWord(string sentence, int minLength, int maxLength) =>
            GetArrayFromSentence(sentence)?.LastOrDefault(s => s.Length >= minLength && s.Length <= maxLength);

        private static int? GetShortestWordLength(string sentence)
        {
            var array = GetArrayFromSentence(sentence);
            return array?.Length > 0 ? array?.Min(s => s.Length) : null;
        }

        private static string[]? GetArrayFromSentence(string sentence) =>
            sentence?.Split(new char[] { ' ', ',', '.', ';', ':', '\"', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        private static int? GetUniqueValuesCount(string[] words) =>
            words?.Distinct().Count();

        private static int[] GetContaining3ElementsSince5th(int[] numbers) =>
            numbers.Skip(4).Where(n => n.ToString().Contains('3')).ToArray();

        private static List<KeyValuePair<string, string>> GetListFromDictionary(Dictionary<string, string> dictionary) =>
            (from kvp in dictionary
             select new KeyValuePair<string, string>(kvp.Value, kvp.Key)).ToList();

        private static List<string> GetFullNames(List<User> users) =>
            (from user in users
             select user.MiddleName == null ?
                   $"{user.FirstName} {user.LastName}" :
                   $"{user.FirstName} {user.MiddleName} {user.LastName}").ToList();

        private static List<User> GetDescendingOrderedByLastName(List<User> users) =>
            users.OrderByDescending(u => u.LastName).ToList();
    }
}