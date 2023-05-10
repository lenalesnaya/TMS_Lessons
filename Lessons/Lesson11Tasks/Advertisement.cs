namespace Lessons.Lesson11Tasks
{
    internal class Advertisement : IListener<string>
    {
        public void Update(string message)
        {
            Console.WriteLine("\nAttention!");
            Console.WriteLine(message);
        }
    }
}