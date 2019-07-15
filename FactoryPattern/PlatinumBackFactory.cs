using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class PlatinumFacory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;
        public PlatinumFacory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }
        public override CreditCard GetCreditCard()
        {
            return new PlatinumCreditCard(_creditLimit, _annualCharge);
        }
    }
}
