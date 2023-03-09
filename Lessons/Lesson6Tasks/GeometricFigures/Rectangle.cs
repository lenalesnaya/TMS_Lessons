namespace Lessons.Lesson6Tasks.GeometricFigures
{
    internal class Rectangle : Figure
    {
        protected double length;
        protected double width;


        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }


        public override double GetSquare()
        {
            Console.WriteLine($"\nGet square ({this})");
            return length * width;
        }
    }
}