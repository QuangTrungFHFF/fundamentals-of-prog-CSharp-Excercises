using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise08
{
    class MortgageAccount:Account
    {
        private const double defaultInterest = 0.7 / 100; //(0.7% per month) 
        public MortgageAccount(Customer customer, double balance, double interestRate) : base(customer, balance, interestRate, true, false)
        {
            this.Types = AccountTypes.Mortgage;
        }
        public MortgageAccount(Customer customer, double balance) : base(customer, balance, defaultInterest, true, false)
        {
            this.Types = AccountTypes.Mortgage;
        }
        public override void PrintInterest(int month)
        {
            Console.WriteLine($"After {month} month, your interest is ${CalculateInterest(month):N2}");
        }
        protected override void AddBalance(double money)
        {
            this.Balance += money;
        }

        protected override double CalculateInterest(int month)
        {
            double interest = 0;
            if (this.Customer.Type == CustomerType.Company)
            {
                if (month > 12)
                {
                    month -= 12;
                    interest = 12 * (this.InterestRate/2) + month*this.InterestRate;                    
                }
                else
                {
                    interest = month * (this.InterestRate / 2);
                }
            }
            else
            {
                if (month > 6)
                {
                    month -= 6;
                    interest = month * this.InterestRate;
                }
            }
            return interest;
        }
    }
}
