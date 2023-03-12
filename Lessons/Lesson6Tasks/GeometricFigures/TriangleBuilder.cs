namespace Lessons.Lesson6Tasks.GeometricFigures
{
    ///<summary>
    ///Provides a functionality to create a certain type of triangle, depending on the incoming parameters values.
    ///</summary>
    internal static class TriangleBuilder
    {
        ///<summary>
        ///Creates an object of the certain type of triangle, depending on the incoming values of sides lengths.
        ///</summary>
        ///<param name="firstSide">Provides the first side value.</param>
        ///<param name="secondSide">Provides the second side value.</param>
        ///<param name="thirdSide">Provides the third side value.</param>
        ///<returns>
        ///Returns the object of the certain type of triangle.
        ///</returns>
        public static Triangle? Create(double firstSide, double secondSide, double thirdSide)
        {
            if (!IsTriangleExist(firstSide, secondSide, thirdSide))
            {
                Console.WriteLine(
                    $"\nA triangle with sides {firstSide}, {secondSide} and {thirdSide} can not exist.");
                return null;
            }

            if (IsTriangleEquilateral(firstSide, secondSide, thirdSide))
            {
                return new EquilateralTriangle(firstSide, secondSide, thirdSide);
            }

            if (IsTriangleIsosceles(ref firstSide, ref secondSide, ref thirdSide))
            {
                return new IsoscelesTriangle(firstSide, secondSide, thirdSide);
            }

            if (IsTriangleRight(
                    firstSide, secondSide, thirdSide, out double hypotenuse, out double firstCathetus, out double secondCathetus))
            {
                return new RightTriangle(firstCathetus, secondCathetus, hypotenuse);
            }

            return new Triangle(firstSide, secondSide, thirdSide);
        }

        ///<summary>
        ///Checks if the triangle with specific parameters can exist.
        ///</summary>
        ///<param name="firstSide">Provide the first side value.</param>
        ///<param name="secondSide">Provide the second side value.</param>
        ///<param name="thirdSide">Provide the third side value.</param>
        ///<returns>
        ///Returns the boolean result of the check.
        ///</returns>
        private static bool IsTriangleExist(double firstSide, double secondSide, double thirdSide)
        {
            return (firstSide > 0) &&
                (secondSide > 0) &&
                (thirdSide > 0) &&
                ((firstSide + secondSide) > thirdSide) &&
                ((secondSide + thirdSide) > firstSide) &&
                ((firstSide + thirdSide) > secondSide);
        }

        ///<summary>
        ///Checks if the triangle with specific parameters is equilateral.
        ///</summary>
        ///<param name="firstSide">Provide the first side value.</param>
        ///<param name="secondSide">Provide the second side value.</param>
        ///<param name="thirdSide">Provide the third side value.</param>
        ///<returns>
        ///Returns the boolean result of the check.
        ///</returns>
        private static bool IsTriangleEquilateral(double firstSide, double secondSide, double thirdSide)
        {
            return (firstSide == secondSide) && (secondSide == thirdSide);
        }

        ///<summary>
        ///Checks if the triangle with specific parameters is isosceles, determine a base side of the triangle.
        ///</summary>
        ///<param name="firstSide">Provide the first side value (using the "ref" modifier may change initial variable value)</param>
        ///<param name="secondSide">Provide the second side value (using the "ref" modifier may change initial variable value).</param>
        ///<param name="thirdSide">Provide the third side value (using the "ref" modifier may change initial variable value, returns the value of the base side.).</param>
        ///<returns>
        ///Returns the boolean result of the check.
        ///</returns>
        private static bool IsTriangleIsosceles(ref double firstSide, ref double secondSide, ref double thirdSide)
        {
            var temp = 0.0;

            if (IsTriangleEquilateral(firstSide, secondSide, thirdSide))
                return false;

            if (firstSide == secondSide)
            {
                return true;
            }

            if (secondSide == thirdSide)
            {
                temp = firstSide;
                firstSide = thirdSide;
                thirdSide = temp;
                return true;
            }

            if (firstSide == thirdSide)
            {
                temp = secondSide;
                secondSide = thirdSide;
                thirdSide = temp;
                return true;
            }

            return false;
        }

        ///<summary>
        ///Checks if the triangle with specific parameters is right, determine a hypotenuse and cathetuses of the triangle.
        ///</summary>
        ///<param name="firstSide">Provide the first side value.</param>
        ///<param name="secondSide">Provide the second side value.</param>
        ///<param name="thirdSide">Provide the third side value.</param>
        ///<param name="hypotenuse">Using the "out" modifier returns the hypotenuse.</param>
        ///<param name="firstCathetus">Using the "out" modifier returns the first cathetus.</param>
        ///<param name="secondCathetus">Using the "out" modifier returns the second cathetus.</param>
        ///<returns>
        ///Returns the boolean result of the check.
        ///</returns>
        private static bool IsTriangleRight(
            double firstSide, double secondSide, double thirdSide, out double hypotenuse, out double firstCathetus, out double secondCathetus)
        {
            hypotenuse = firstSide;
            firstCathetus = secondSide;
            secondCathetus = thirdSide;

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

            return Math.Pow(hypotenuse, 2) == Math.Pow(firstCathetus, 2) + Math.Pow(secondCathetus, 2);
        }
    }
}