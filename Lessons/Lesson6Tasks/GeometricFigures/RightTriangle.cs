namespace Lessons.Lesson6Tasks.GeometricFigures
{
    internal class RightTriangle : Triangle
    {
        public RightTriangle(double firstCathetus, double secondCathetus, double hypotenuse) : base(firstCathetus, secondCathetus, hypotenuse) { }


        public override double GetSquare()
        {
            Console.WriteLine($"\nGet square ({this})");
            return 0.5 * firstSide * secondSide;
        }
    }
}