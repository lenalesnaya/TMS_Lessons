namespace Lessons.Lesson10Tasks.EnginesTask
{
    ///<summary>
    ///Represents the entity "gasoline engine" (base: Engine).
    ///</summary>
    internal class GasolineEngine : Engine
    {
        public override string Fuel => "gasoline";

        ///<summary>
        ///Overrides Engine.Work(). Prints information about the operation of the gasoline engine.
        ///</summary>
        public override void Work()
        {
            Console.WriteLine("Gasoline engine is working.");
        }
    }
}