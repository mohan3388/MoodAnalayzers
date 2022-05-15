using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyze;

namespace AnalyseTest
{
    [TestClass]
    public class MoodAnalysisTest
    {

        private readonly MoodAnalyzer moodAnalyzer;
        public MoodAnalysisTest()
        {
            moodAnalyzer = new MoodAnalyzer("");
        }
        [TestMethod]
        [DataRow("", "message is empty")]
        [DataRow(null, "message is null")]
        public void Mood_Analyse_return_Null(string input, string expected)
        {
            try
            {
                var result = moodAnalyzer.MoodAnalyze();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "message is null");
            }
        }
        [TestMethod]
        public void Mood_Analyse_return_Empty(string input, string expected)
        {
            try
            {
                var result = moodAnalyzer.MoodAnalyze();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "message is empty");
            }

        }
        [TestMethod]
        public void Mood_Analysis_return_Obj()
        {
            object expected = new MoodAnalyzer();
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyze.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }
    }
}