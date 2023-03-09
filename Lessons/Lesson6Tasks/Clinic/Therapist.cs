namespace Lessons.Lesson6Tasks.Clinic
{
    internal class Therapist : Doctor
    {
        public override void Treat()
        {
            Console.WriteLine("\nThe therapist is treating.");
        }
    }
}