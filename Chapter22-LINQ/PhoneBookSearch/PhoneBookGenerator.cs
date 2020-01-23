using System;
using System.Collections.Generic;
using System.Text;
using RandomNameGeneratorLibrary;
using System.Linq;

namespace PhoneBookSearch
{
    class PhoneBookGenerator
    {
        private HashSet<string> names;
        private HashSet<string> phoneNumbers;
        public PhoneBookGenerator()
        {
            this.names = new HashSet<string>();
            this.phoneNumbers = new HashSet<string>();
        }

        public Dictionary<string,string> Generator(int number)
        {
            var phoneBook = new Dictionary<string, string>();
            GetNameList(number);
            GetPhonesList(number);
            var names = this.names.ToList();
            var phoneNumbers = this.phoneNumbers.ToList();
            for(int i =0; i< number; i++)
            {
                phoneBook.Add(names[i], phoneNumbers[i]);
            }
            return phoneBook;
        }
        private void GetNameList(int number)
        {
            var personGenerator = new PersonNameGenerator();
            while (this.names.Count < number+1)
            {
                var newName = personGenerator.GenerateRandomFirstAndLastName();
                this.names.Add(newName);
            }
        }
        private void GetPhonesList(int number)
        {
            Random rnd = new Random();
            string phoneNumber = "+49";
            int firstPart;
            int lastPart;
            while (this.phoneNumbers.Count < number+1)
            {
                firstPart = rnd.Next(1500, 1999);
                lastPart = rnd.Next(0000000, 9999999);
                this.phoneNumbers.Add($"{phoneNumber}{firstPart}{lastPart}");
            }
        }
    }
}
