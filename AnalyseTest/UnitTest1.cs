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
        public void Mood_Analyze_Problem(string input, string expected)
        {
            try
            {
                var result = moodAnalyzer.AnalyseExceptionMethod();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "message is null");
            }
        }
    }
}