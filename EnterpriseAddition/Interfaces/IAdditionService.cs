using System;

namespace EnterpriseAddition.Interfaces
{
    public interface IAdditionService
    {
        Func<int, int> Add(int number);
    }
}
