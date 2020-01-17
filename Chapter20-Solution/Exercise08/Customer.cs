using System;
using System.Collections.Generic;

namespace Exercise08
{
    public class Customer : IComparable<Customer>
    {
        public CustomerType Type { get; private set; }
        public string Name { get; private set; }
        public string ID { get; private set; } // ID is unique
        public List<Account> Accounts { get; private set; }
        public Bank Bank { get; set; }

        public Customer(string id, string name, CustomerType type)
        {
            this.Name = name;
            this.ID = id;
            this.Type = type;
            this.Accounts = new List<Account>();
        }

        public void AddAccount(AccountTypes accountTypes, double balance)
        {
            Account account;
            if (accountTypes == AccountTypes.Deposit)
            {
                account = new DepositAccount(this, balance);
            }
            else if (accountTypes == AccountTypes.Loan)
            {
                account = new LoanAccount(this, balance);
            }
            else if (accountTypes == AccountTypes.Mortgage)
            {
                account = new MortgageAccount(this, balance);
            }
            else
            {
                Console.WriteLine("This type of account is not supported by the bank!");
                return;
            }
            this.Accounts.Add(account);
            this.Bank.Accounts.Add(account);
        }

        public void AddAccount(AccountTypes accountTypes, double balance, double interest)
        {
            Account account;
            if (accountTypes == AccountTypes.Deposit)
            {
                account = new DepositAccount(this, balance,interest);
            }
            else if (accountTypes == AccountTypes.Loan)
            {
                account = new LoanAccount(this, balance, interest);
            }
            else if (accountTypes == AccountTypes.Mortgage)
            {
                account = new MortgageAccount(this, balance, interest);
            }
            else
            {
                Console.WriteLine("This type of account is not supported by the bank!");
                return;
            }
            this.Accounts.Add(account);
            this.Bank.Accounts.Add(account);
        }
        public void PrintInfo()
        {
            Console.WriteLine(this.ToString());
            Console.WriteLine("-----------------------------------------------------------------------------------");
            foreach(var a in this.Accounts)
            {
                Console.WriteLine(a.ToString());
            }
            Console.WriteLine("-----------------------------------------------------------------------------------");

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
        public override string ToString()
        {
            return string.Format($"Customer ID: {ID.PadRight(8)} | Customer Type: {Type.ToString().PadRight(7)} | Name: {Name.PadRight(15)}");
        }
    }

    public enum CustomerType
    {
        Individual, Company
    }
}