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
        [DataRow("", "message is Empty")]
        [DataRow(null, "message is null")]
        public void InputInString_CheckingMoodAnalysis_MustBeReturn_Null(string input, string expected)
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
        public void InputInString_CheckingMoodAnalysis_MustBeReturn_EmptyMessage(string input, string expected)
        {
            try
            {
                var result = moodAnalyzer.AnalyseExceptionMethod();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "message is Empty");
            }

        }
    }
}