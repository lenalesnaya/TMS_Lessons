namespace Lessons.Lesson10Tasks.EnginesTask
{
    internal abstract class Car<TEngine>
        where TEngine : Engine
    {
        public abstract TEngine Engine { get; }

        public virtual void Move()
        {
            Console.WriteLine($"\n{this} is moving.");
            Engine.Work();
        }

        public virtual void Fuel()
        {
            Console.WriteLine($"\n{this} is refueling with {Engine.Fuel}.");
        }
    }
}