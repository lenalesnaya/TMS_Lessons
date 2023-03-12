namespace Lessons.Lesson6Tasks.GeometricFigures
{
    /// <summary>
    /// Base class for all kinds of rectangles (base: Figure).
    /// </summary>
    internal class Rectangle : Figure
    {
        protected double length;
        protected double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        /// < summary>
        /// Overrides Figure.GetSquare(). Calculates the square of ​​the rectangle.
        /// < /summary>
        /// < returns>
        /// Returns a double type value of square of the specific rectangle.
        /// < /returns>
        public override double GetSquare()
        {
            Console.WriteLine($"\nGet square ({this})");
            return length * width;
        }
    }
}