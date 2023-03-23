namespace Lessons.Lesson9Tasks
{
    ///<summary>
    ///Provides helper methods for working with a dictionary.
    ///</summary>
    internal static class DictionaryHelper
    {
        ///<summary>
        ///Prints the keys and values ​​of the generic dictionary to the console.
        ///</summary>
        ///<param name="dictionary">Represents the dictionary.</param>
        public static void PrintDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
        {
            foreach (var keyValuePair in dictionary)
            {
                Console.WriteLine($"{keyValuePair.Key,-30}{keyValuePair.Value,-30}");
            }
        }

        ///<summary>
        ///Prints the keys ​​of the generic dictionary to the console.
        ///</summary>
        ///<param name="dictionary">Represents the dictionary.</param>
        public static void PrintDictionaryKeys<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
        {
            foreach (var keyValuePair in dictionary)
            {
                Console.WriteLine($"{keyValuePair.Key}");
            }
        }

        ///<summary>
        ///Prints the values ​​of the generic dictionary to the console.
        ///</summary>
        ///<param name="dictionary">Represents the dictionary.</param>
        public static void PrintDictionaryValues<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
        {
            foreach (var keyValuePair in dictionary)
            {
                Console.WriteLine($"{keyValuePair.Value}");
            }
        }
    }
}