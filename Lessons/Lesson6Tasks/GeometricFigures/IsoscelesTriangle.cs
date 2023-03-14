namespace Lessons.Lesson6Tasks.GeometricFigures
{
    ///<summary>
    ///Represents the entity "isosceles triangle" (base: Triangle -> Figure).
    ///</summary>
    internal class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double firstSide, double secondSide, double baseSide) : base(firstSide, secondSide, baseSide) { }

        ///<summary>
        ///Overrides Triangle.GetSquare(). Calculates the square of ​​the isosceles triangle.
        ///</summary>
        ///<returns>
        ///Returns a double type value of square of the specific isosceles triangle.
        ///</returns>
        public override double GetSquare()
        {
            Console.WriteLine($"\nGet square ({this})");
            return (thirdSide / 4) * Math.Sqrt((4 * Math.Pow(firstSide, 2)) - Math.Pow(thirdSide, 2));
        }
    }
}