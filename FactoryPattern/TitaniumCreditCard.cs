using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class TitaniumCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;
        public TitaniumCreditCard(int credLimit, int annualCharge)
        {
            _cardType = "Titanium";
            _creditLimit = credLimit;
            _annualCharge = annualCharge + 300;
        }

        public override int AnnualCharge { get => _annualCharge; set => _annualCharge = value; }
        public override string CardType { get => _cardType;}
        public override int CreditLimit { get => _creditLimit; set => _creditLimit = value; }
    }
}
