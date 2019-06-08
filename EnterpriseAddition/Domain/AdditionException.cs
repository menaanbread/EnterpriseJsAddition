using System;

namespace EnterpriseAddition.Domain
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
