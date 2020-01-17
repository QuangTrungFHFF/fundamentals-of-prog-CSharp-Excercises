using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise08
{
    class LoanAccount:Account
    {
        private const double defaultInterest = 0.6 / 100; //(0.6% per month) 
        public LoanAccount(Customer customer, double balance, double interestRate) : base(customer, balance, interestRate, true,false)
        {
            this.Types = AccountTypes.Loan;
        }
        public LoanAccount(Customer customer, double balance) : base(customer, balance, defaultInterest, true, false)
        {
            this.Types = AccountTypes.Loan;
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
            if(this.Customer.Type == CustomerType.Company)
            {
                if(month>2)
                {
                    month -= 2;
                }
                interest = month * this.InterestRate;
            }

            if (this.Customer.Type == CustomerType.Individual)
            {
                if (month > 3)
                {
                    month -= 3;
                }
                interest = month * this.InterestRate;
            }
            return interest;
        }
    }
}
