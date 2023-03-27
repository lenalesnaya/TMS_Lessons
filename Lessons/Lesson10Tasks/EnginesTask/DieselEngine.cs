namespace Lessons.Lesson10Tasks.EnginesTask
{
    ///<summary>
    ///Represents the entity "diesel engine" (base: Engine).
    ///</summary>
    internal class DieselEngine : Engine
    {
        public override string Fuel => "diesel";

        ///<summary>
        ///Overrides Engine.Work(). Prints information about the operation of the diesel engine.
        ///</summary>
        public override void Work()
        {
            Console.WriteLine("Diesel engine is working.");
        }
    }
}