using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    class FullName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return string.Format(FirstName + " " + LastName);
        }
    }
}
