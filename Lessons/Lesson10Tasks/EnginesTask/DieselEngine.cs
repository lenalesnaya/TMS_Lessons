namespace Lessons.Lesson10Tasks.EnginesTask
{
    internal class DieselEngine : Engine
    {
        public override string Fuel => "diesel";

        public override void Work()
        {
            Console.WriteLine("Diesel engine is working.");
        }
    }
}