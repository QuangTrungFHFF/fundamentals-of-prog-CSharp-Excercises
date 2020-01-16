using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    class Cat:Animal
    {
        public Cat(int age, string name, Gender gender):base(age,name,gender)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Meow Meow Meow!!!");
        }
    }
}
