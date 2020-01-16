using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise02
{
    class Human :IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }        

        public int CompareTo(object obj)
        {
            var that = (Human)obj;
            if(this.LastName.CompareTo(that.LastName) ==0)
            { 
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
            var that = (Human)obj;
            if((this.FirstName.Equals(that.FirstName,StringComparison.OrdinalIgnoreCase))
                &&(this.LastName.Equals(that.LastName, StringComparison.OrdinalIgnoreCase)))
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hash = FirstName.Length + LastName.Length;
            hash += FirstName.GetHashCode();
            hash += LastName.GetHashCode()*2;
            return hash;
        }
    }
}
