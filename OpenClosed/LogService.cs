using System;

namespace OpenClosed
{
    public class LogService
    {
        public void Write(Activity activity, string target)
        {
            switch (target)
            {
                case "console":
                    WriteToConsole(activity);
                        break;
                case "file":
                    WriteToFile(activity);
                    break;
            }
        }

        void WriteToConsole(Activity activity)
        {
            //Escribir en la consola
        }

        void WriteToFile(Activity activity)
        {
            //Escribir en archivo
        }
    }
}

namespace OpenClosed.WithSolid
{
    public class LogService
    {
        private readonly ILogger Logger;
        public LogService(ILogger logger)
        {
            Logger = logger;
        }  
        
        public void Write(Activity activity)
        {
            Logger.Write(activity);
        }
    }

    public interface ILogger
    {
        void Write (Activity activity);
    }

    public class ConsoleLogger : ILogger
    {
        public void Write(Activity activity)
        {
            //Log a la consola
        }
    }

    public class FileLogger : ILogger
    {
        public void Write(Activity activity)
        {
            //Log a la consola
        }
    }

    public class WindowsLogger : ILogger
    {
        public void Write(Activity activity)
        {
            //Log a la consola
        }
    }
}