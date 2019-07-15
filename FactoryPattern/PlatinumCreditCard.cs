using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class PlatinumCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;
        public PlatinumCreditCard(int credLimit, int annualCharge)
        {
            _cardType = "Platinum";
            _creditLimit = credLimit;
            _annualCharge = annualCharge + 500;
        }

        public override int AnnualCharge { get => _annualCharge; set => _annualCharge = value ; }
        public override string CardType { get => _cardType;}
        public override int CreditLimit { get => _creditLimit; set => _creditLimit = value; }
    }
}
