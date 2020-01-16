using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    class Tomcat:Animal
    {
        public Tomcat(int age, string name, Gender gender):base(age,name,gender)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Maaorrao Maaorrao Maaorrao!!!");
        }
    }
}
