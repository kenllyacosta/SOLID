using DependencyInversionAbstractions;
using System;

namespace DependencyInversionConsoleLoggerLibrary
{
    public class ConsoleLogger : ILogger
    {
        public void Write(Activity activity)
        {
            Console.WriteLine("Mi actividad " + activity.Message);
        }
    }
}
