namespace Lessons.Lesson6Tasks.GeometricFigures
{
    internal class FourSquare : Rectangle
    {
        private FourSquare(double length, double width) : base(length, width) { }


        public static FourSquare? CreateFourSquare(double length, double width)
        {
            if (length == width)
            {
                return new FourSquare(length, width);
            }
            else
            {
                Console.WriteLine($"\nA foursquare with sides {length} and {width} can not exist.");
                return null;
            }
        }
    }
}