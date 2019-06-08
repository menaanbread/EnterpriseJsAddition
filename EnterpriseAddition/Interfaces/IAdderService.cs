using System;

namespace EnterpriseAddition.Interfaces
{
    public interface IAdderService
    {
        Func<int, int> GetAdditionFunction();
    }
}
