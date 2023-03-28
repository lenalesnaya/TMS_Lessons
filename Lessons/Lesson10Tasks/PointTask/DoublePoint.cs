namespace Lessons.Lesson10Tasks.PointTask
{
    ///<summary>
    ///Represents the entity "point" with double type coordinates (base: Point<double>).
    ///</summary>
    internal class DoublePoint : Point<double>
    {
        public DoublePoint(double x, double y) : base(x, y) { }

        ///<summary>
        ///Overrides Point.GetLength(Point<T> secondPoint). Gets the distance from one point to another with double type coordinates.
        ///</summary>
        ///<param name="secondPoint">The second point of distance.</param>
        ///<returns>
        ///Returns the value of the distance.
        ///</returns>
        public override double GetLength(Point<double> secondPoint)
        {
            return Math.Sqrt(Math.Pow(x - secondPoint.X, 2) + Math.Pow(y - secondPoint.Y, 2));
        }
    }
}