using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class Validation
    {
        public const string Name_Pattern = "^[A-Z]{1}[A-Za-z]{3, }$";
        public bool ValidFirstName(string name)
        {
            if (Regex.IsMatch(name, Name_Pattern)) ;
            {
                Console.WriteLine("Valid name " + name);
                return true;
            }
        }
        public bool ValidLastName(string name)
        {
            if (Regex.IsMatch(name, Name_Pattern)) ;
            {
                Console.WriteLine("Valid Lastname" + name);
                return true;
            }
        }
    }
}