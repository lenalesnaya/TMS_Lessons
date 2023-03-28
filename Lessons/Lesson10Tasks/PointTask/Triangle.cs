namespace Lessons.Lesson10Tasks.PointTask
{
    ///<summary>
    ///Represents the entity "triangle".
    ///</summary>
    internal class Triangle
    {
        public double FirstSide { get; }
        public double SecondSide { get; }
        public  double ThirdSide { get; }

        public Triangle(Point<double> firstPoint, Point<double> secondPoint, Point<double> thirdPoint)
        {
            FirstSide = firstPoint.GetLength(secondPoint);
            SecondSide = secondPoint.GetLength(thirdPoint);
            ThirdSide = thirdPoint.GetLength(firstPoint);
        }

        ///<summary>
        ///(virtual) Calculates the square of ​​the triangle by Heron formula.
        ///</summary>
        ///<returns>
        ///Returns a double type value of square of the specific triangle.
        ///</returns>
        public virtual double GetSquare()
        {
            Console.WriteLine("\nGet square by Heron formula:");
            double semiPerimetr = (FirstSide + SecondSide +ThirdSide) / 2;
            return Math.Sqrt(semiPerimetr * (semiPerimetr - FirstSide) * (semiPerimetr - SecondSide) * (semiPerimetr - ThirdSide));
        }
    }
}