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
            Console.WriteLine($"Customer: {this.Customer.Name}");
            Console.WriteLine(this.ToString());
            Console.WriteLine($"After {month} month, the interest is ${CalculateInterest(month):N2}");
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
                    interest = 12 * (this.InterestRate/2) * Balance + month*this.InterestRate * Balance;                    
                }
                else
                {
                    interest = month * (this.InterestRate / 2) * Balance;
                }
            }
            else
            {
                if (month > 6)
                {
                    month -= 6;
                    interest = month * this.InterestRate * Balance;
                }
            }
            return interest;
        }
    }
}
