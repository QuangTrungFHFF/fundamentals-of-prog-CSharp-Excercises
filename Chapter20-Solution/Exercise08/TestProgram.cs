using System;

namespace Exercise08
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            var bank = new Bank();
            bank.AddCustomer("ST001", "Barack Obama", CustomerType.Individual);
            bank.Customers["ST001"].AddAccount(AccountTypes.Deposit, 20000);
            bank.Customers["ST001"].AddAccount(AccountTypes.Loan, 15000);
            bank.Customers["ST001"].PrintInfo();
            bank.Customers["ST001"].Accounts[0].PrintInterest(12);
        }
    }
}
