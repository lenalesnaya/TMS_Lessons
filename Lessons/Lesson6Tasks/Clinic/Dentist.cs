namespace Lessons.Lesson6Tasks.Clinic
{
    /// <summary>
    /// Represents the entity "dentist" (base: Doctor).
    /// </summary>
    internal class Dentist : Doctor
    {
        /// < summary>
        /// Overrides Doctor.Treat(). Prints information, that dentist is treating, to the console.
        /// < /summary>
        public override void Treat()
        {
            Console.WriteLine("\nThe dentist is treating.");
        }
    }
}