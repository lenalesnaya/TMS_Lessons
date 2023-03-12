namespace Lessons.Lesson6Tasks.GeometricFigures
{
    /// <summary>
    /// Represents the entity "equilateral triangle" (base: Triangle -> Figure).
    /// </summary>
    internal class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide) { }

        /// < summary>
        /// Overrides Triangle.GetSquare(). Calculates the square of ​​the equilateral triangle.
        /// < /summary>
        /// < returns>
        /// Returns a double type value of square of the specific equilateral triangle.
        /// < /returns>
        public override double GetSquare()
        {
            Console.WriteLine($"\nGet square ({this})");
            return Math.Sqrt(3) * Math.Pow(firstSide, 2) / 4;
        }
    }
}