namespace Lessons.Lesson10Tasks.EnginesTask
{
    ///<summary>
    ///Base generic abstract class for all kinds of cars. Type parameter TEngine represents a type of the engine of the car.
    ///</summary>
    internal abstract class Car<TEngine>
        where TEngine : Engine
    {
        public abstract TEngine Engine { get; }

        ///<summary>
        ///(virtual) Prints information about movement of the car.
        ///</summary>
        public virtual void Move()
        {
            Console.WriteLine($"\n{this} is moving.");
            Engine.Work();
        }

        ///<summary>
        ///(virtual) Prints information about refueling of the car.
        ///</summary>
        public virtual void Fuel()
        {
            Console.WriteLine($"\n{this} is refueling with {Engine.Fuel}.");
        }
    }
}