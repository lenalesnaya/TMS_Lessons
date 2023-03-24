namespace Lessons.Lesson10Tasks.EnginesTask
{
    internal class GasolineCar : Car<GasolineEngine>
    {
        public override GasolineEngine Engine => new();

        public override string ToString()
        {
            return "Gasoline car";
        }
    }
}