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
          
                if(message.ToLower().Contains("Happy"))
                {
                    return "Happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch(Exception)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_MOOD, "Message is empty");
            }
    }
    }
}