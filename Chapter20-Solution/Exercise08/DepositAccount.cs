using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise08
{
    class DepositAccount:Account
    {
        private const double defaultInterest = 0.5/100; //(0.5% per month) 
        public DepositAccount(Customer customer, double balance, double interestRate) :base(customer,balance,interestRate,true,true)
        {
            this.Types = AccountTypes.Deposit;
        }
        public DepositAccount(Customer customer, double balance) : base(customer, balance, defaultInterest, true, true)
        {
            this.Types = AccountTypes.Deposit;
        }

        public override void PrintInterest(int month)
        {
            Console.WriteLine($"After {month} month, your interest is ${CalculateInterest(month):N2}");
        }

        protected override double CalculateInterest(int month)
        {
            double interest = 0;
            if(this.Balance >= 1000)
            {
                interest = month * this.InterestRate;
            }
            return interest;
        }

        protected override void AddBalance(double money)
        {
            this.Balance += money;
        }
    }
}
