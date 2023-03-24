namespace Lessons.Lesson10Tasks.EnginesTask
{
    internal class GasolineEngine : Engine
    {
        public override string Fuel => "gasoline";

        public override void Work()
        {
            Console.WriteLine("Gasoline engine is working.");
        }
    }
}