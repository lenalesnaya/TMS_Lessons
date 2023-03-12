namespace Lessons.Lesson6Tasks.Clinic
{
    ///<summary>
    ///Represents the entity "therapist" (base: Doctor).
    ///</summary>
    internal class Therapist : Doctor
    {
        ///<summary>
        ///Overrides Doctor.Treat(). Prints information, that therapist is treating, to the console.
        ///</summary>
        public override void Treat()
        {
            Console.WriteLine("\nThe therapist is treating.");
        }
    }
}