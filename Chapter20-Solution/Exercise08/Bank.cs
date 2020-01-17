using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise08
{
    class Bank
    {
        public List<Customer> Customers { get; set; }
        public Bank()
        {
            this.Customers = new List<Customer>();
        }
        public void AddCustomer(string id, string name,CustomerType customerType)
        {
            var customer = new Customer(id, name, customerType);
            if (!this.Customers.Contains(customer))
            {
                this.Customers.Add(customer);
            }
            else
            {
                Console.WriteLine("There is a customer with same ID in the database!");
            }
        }
        public void RemoveCustomer(string id)
        {
            foreach(var c in this.Customers)
            {
                if (id.Equals(c.ID))
                {
                    this.Customers.Remove(c);
                }
            }
        }
    }
}
