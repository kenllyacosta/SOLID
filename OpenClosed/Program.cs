using System;

namespace OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OpenClosed.WithSolid.ConsoleLogger consoleLog = new OpenClosed.WithSolid.ConsoleLogger();
            consoleLog.Write(new Activity());

            OpenClosed.WithSolid.FileLogger fileLog = new OpenClosed.WithSolid.FileLogger();
            fileLog.Write(new Activity());

            OpenClosed.WithSolid.ILogger windowsLog = new OpenClosed.WithSolid.WindowsLogger();
            windowsLog.Write(new Activity());

            OpenClosed.WithSolid.LogService logService = 
                new OpenClosed.WithSolid.LogService(windowsLog);

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
