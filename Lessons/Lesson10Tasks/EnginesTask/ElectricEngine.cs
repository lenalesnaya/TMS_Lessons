namespace Lessons.Lesson10Tasks.EnginesTask
{
    ///<summary>
    ///Represents the entity "electric engine" (base: Engine).
    ///</summary>
    internal class ElectricEngine : Engine
    {
        public override string Fuel => "electricity";

        ///<summary>
        ///Overrides Engine.Work(). Prints information about the operation of the electric engine.
        ///</summary>
        public override void Work()
        {
            Console.WriteLine("Electric engine is working.");
        }
    }
}