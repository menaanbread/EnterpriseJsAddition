using EnterpriseAdditionWeb.Interfaces;
using System;

namespace EnterpriseAdditionWeb.Services
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
