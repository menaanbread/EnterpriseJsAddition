using System;
using EnterpriseAdditionWeb.Interfaces;

namespace EnterpriseAdditionWeb.Services
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
