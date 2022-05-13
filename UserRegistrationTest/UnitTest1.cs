using NUnit.Framework;
using UserRegistrationProblem;

namespace UserRegistrationTest
{
    public class Tests
    {
       [Test]
        public void User_Valid_name()
        {
            UserValidation valid = new UserValidation();
            bool Val = valid.ValidName("Mohan");
            Assert.IsTrue(Val);
        }
    }
}