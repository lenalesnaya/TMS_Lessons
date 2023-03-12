namespace Lessons.Lesson6Tasks.GeometricFigures
{
    /// <summary>
    /// Base class for all kinds of geometric figures.
    /// </summary>
    internal class Figure
    {
        /// < summary>
        /// (virtual) Method is designed to calculate the square of ​​the figure, contains a stub (should be abstract).
        /// < /summary>
        /// < returns>
        /// Returns the default value of double type.
        /// < /returns>
        public virtual double GetSquare()
        {
            return 0.0;
        }

        /// < summary>
        /// Overrides Object.ToString().Gets the name of the type in string format.
        /// < /summary>
        /// < returns> 
        /// Returns the name of the type.
        /// < /returns>
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}