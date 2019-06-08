using EnterpriseAddition.Interfaces;
using System.Collections.Generic;

namespace EnterpriseAddition.Services.Adders
{
    public abstract class AbstractAdderFactory : IAdderFactory
    {
        private readonly ILogger logger;

        public AbstractAdderFactory(ILogger logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// ToDo - work out a way to DI this...
        /// </summary>
        protected IList<IAdderService> Adders => new List<IAdderService>
        {
            new FirstAdder(),
            new SecondAdder(),
            new ThirdAdder(),
            new DefaultAdder(logger)
        };

        public abstract IAdderService GetAdderService(int number);
    }
}
