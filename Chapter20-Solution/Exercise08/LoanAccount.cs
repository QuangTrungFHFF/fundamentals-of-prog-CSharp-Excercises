using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise08
{
    class LoanAccount:Account
    {
        public LoanAccount(Customer customer, double balance, double interestRate) : base(customer, balance, interestRate, true,false)
        {
        }
    }
}
