using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise08
{
    public class Bank
    {
        public Dictionary<string,Customer> Customers { get; set; }
        public List<Account> Accounts { get; private set; }
        public Bank()
        {
            this.Customers = new Dictionary<string,Customer>(StringComparer.OrdinalIgnoreCase);
            this.Accounts = new List<Account>();
        }
        public void AddCustomer(string id, string name,CustomerType customerType)
        {
            var customer = new Customer(id, name, customerType);
            if (!this.Customers.ContainsKey(id))
            {
                this.Customers.Add(id,customer);
                this.Customers[id].Bank = this;
            }
            else
            {
                Console.WriteLine("There is a customer with same ID in the database!");
            }
        }
        public void AddCustomer(Customer customer)
        {
            if (!this.Customers.ContainsKey(customer.ID))
            {
                this.Customers.Add(customer.ID,customer);
                this.Customers[customer.ID].Bank = this;
                foreach(Account account in customer.Accounts)
                {
                    this.Accounts.Add(account);
                }
            }
            else
            {
                Console.WriteLine("There is a customer with same ID in the database!");
            }
        }
        public void RemoveCustomer(Customer customer)
        {
            if (this.Customers.ContainsKey(customer.ID))
            { 
                foreach (Account account in customer.Accounts)
                {
                    this.Accounts.Remove(account);
                }
                this.Customers.Remove(customer.ID);
            }
            else
            {
                Console.WriteLine("Customer is not in the database!");
            }
        }
        public void RemoveCustomer(string id)
        {
            if (this.Customers.ContainsKey(id))
            {
                foreach (Account account in this.Customers[id].Accounts)
                {
                    this.Accounts.Remove(account);
                }
                this.Customers.Remove(id);
            }
            else
            {
                Console.WriteLine("Customer is not in the database!");
            }
        }
        
    }
}
