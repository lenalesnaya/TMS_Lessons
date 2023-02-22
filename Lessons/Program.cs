namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя существа, которому хотите передать привет:");
            var name = Console.ReadLine();
            Console.WriteLine("Привет, " + name);
        }
    }
}