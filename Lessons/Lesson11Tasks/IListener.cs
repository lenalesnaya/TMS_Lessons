namespace Lessons.Lesson11Tasks
{
    internal interface IListener<ArgsType>
    {
        void Update(ArgsType arg);
    }
}