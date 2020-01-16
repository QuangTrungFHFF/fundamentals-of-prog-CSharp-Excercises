using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    class Kitten:Animal
    {
        public Kitten(int age, string name, Gender gender):base(age,name,gender)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Miaou Miaou Miaou!!!");
        }
    }
}
