using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01
{
    class People :IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public People(string firstName, string lastName, int? age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public People(string firstName, string lastName) : this(firstName,lastName,null)
        {

        }

        public int CompareTo(object obj)
        {
            var that = (People)obj;
            if(this.LastName.CompareTo(that.LastName) ==0)
            {
                if(this.FirstName.CompareTo(that.FirstName)==0)
                {
                    return this.Age.GetValueOrDefault().CompareTo(that.Age.GetValueOrDefault());
                }
                return this.FirstName.CompareTo(that.FirstName);
            }
            return this.LastName.CompareTo(that.LastName);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (this.GetType() != obj.GetType())
                return false;
            var that = (People)obj;
            if((this.FirstName.Equals(that.FirstName,StringComparison.OrdinalIgnoreCase))
                &&(this.LastName.Equals(that.LastName, StringComparison.OrdinalIgnoreCase)
                &&((this.Age.GetValueOrDefault().CompareTo(that.Age.GetValueOrDefault()))==0)))
            {
                return true;
            }
            return false;
        }
    }
}
