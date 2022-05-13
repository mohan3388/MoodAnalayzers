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
        public void MoodAnalysis_return_null(string input, string expected)
        {
            try
            {
                var result = moodAnalyzer.AnalyzeMood();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "message is null");
            }
        }
        public void MoodAnalysis_return_empty(string input, string expected)
        {
            try
            {
                var result = moodAnalyzer.AnalyzeMood();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "message is empty");
            }

        }
    }
}