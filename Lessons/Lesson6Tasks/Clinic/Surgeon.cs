namespace Lessons.Lesson6Tasks.Clinic
{
    internal class Surgeon : Doctor
    {
        public override void Treat()
        {
            Console.WriteLine("\nThe surgeon is treating.");
        }
    }
}