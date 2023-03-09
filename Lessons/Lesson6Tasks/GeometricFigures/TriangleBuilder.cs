namespace Lessons.Lesson6Tasks.GeometricFigures
{
    internal static class TriangleBuilder
    {
        public static Triangle? Create(double firstSide, double secondSide, double thirdSide)
        {
            if (!((firstSide > 0) &&
                (secondSide > 0) &&
                (thirdSide > 0) &&
                ((firstSide + secondSide) > thirdSide) &&
                ((secondSide + thirdSide) > firstSide) &&
                ((firstSide + thirdSide) > secondSide)))
            {
                Console.WriteLine(
                    $"\nA triangle with sides {firstSide}, {secondSide} and {thirdSide} can not exist.");
                return null;
            }

            if ((firstSide == secondSide) && (secondSide == thirdSide))
            {
                return new EquilateralTriangle(firstSide, secondSide, thirdSide);
            }

            if (firstSide == secondSide)
            {
                return new IsoscelesTriangle(firstSide, secondSide, thirdSide);
            }
            if (secondSide == thirdSide)
            {
                return new IsoscelesTriangle(secondSide, thirdSide, firstSide);
            }
            if (firstSide == thirdSide)
            {
                return new IsoscelesTriangle(firstSide, thirdSide, secondSide);
            }

            double hypotenuse = firstSide;
            double firstCathetus = secondSide;
            double secondCathetus = thirdSide;

            if (secondSide > hypotenuse)
            {
                hypotenuse = secondSide;
                firstCathetus = firstSide;
                secondCathetus = thirdSide;
            }
            if (thirdSide > hypotenuse)
            {
                hypotenuse = thirdSide;
                firstCathetus = firstSide;
                secondCathetus = secondSide;
            }

            if (Math.Pow(hypotenuse, 2) == Math.Pow(firstCathetus, 2) + Math.Pow(secondCathetus, 2))
            {
                return new RightTriangle(firstCathetus, secondCathetus, hypotenuse);
            }

            return new Triangle(firstSide, secondSide, thirdSide);
        }
    }
}