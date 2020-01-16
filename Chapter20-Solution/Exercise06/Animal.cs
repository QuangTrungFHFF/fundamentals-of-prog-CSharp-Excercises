using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    public class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Animal(int age, string name, Gender gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }
        public virtual void MakeSound()
        {

        }
        public override string ToString()
        {
            return string.Format($"Name: {Name} | Age: {Age} | Gender: {Gender}");
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (this.GetType() != obj.GetType())
                return false;
            var that = (Animal)obj;
            return this.GetHashCode().Equals(that.GetHashCode());
        }

        public override int GetHashCode()
        {
            int hash = Age.GetHashCode();
            hash += Name.GetHashCode();
            hash += Gender.GetHashCode();
            return hash;
        }
    }
    public enum Gender
    {
        Male,Female,
    }
}
