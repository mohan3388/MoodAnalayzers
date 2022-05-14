using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class Validation
    {
        public const string Name_Pattern = "^[A-Z]{1}[A-Za-z]{3, }$";
        public const string Email = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";        
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
        public bool ValidEmail(string email)
        {
            if (Regex.IsMatch(email, Email)) ;
            {
                Console.WriteLine("Valid Lastname" + email);
                return true;
            }
        }
    }
}