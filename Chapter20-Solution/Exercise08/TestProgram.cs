using System;

namespace Exercise08
{
    /// <summary>
    /// A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts.
    /// Customers can be individuals or companies. All accounts have a customer, balance and interest rate (monthly based).
    /// Deposit accounts allow depositing and withdrawing of money. Loan and mortgage accounts allow only depositing.
    /// All accounts can calculate their interest for a given period (in months). In the general case, it is calculated as follows: number_of_months * interest_rate.
    /// Loan accounts have no interest rate during the first 3 months if held by individuals and during the first 2 months if held by a company.
    /// Deposit accounts have no interest rate if their balance is positive and less than 1000.
    /// Mortgage accounts have ½ the interest rate during the first 12 months for companies and no interest rate during the first 6 months for individuals.
    /// Your task is to write an object-oriented model of the bank system.
    /// You must identify the classes, interfaces, base classes and abstract actions and implement the interest calculation functionality.
    /// </summary>
    class TestProgram
    {
        static void Main(string[] args)
        {
            var bank = new Bank();
            //Test with invidual customer
            bank.AddCustomer("ST001", "Barack Obama", CustomerType.Individual);
            bank.Customers["ST001"].AddAccount(AccountTypes.Deposit, 20000);
            bank.Customers["ST001"].AddAccount(AccountTypes.Loan, 15000);
            bank.Customers["ST001"].PrintInfo();
            bank.Customers["ST001"].Accounts[0].PrintInterest(18);
            //Test with company customer
            Console.WriteLine("\n\n");
            bank.AddCustomer("ST002", "Google", CustomerType.Company);
            bank.Customers["ST002"].AddAccount(AccountTypes.Deposit, 1000000);
            bank.Customers["ST002"].AddAccount(AccountTypes.Loan, 270000);
            bank.Customers["ST002"].AddAccount(AccountTypes.Mortgage, 380000);
            bank.Customers["ST002"].PrintInfo();
            foreach(Account a in bank.Customers["ST002"].Accounts)
            {
                a.PrintInterest(24);
            }
            

        }
    }
}
