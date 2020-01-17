using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise08
{
    class DepositAccount:Account
    {
        public DepositAccount(Customer customer, double balance, double interestRate) :base(customer,balance,interestRate,true,true)
        {            
        }
    }
}
