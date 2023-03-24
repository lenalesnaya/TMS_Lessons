namespace Lessons.Lesson10Tasks.EnginesTask
{
    internal class ElectricEngine : Engine
    {
        public override string Fuel => "electricity";

        public override void Work()
        {
            Console.WriteLine("Electric engine is working.");
        }
    }
}