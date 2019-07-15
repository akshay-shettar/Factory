using System;

namespace FactoryPattern
{
    public abstract class CreditCard
    {
        public abstract int AnnualCharge { get; set; }
        public abstract string CardType { get; }
        public abstract int CreditLimit { get; set; }
    }
}
