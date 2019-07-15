using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class MoneyBackCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;
        public MoneyBackCreditCard(int credLimit, int annualCharge)
        {
            _cardType = "MoneyBack";
            _creditLimit = credLimit;
            _annualCharge = annualCharge + 100;
        }

        public override int AnnualCharge { get => _annualCharge; set => _annualCharge = value ; }
        public override string CardType { get => _cardType;}
        public override int CreditLimit { get => _creditLimit; set => _creditLimit = value; }
    }
}
