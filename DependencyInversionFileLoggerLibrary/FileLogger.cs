using DependencyInversionAbstractions;
using System.IO;

namespace DependencyInversionFileLoggerLibrary
{
    public class FileLogger : ILogger
    {
        public void Write(Activity activity)
        {
            using (StreamWriter sr = new StreamWriter("log.txt", true))
                sr.WriteLine("Mi actividad " + activity.Message);
        }
    }
}
