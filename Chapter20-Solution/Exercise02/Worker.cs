using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise02
{
    class Worker : Human
    {
        public string Name { get { return string.Format($"{FirstName} {LastName}"); } }
        public double Wage { get; set; }
        public double HoursWorked { get; set; }
        public Worker(string firstName, string lastName, double wage, double hours) : base(firstName, lastName)
        {
            this.Wage = wage;
            this.HoursWorked = hours;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (this.GetType() != obj.GetType())
                return false;
            var that = (Worker)obj;
            if (this.Name.Equals(that.Name,StringComparison.OrdinalIgnoreCase) 
                &&this.Wage.Equals(that.Wage) && this.HoursWorked.Equals(that.HoursWorked))
                return true;
            return false;

        }
        public void PrintHourlyPayRate()
        {
            double pay = this.Wage / this.HoursWorked;
            Console.WriteLine($"Hourly Pay Rate: ${pay:N2}");
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Wage.GetHashCode()*2 + HoursWorked.GetHashCode();
        }
        public override string ToString()
        {
            return string.Format($"Name - {Name.PadLeft(25)}");
        }
    }
}
