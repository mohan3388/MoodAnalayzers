namespace MoodAnalyze
{
    public class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public string AnalyseExceptionMethod()
        {
            try
            {
                if(message == null)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_MOOD,"message is null");
                }
                if(message.Equals(" "))
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_MOOD, "message is empty");
                }
                if(message.ToLower().Contains("Happy"))
                {
                    return "Happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch(Exception ex)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_MOOD, "Message is empty");
            }
    }
    }
}