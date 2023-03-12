namespace Lessons.Lesson6Tasks.Clinic
{
    /// <summary>
    /// Base class for all kinds of doctors in the clinic.
    /// </summary>
    internal class Doctor
    {
        /// < summary>
        /// (virtual) Prints information, that doctor is treating, to the console.
        /// < /summary>
        public virtual void Treat()
        {
            Console.WriteLine("\nThe unknown doctor is treating.");
        }
    }
}