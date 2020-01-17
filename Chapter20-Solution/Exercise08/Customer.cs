using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Exercise08
{
    public class Customer : IComparable<Customer>
    {
        public CustomerType Type { get; private set; }
        public string Name { get; private set; }
        public string ID { get; private set; }
        public List<Account> Accounts { get; private set; }
        public Customer(string id, string name, CustomerType type)
        {
            this.Name = name;
            this.ID = id;
            this.Type = type;
            this.Accounts = new List<Account>();
        }

        public int CompareTo(Customer other)
        {
            return this.ID.CompareTo(other.ID);
        }
    }

    public enum CustomerType
    {
        Individual,Company
    }
}