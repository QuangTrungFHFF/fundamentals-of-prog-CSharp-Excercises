using System;
using System.Collections.Generic;

namespace Exercise06
{
    /// <summary>
    /// Implement the following classes: Dog, Frog, Cat, Kitten and Tomcat.
    /// All of them are animals (Animal).
    /// Animals are characterized by age, name and gender.
    /// Each animal makes a sound (use a virtual method in the Animal class).
    /// Create an array of different animals and print on the console their name, age and the corresponding sound each one makes.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new List<Animal>();
            animal.Add(new Dog(4, "Toby", Gender.Male));
            animal.Add(new Cat(3, "Misty",Gender.Female));
            animal.Add(new Kitten(1, "Smol Tiger", Gender.Female));
            animal.Add(new Tomcat(5, "Lucy", Gender.Male));
            animal.Add(new Frog(2, "Rana", Gender.Male));

            foreach(var a in animal)
            {
                Console.WriteLine(a.ToString());
                a.MakeSound();
            }
        }
    }
}
