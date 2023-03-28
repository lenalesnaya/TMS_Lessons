namespace Lessons.Lesson10Tasks.EnginesTask
{
    ///<summary>
    ///Base abstract class for all kinds of car engines.
    ///</summary>
    internal abstract class Engine
    {
        public abstract string Fuel { get; }

        ///<summary>
        ///(abstract) Represents the operation of the engine.
        ///</summary>
        public abstract void Work();
    }
}