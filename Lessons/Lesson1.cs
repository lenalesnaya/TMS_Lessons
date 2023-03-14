namespace Lessons
{
    internal static class Lesson1
    {
        public static void Task1_GreetName()
        {
            string? name;

            Console.WriteLine("Who do you want to greet?:");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
        }
    }
}