using EnterpriseAddition.Domain;
using EnterpriseAddition.Interfaces;
using System;

namespace EnterpriseAddition.Services.Adders
{
    internal class DefaultAdder : AbstractBaseAdderService
    {
        private readonly ILogger logger;

        public DefaultAdder(ILogger logger)
        {
            this.logger = logger;
        }

        public override Func<int, int> GetAdditionFunction()
        {
            logger.Log("Handled a number which we couldn't handle!");
            throw new AdditionException("Default adder invoked.");
        }

        /// <summary>
        /// ToDo - think of something sensible to set this to.
        /// This is a temporary solution to make this compile.
        /// </summary>
        public override int NumberToAdd => 0;
    }
}
