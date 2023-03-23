namespace Lessons.Lesson8Tasks
{
    ///<summary>
    ///Represents the exception class for password validation (base: System.Exception).
    ///</summary>
    internal class WrongPasswordException : Exception
    {
        public WrongPasswordException() { }

        public WrongPasswordException(string message) : base(message) { }
    }
}