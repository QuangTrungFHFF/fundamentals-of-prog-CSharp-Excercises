using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise08
{
    class MortgageAccount:Account
    {
        public MortgageAccount(Customer customer, double balance, double interestRate) : base(customer, balance, interestRate, true, false)
        {
        }

        public override void PrintInterest(int month)
        {
            Console.WriteLine($"After {month} month, your interest is ${CalculateInterest(month):N2}");
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
