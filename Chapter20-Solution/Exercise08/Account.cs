﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise08
{
    public abstract class Account
    {
        public Customer Customer { get; set; }
        public double Balance { get; set; }
        public double InterestRate { get; set; }
        public bool AllowDeposit { get; private set; }
        public bool AllowWithdraw { get; private set; }
        public AccountTypes Types { get; internal set; }
        public Account(Customer customer, double balance,double interestRate, bool deposit, bool withdraw)
        {
            this.Customer = customer;            
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.AllowDeposit = deposit;
            this.AllowWithdraw = withdraw;
        }
        public override string ToString()
        {
            return string.Format($"Account Type: {Types.ToString().PadRight(7)} | Balance: ${Balance.ToString("N2").PadLeft(15)} | Interest Rate: {(100*InterestRate):N2}% (monthly)");
        }
        protected abstract void AddBalance(double money);
        protected abstract double CalculateInterest(int month);
        public abstract void PrintInterest(int month);
        
        
    }
    public enum AccountTypes
    {
        Deposit,Loan,Mortgage
    }
}
