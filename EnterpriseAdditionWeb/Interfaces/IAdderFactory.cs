namespace EnterpriseAdditionWeb.Interfaces
{
    public interface IAdderFactory
    {
        IAdderService GetAdderService(int number);
    }
}
