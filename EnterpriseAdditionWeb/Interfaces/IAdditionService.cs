using System;

namespace EnterpriseAdditionWeb.Interfaces
{
    public interface IAdditionService
    {
        Func<int, int> Add(int number);
    }
}
