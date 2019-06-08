using System;

namespace EnterpriseAdditionWeb.Domain
{
    public class AdditionException : Exception
    {
        public AdditionException()
        {
        }

        public AdditionException(string message)
            : base(message)
        {
        }
    }
}
