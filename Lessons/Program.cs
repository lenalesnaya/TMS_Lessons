namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            L1T1_HelloName();
        }


        #region Lesson_1
        public static void L1T1_HelloName()
        {
            Console.WriteLine("Введите имя существа, которому хотите передать привет:");
            var name = Console.ReadLine();
            Console.WriteLine("Привет, " + name);
        }
        #endregion
    }
}