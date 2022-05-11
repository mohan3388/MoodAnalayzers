using MoodAnalyze;
using NUnit.Framework;

namespace TestProgram
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            MoodAnalyzer problem = new MoodAnalyzer();
            var result = problem.MoodAnalys("I am in Happy Mood");
            Assert.AreEqual(result, "Happy");

        }
    }
}