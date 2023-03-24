namespace Lessons.Lesson10Tasks.EnginesTask
{
    internal class ElectricCar : Car<ElectricEngine>
    {
        public override ElectricEngine Engine => new();

        public override string ToString()
        {
            return "Electric car";
        }
    }
}