namespace Lessons.Lesson8Tasks
{
    internal class Lesson8
    {
        public static void Task1_UseRegistrationDataValidation()
        {
            var validationResult = RegistrationDataValidation.Validate("LosLesnoy", "LosLesnoy!3632", "LosLesnoy!3632");
            if (validationResult)
            {
                Console.WriteLine("Registration data are valid!");
            }
        }
    }
}