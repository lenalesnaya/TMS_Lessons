namespace Lessons.Lesson6Tasks.Clinic
{
    ///<summary>
    ///Represents the entity "surgeon" (base: Doctor).
    ///</summary>
    internal class Surgeon : Doctor
    {
        ///<summary>
        ///Overrides Doctor.Treat(). Prints information, that surgeon is treating, to the console.
        ///</summary>
        public override void Treat()
        {
            Console.WriteLine("\nThe surgeon is treating.");
        }
    }
}