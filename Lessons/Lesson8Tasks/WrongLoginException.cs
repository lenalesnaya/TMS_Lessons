namespace Lessons.Lesson8Tasks
{
    ///<summary>
    ///Represents the exception class for login validation (base: System.Exception).
    ///</summary>
    internal class WrongLoginException : Exception
    {
        public WrongLoginException() { }

        public WrongLoginException(string message) : base(message) { }
    }
}