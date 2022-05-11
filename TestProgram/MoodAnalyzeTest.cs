using MoodAnalyze;
using NUnit.Framework;

namespace TestProgram
{
    public class Tests
    {
        [Test]
        public void Mood_Anayse_Sad()
        {
            MoodAnalyzer problem = new MoodAnalyzer("I am in Sad Mood");
            var Val = problem.MoodAnalys();
            Assert.AreEqual(Val, "Sad");

        }
        [Test]
        public void Mood_Analyse_Happy()
        {
            MoodAnalyzer problem = new MoodAnalyzer("I am in Happy Mood");
            var Val = problem.MoodAnalys();
            Assert.AreEqual(Val, "Happy");
        }
        [Test]
        public void Mood_Analyse_Exception()
        {
            MoodAnalyzer problem = new MoodAnalyzer("I am in Happy Mood");
            var Val = problem.MoodAnalys();
            Assert.AreEqual(Val, "Happy");
        }
    }
}