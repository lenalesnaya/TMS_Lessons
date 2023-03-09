namespace Lessons.Lesson6Tasks.GeometricFigures
{
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

        public override double GetSquare()
        {
            Console.WriteLine("\nGet square by Heron formula:");

            double semiPerimetr = (firstSide + secondSide + thirdSide) / 2;
            return Math.Sqrt(semiPerimetr * (semiPerimetr - firstSide) * (semiPerimetr - secondSide) * (semiPerimetr - thirdSide));
        }
    }
}