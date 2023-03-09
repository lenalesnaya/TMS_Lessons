namespace Lessons.Lesson6Tasks.GeometricFigures
{
    internal class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double firstSide, double secondSide, double baseSide) : base(firstSide, secondSide, baseSide) { }


        public override double GetSquare()
        {
            Console.WriteLine($"\nGet square ({this})");
            return (thirdSide / 4) * Math.Sqrt((4 * Math.Pow(firstSide, 2)) - Math.Pow(thirdSide, 2));
        }
    }
}