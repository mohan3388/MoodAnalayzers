using NUnit.Framework;
using UserValidationProblem;

namespace UserValidationTest
{
    public class Tests
    {
        

        [Test]
        public void Valid_First_Name()
        {
            Validation problem = new Validation();
            bool value = problem.ValidFirstName("Mohan");
            Assert.IsTrue(value);
        }
        [Test]
        public void Valid_Last_Name()
        {
            Validation problem = new Validation();
            bool value = problem.ValidLastName("Sahu");
            Assert.IsTrue(value);
        }
        [Test]
        public void Valid_Email()
        {
            Validation problem = new Validation();
            bool value = problem.ValidEmail("Mohan@123gmail.com");
            Assert.IsTrue(value);
        }
        [Test]
        public void Valid_Mobile()
        {
            Validation problem = new Validation();
            bool value = problem.ValidMobile("+917898625487");
            Assert.IsTrue(value);
        }
    }
}