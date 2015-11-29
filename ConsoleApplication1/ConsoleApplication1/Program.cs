
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.ProcessorCount);
            Console.WriteLine(Environment.TickCount);
            Console.WriteLine(Environment.MachineName);
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine(Environment.HasShutdownStarted);
            Console.WriteLine(Environment.UserInteractive);
            Console.WriteLine(Environment.UserName);
            Console.WriteLine(Environment.WorkingSet);
            Console.WriteLine(Environment.GetEnvironmentVariables());
            Console.WriteLine(false);
        }
    }
}
