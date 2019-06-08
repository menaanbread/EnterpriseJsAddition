using System;
using EnterpriseAddition.Interfaces;

namespace EnterpriseAddition.Services
{
    public class AdditionService : IAdditionService
    {
        private readonly IAdderFactory adderFactory;

        public AdditionService(IAdderFactory adderFactory)
        {
            this.adderFactory = adderFactory;
        }

        public Func<int, int> Add(int number)
        {
            return adderFactory.GetAdderService(number).GetAdditionFunction();
        }
    }
}
