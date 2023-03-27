namespace Lessons.Lesson10Tasks.PointTask
{
    internal class DoublePoint : Point<double>
    {
        public DoublePoint(double x, double y) : base(x, y) { }

        public override double GetLength(Point<double> secondPoint)
        {
            return Math.Sqrt(Math.Pow(x - secondPoint.X, 2) + Math.Pow(y - secondPoint.Y, 2));
        }
    }
}