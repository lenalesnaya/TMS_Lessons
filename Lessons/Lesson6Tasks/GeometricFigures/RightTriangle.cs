namespace Lessons.Lesson6Tasks.GeometricFigures
{
    /// <summary>
    /// Represents the entity "right triangle" (base: Triangle -> Figure).
    /// </summary>
    internal class RightTriangle : Triangle
    {
        public RightTriangle(double firstCathetus, double secondCathetus, double hypotenuse) : base(firstCathetus, secondCathetus, hypotenuse) { }

        /// < summary>
        /// Overrides Triangle.GetSquare(). Calculates the square of ​​the right triangle.
        /// < /summary>
        /// < returns>
        /// Returns a double type value of square of the specific right triangle.
        /// < /returns>
        public override double GetSquare()
        {
            Console.WriteLine($"\nGet square ({this})");
            return 0.5 * firstSide * secondSide;
        }
    }
}