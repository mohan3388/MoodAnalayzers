namespace MoodAnalyze
{
    public class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string MoodAnalys()
        {
            if(message.ToLower().Contains("sad"))
            {
                return "Sad";
            }
           
                return "Happy";
            }
            public string AnalyseExceptionMethod()
            {
            try
            {
                if (message.ToLower().Contains("null"))
                {
                    return "sad";
                }
               
                    return "Happy";
                }
                    catch (Exception ex)
            {
                return "Happy";
            }
        }
    }
}