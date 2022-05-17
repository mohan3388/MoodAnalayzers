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
        [Test]
        public void Valid_Password()
        {
            Validation problem = new Validation();
            bool value = problem.ValidPassword("Mohansah");
            Assert.IsTrue(value);
        }
        [Test]
        public void Valid_Password_Use_Uppercase()
        {
            Validation problem = new Validation();
            bool value = problem.ValidPassword_One_Uppercase("Mohansahu");
            Assert.IsTrue(value);
        }
        [Test]
        public void Valid_Password_include_one_Number()
        {
            Validation problem = new Validation();
            bool value = problem.ValidPassword_One_Number("Mohansa7");
            Assert.IsTrue(value);
        }
        [Test]
        public void Valid_Password_Special_Char()
        {
            Validation problem = new Validation();
            bool value = problem.ValidPassword_Special_Char("Mohans7@");
            Assert.IsTrue(value);
        }
        [Test]
        public void Valid_Email_Address()
        {
            Validation problem = new Validation();
            bool value1 = problem.ValidEmailAddress("abc@yahoo.com");
            bool value2 = problem.ValidEmailAddress("abc-100@yahoo.com");
            bool value3 = problem.ValidEmailAddress("abc.100@yahoo.com");
            bool value4 = problem.ValidEmailAddress("abc111@abc.com");
            bool value5 = problem.ValidEmailAddress("abc-100@abc.net");
            bool value6 = problem.ValidEmailAddress("abc.100@abc.com.au");
            bool value7 = problem.ValidEmailAddress("abc@1.com");
            bool value8 = problem.ValidEmailAddress("abc@gmail.com.com");
            bool value9 = problem.ValidEmailAddress("abc+100@gmail.com");
            Assert.IsTrue(value1);
            Assert.IsTrue(value2);
            Assert.IsTrue(value3);
            Assert.IsTrue(value4);
            Assert.IsTrue(value5);
            Assert.IsTrue(value6);
            Assert.IsTrue(value7);
            Assert.IsTrue(value8);
            Assert.IsTrue(value9);
        }
    }
}