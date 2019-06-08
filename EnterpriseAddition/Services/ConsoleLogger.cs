using EnterpriseAddition.Interfaces;
using System;

namespace EnterpriseAddition.Services
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
