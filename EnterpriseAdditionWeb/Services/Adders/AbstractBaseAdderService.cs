﻿using System;
using EnterpriseAdditionWeb.Interfaces;

namespace EnterpriseAdditionWeb.Services.Adders
{
    internal abstract class AbstractBaseAdderService : IAdderService
    {
        public virtual Func<int, int> GetAdditionFunction()
        {
            return (otherNumber) => Add(NumberToAdd, otherNumber);
        }

        public abstract int NumberToAdd { get; }

        private int Add(int a, int b)
        {
            return a + b;
        }
    }
}
