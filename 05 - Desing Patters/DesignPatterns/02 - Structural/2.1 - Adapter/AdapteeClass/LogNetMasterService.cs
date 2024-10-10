using System;

namespace DesignPatterns
{
    // (adaptacao-subs.target - utilizar adapter)
    // Adaptee class
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("Log Customizado - " + message);
        }

        public void LogException(Exception exception)
        {
            Console.WriteLine("Log Customizado - " + exception.Message);
        }
    }
}