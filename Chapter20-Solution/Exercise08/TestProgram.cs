using System;

namespace Exercise08
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            var bank = new Bank();
            bank.AddCustomer("ST001", "Barack Obama", CustomerType.Individual);
        }
    }
}
