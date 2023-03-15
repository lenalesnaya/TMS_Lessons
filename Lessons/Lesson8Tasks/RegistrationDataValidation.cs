using System.Text.RegularExpressions;

namespace Lessons.Lesson8Tasks
{
    ///<summary>
    ///Represents an utility class for registration data validating.
    ///</summary>
    internal static class RegistrationDataValidation
    {
        ///<summary>
        ///Checks if login and password are valid.
        ///</summary>
        ///<param name="login">Represents user login.</param>
        ///<param name="password">Represents user password.</param>
        ///<param name="confirmPassword">Represents password confirmation (must be equal to the password to pass validation)</param>
        ///<returns>
        ///Returns the boolean result of the check.
        ///</returns>
        public static bool Validate(string login, string password, string confirmPassword)
        {
            try
            {
                if (ValidateLogin(login))
                {
                    throw new WrongLoginException("Invalid login: login must be less then 20 characters and musn`t contain spaces.");
                }

                if (ValidatePassword(password, confirmPassword))
                {
                    throw new WrongLoginException(
                        "Invalid password:\n1.Password must be less then 20 characters.\n2.It must contain at least one number." +
                        "\n3.It mustn`t contain spaces.\n4.Password and confirmPassword must be equal.");
                }

                return true;
            }
            catch (WrongLoginException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WrongPasswordException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        ///<summary>
        ///Handle login validation.
        ///</summary>
        ///<param name="login">Represents user login.</param>
        ///<returns>
        ///Returns the boolean result of the validation.
        ///</returns>
        private static bool ValidateLogin(string login)
        {
            return (login.Length >= 20) || login.Contains(' ');
        }

        ///<summary>
        ///Handle password validation.
        ///</summary>
        ///<param name="password">Represents user password.</param>
        ///<param name="confirmPassword">Represents password confirmation (must be equal to the password to pass validation)</param>
        ///<returns>
        ///Returns the boolean result of the validation.
        ///</returns>
        private static bool ValidatePassword(string password, string confirmPassword)
        {
            return (password.Length >= 20) ||
                password.Contains(' ') ||
                !Regex.Match(password, "(?=.*[0-9])").Success ||
                !(password == confirmPassword);
        }
    }
}