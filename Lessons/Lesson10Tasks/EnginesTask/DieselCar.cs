namespace Lessons.Lesson10Tasks.EnginesTask
{
    internal class DieselCar : Car<DieselEngine>
    {
        public override DieselEngine Engine => new();

        public override string ToString()
        {
            return "Diesel car";
        }
    }
}