using EnterpriseAddition.Interfaces;
using EnterpriseAddition.Services;
using EnterpriseAddition.Services.Adders;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EnterpriseAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IAdditionService, AdditionService>()
                .AddSingleton<IAdderFactory, AdderFactory>()
                .AddSingleton<ILogger, ConsoleLogger>()
                .BuildServiceProvider();

            var additionService = serviceProvider.GetService<IAdditionService>();
            var logger = serviceProvider.GetService<ILogger>();

            var first = additionService.Add(1);
            var second = additionService.Add(2);
            var third = additionService.Add(3);

            logger.Log(first(1).ToString());
            logger.Log(first(2).ToString());
            logger.Log(second(2).ToString());
            logger.Log(second(3).ToString());
            logger.Log(third(3).ToString());

            Console.ReadLine();
        }
    }
}
