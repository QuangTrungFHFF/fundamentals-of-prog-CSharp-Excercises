using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise03
{
    class Name: IComparable
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Name(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public override string ToString()
        {
            return string.Format(this.FirstName + " " + this.LastName);
        }
        public int CompareTo(object that)
        {
            var n = (Name)that;
            if(this.LastName.CompareTo(n.LastName)==0)
            {
                return this.FirstName.CompareTo(n.FirstName);
            }
            return this.LastName.CompareTo(n.LastName);
        }
    }
}
