using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise08
{
    class MortgageAccount
    {
        public MortgageAccount(Customer customer, double balance, double interestRate) : base(customer, balance, interestRate, true, false)
        {
        }
    }
}
