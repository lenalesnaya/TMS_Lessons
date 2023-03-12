namespace Lessons.Lesson6Tasks.GeometricFigures
{
    /// <summary>
    /// Represents the entity "foursquare" (base: Rectangle -> Figure).
    /// </summary>
    internal class Foursquare : Rectangle
    {
        private Foursquare(double length, double width) : base(length, width) { }

        /// < summary>
        /// Create a foursquare object, if the values of rectangle length and width are equal.
        /// < /summary>
        ///<param name="length">Represents the length of rectangle.</param>
        ///<param name="width">Represents the width of rectangle.</param>
        /// < returns>
        /// Returns a new foursquare object.
        /// < /returns>
        public static Foursquare? Create(double length, double width)
        {
            if (length == width)
            {
                return new Foursquare(length, width);
            }
            else
            {
                Console.WriteLine($"\nA foursquare with sides {length} and {width} can not exist.");
                return null;
            }
        }
    }
}