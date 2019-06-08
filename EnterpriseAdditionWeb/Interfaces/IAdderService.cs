using System;

namespace EnterpriseAdditionWeb.Interfaces
{
    public interface IAdderService
    {
        Func<int, int> GetAdditionFunction();
    }
}
