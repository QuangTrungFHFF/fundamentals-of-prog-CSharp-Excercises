using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise07
{
    class Dog : Animal
    {
        public Dog(int age, string name, Gender gender) :base(age,name,gender)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Woof Woof Woof!!!");
        }

    }
}
