namespace Lessons.Lesson6Tasks.GeometricFigures
{
    internal class Figure
    {
        public virtual double GetSquare()
        {
            return 0.0;
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}