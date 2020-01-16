using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    class Frog:Animal
    {
        public Frog(int age, string name, Gender gender):base(age,name,gender)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Ribbit Ribbit Ribbit!!!");
        }
    }
}
