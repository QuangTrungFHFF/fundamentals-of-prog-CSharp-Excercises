using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Exercise08
{
    public class Customer : IComparable<Customer>
    {
        public CustomerType Type { get; private set; }
        public string Name { get; private set; }
        public string ID { get; private set; } // ID is unique
        public List<Account> Accounts { get; private set; }
        public Customer(string id, string name, CustomerType type)
        {
            this.Name = name;
            this.ID = id;
            this.Type = type;
            this.Accounts = new List<Account>();
        }
        public void AddAccount(AccountTypes accountTypes, double balance)
        {
            if(accountTypes == AccountTypes.Deposit)
            {
                this.Accounts.Add(new DepositAccount(this, balance));
            }
            else if (accountTypes == AccountTypes.Loan)
            {
                this.Accounts.Add(new LoanAccount(this, balance));
            }
            else if (accountTypes == AccountTypes.Mortgage)
            {
                this.Accounts.Add(new MortgageAccount(this, balance));
            }
            else
            {
                Console.WriteLine("This type of account is not supported by the bank!");
            }
        }
        public void AddAccount(AccountTypes accountTypes,double balance, double interest)
        {
            if (accountTypes == AccountTypes.Deposit)
            {
                this.Accounts.Add(new DepositAccount(this, balance, interest));
            }
            else if (accountTypes == AccountTypes.Loan)
            {
                this.Accounts.Add(new LoanAccount(this, balance, interest));
            }
            else if (accountTypes == AccountTypes.Mortgage)
            {
                this.Accounts.Add(new MortgageAccount(this, balance, interest));
            }
            else
            {
                Console.WriteLine("This type of account is not supported by the bank!");
            }
        }        

        public int CompareTo(Customer other)
        {
            return this.ID.CompareTo(other.ID);
        }
        public override bool Equals(object obj)
        {
            if (this.GetType() != obj.GetType())
                return false;
            var that = (Customer)obj;
            return this.ID.Equals(that.ID);
        }

        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }
    }

    public enum CustomerType
    {
        Individual,Company
    }
}