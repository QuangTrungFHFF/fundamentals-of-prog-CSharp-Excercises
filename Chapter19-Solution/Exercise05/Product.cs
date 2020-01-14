using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise05
{
    class Product : IComparable
    {
        public string Barcode { get; private set; }
        public string Producer { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }
        public Product(string barCode, string producer, string name, double price)
        {
            this.Barcode = barCode;
            this.Producer = producer;
            this.Price = price;
            this.Name = name;
        }
        public int CompareTo(object obj)
        {
            var that = (Product)obj;
            if(this.Price.CompareTo(that.Price) == 0)
            {
                return this.Barcode.CompareTo(that.Barcode);
            }
            return this.Price.CompareTo(that.Price);
        }
    }
}
