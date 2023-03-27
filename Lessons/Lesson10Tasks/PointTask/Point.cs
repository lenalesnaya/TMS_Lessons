namespace Lessons.Lesson10Tasks.PointTask
{
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

        public void PrintCoordinates()
        {
            Console.WriteLine($"X: {x:#.##}, Y: {y:#.##}");
        }

        public abstract T GetLength(Point<T> secondPoint);

        public T GetLength(Point<T> point, Func<Point<T>, Point<T>, T> function)
        {
            return function.Invoke(this, point);
        }

        public static double GetLength(Point<double> firstPoint, Point<double> secondPoint)
        {
            return Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
        }
    }
}