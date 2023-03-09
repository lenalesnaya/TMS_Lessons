namespace Lessons.Lesson6Tasks.GeometricFigures
{
    internal class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide) { }


        public override double GetSquare()
        {
            Console.WriteLine($"\nGet square ({this})");
            return Math.Sqrt(3) * Math.Pow(firstSide, 2) / 4;
        }
    }
}