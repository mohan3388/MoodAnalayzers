using NUnit.Framework;
using UserRegistrationProblem;

namespace ValidationTest
{
    public class Tests
    {
       

        
            [Test]
            public void Valid_FirstName()
            {
                Validation input = new Validation();
                bool result = input.ValidFirstName("Mohan");
                Assert.IsTrue(result);
            }
            [Test]
            public void Valid_LastName()
            {
                Validation input = new Validation();
                bool result = input.ValidLastName("Sahu");
                Assert.IsTrue(result);
            }
        }
    }
