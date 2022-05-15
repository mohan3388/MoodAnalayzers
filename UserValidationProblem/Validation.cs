using System.Text.RegularExpressions;

namespace UserValidationProblem
{
    public class Validation
    {
        public const string Name_Pattern = "^[A-Z]{1}[A-Za-z]{3, }$";
        public const string Email = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public const string Mobile = "^[+]{1}[1-9]{2}[6-9]{1}[0-9]{9}$";
        public const string Password = "[A-Za-z]{8, }$";
        public bool ValidFirstName(string name)
        {
            if (Regex.IsMatch(name, Name_Pattern)) ;
            {
                Console.WriteLine("Valid name " + name);
                return true;
            }
        }
        public bool ValidLastName(string lastname)
        {
            if (Regex.IsMatch(lastname, Name_Pattern)) ;
            {
                Console.WriteLine("Valid Lastname" + lastname);
                return true;
            }
        }
        public bool ValidEmail(string email)
        {
            if (Regex.IsMatch(email, Email)) ;
            {
                Console.WriteLine("Valid Email" + email);
                return true;
            }
        }
        public bool ValidMobile(string mobile)
        {
            if (Regex.IsMatch(mobile, Mobile)) ;
            {
                Console.WriteLine("Valid mobile " + mobile);
                return true;
            }
        }
        public bool ValidPassword(string password)
        {
            if (Regex.IsMatch(password, Password)) ;
            {
                Console.WriteLine("Valid password " + password);
                return true;
            }
        }
    }
}