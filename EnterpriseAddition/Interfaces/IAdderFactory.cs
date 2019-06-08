namespace EnterpriseAddition.Interfaces
{
    public interface IAdderFactory
    {
        IAdderService GetAdderService(int number);
    }
}
