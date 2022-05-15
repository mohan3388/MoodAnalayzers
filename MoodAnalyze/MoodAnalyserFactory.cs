using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyze
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyse(string className, string contructorName)
        {
            string pattern = @"." + contructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly Execute = Assembly.GetExecutingAssembly();
                    Type MoodAnalyzeType = Execute.GetType(className);
                    return Activator.CreateInstance(MoodAnalyzeType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_CLASS, "class not found");
                }
            }
            else
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_METHOD, "constructor is not found");
            }
        }
           public static object ParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyzer);
            if(type.Name.Equals(className) || type.FullName.Equals(constructorName))
            {
                if(type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructor.Invoke(new object[] {message});
                    return instance;
                }
                else
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_METHOD, "class not found");
                }
            }
            else
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_METHOD, "class not found");
            }
        }
    }

}