namespace Lessons.Lesson6Tasks.GeometricFigures
{
    ///<summary>
    ///Base class for all kinds of triangles (base: Figure).
    ///</summary>
    internal class Triangle : Figure
    {
        protected double firstSide;
        protected double secondSide;
        protected double thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        ///<summary>
        ///Overrides Figure.GetSquare(). Calculates the square of ​​the triangle by Heron formula.
        ///</summary>
        ///<returns>
        ///Returns a double type value of square of the specific triangle.
        ///</returns>
        public override double GetSquare()
        {
            Console.WriteLine("\nGet square by Heron formula:");
            double semiPerimetr = (firstSide + secondSide + thirdSide) / 2;
            return Math.Sqrt(semiPerimetr * (semiPerimetr - firstSide) * (semiPerimetr - secondSide) * (semiPerimetr - thirdSide));
        }
    }
}