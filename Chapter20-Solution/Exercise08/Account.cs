using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise08
{
    class Account
    {
        public Customer Customer { get; set; }
        public double Balance { get; set; }
        public double InterestRate { get; set; }
        public bool AllowDeposit { get; private set; }
        public bool AllowWithdraw { get; private set; }
        public Account(Customer customer, double balance,double interestRate, bool deposit, bool withdraw)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.AllowDeposit = deposit;
            this.AllowWithdraw = withdraw;
        }
        
    }
}
