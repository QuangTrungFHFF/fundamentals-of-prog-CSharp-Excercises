using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise08
{
    class Car : IComparable
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public double Price { get; private set; }
        public Car(string brand, string model, int year, double price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }
        public override string ToString()
        {
            return string.Format($"Brand: {Brand.PadLeft(12)} | Model: {Model.PadLeft(30)} | Year: {Year.ToString().PadLeft(6)} | Price: ${Price.ToString("N2").PadLeft(12)}");
        }
        public int CompareTo(object obj)
        {
            var that = (Car)obj;
            if(this.Model.CompareTo(that.Model) ==0)
            {
                if(this.Brand.CompareTo(that.Brand)==0)
                {
                    if(this.Year.CompareTo(that.Year)==0)
                    {
                        return this.Price.CompareTo(that.Price);
                    }
                    return this.Year.CompareTo(that.Year);
                }
                return this.Brand.CompareTo(that.Brand);
            }
            return this.Model.CompareTo(that.Model);
        }
    }
}
