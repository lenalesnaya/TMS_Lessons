namespace Lessons.Lesson10Tasks.PointTask
{
    ///<summary>
    ///Base generic abstract class for points with different coordinate types. The type parameter T represents a type of coordinate.
    ///</summary>
    internal abstract class Point<T>
    {
        protected T x;
        protected T y;

        public T X
        {
            get => x;
            set => x = value;
        }

        public T Y
        {
            get => y;
            set => y = value;
        }

        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        ///<summary>
        ///(virtual) Prints coordinates values.
        ///</summary>
        public virtual void PrintCoordinates()
        {
            Console.WriteLine($"X: {x:#.##}, Y: {y:#.##}");
        }

        ///<summary>
        ///(abstract) Gets the distance from one point to another.
        ///</summary>
        ///<param name="secondPoint">The second point of distance.</param>
        ///<returns>
        ///Returns the value of the distance.
        ///</returns>
        public abstract T GetLength(Point<T> secondPoint);

        ///<summary>
        ///Gets the distance from one point to another in a special way.
        ///</summary>
        ///<param name="secondPoint">The second point of distance.</param>
        ///<param name="function">Represents the way to calculate the distance.</param>
        ///<returns>
        ///Returns the value of the distance.
        ///</returns>
        public T GetLength(Point<T> secondPoint, Func<Point<T>, Point<T>, T> function)
        {
            return function.Invoke(this, secondPoint);
        }

        ///<summary>
        ///(static) Gets the distance from one point to another (with double type coordinates).
        ///</summary>
        ///<param name="firstPoint">The first point of distance.</param>
        ///<param name="secondPoint">The second point of distance.</param>
        ///<returns>
        ///Returns the double value of the distance.
        ///</returns>
        public static double GetLength(Point<double> firstPoint, Point<double> secondPoint)
        {
            return Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
        }
    }
}