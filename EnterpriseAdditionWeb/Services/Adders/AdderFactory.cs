using EnterpriseAdditionWeb.Domain;
using EnterpriseAdditionWeb.Interfaces;
using System.Linq;

namespace EnterpriseAdditionWeb.Services.Adders
{
    public class AdderFactory : AbstractAdderFactory
    {
        public AdderFactory(ILogger logger)
            : base(logger)
        {
        }

        public override IAdderService GetAdderService(int number)
        {
            return Adders.FirstOrDefault(a => ((AbstractBaseAdderService)a).NumberToAdd == number)
                ?? Adders.FirstOrDefault(a => ((AbstractBaseAdderService)a).NumberToAdd == 0)
                ?? throw new AdditionException("Couldn't find an AdderService for this number!");
        }
    }
}
