namespace Lessons.Lesson6Tasks.Clinic
{
    internal class Dentist : Doctor
    {
        public override void Treat()
        {
            Console.WriteLine("\nThe dentist is treating.");
        }
    }
}