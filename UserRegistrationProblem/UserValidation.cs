using System.Text.RegularExpressions;
namespace UserRegistrationProblem
{
    public class UserValidation
    {
        public const string Name_Pattern = "^[A-Z]{1}[A-Za-z]{3,}$";
        public bool ValidName(string name)
        {
            if (Regex.IsMatch(name, Name_Pattern));
            {
                Console.WriteLine("Valid name: "+name);
                return true;
            }
        }
    }
}