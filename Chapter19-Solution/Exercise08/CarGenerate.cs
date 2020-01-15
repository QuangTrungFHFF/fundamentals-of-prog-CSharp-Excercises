using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Exercise08
{
    class CarGenerate
    {
        private readonly List<string> brand = new List<string>() {"Lamborghini", "BMW", "Mercedes", "Toyota", "Ford", "Audi",
         "Porsche","Nissan","Honda","Chevrolet","Aston Martin","Jaguar","Volkswagen","Bugatti","Apple","Lexus","Bentley", "Rolls Royce","Cadillac", "Mazda","Subaru","Tesla"};
        private readonly List<string> model = new List<string>() {"Swift", "AC 3000ME", "Shelby Cobra", "Mercenary", "Light", "Padded",
         "Cap","Barbarian","Leather","Champion","Stormfury", "Footguards","Alpha","Warden",
         "Drape","Barbaric","Diamond","Aquamarine","Jade","Bloodstone","Power","Emerald","Zircon","Sunstone","Onyx","Moonstone","Spinel","Citrine","Agate",
         "Tanzanite","Wolpertinger","Pegasus","Roc","Vermilion","Feather","Yeti","Dragon","Blood","Hydra","Arachne","Spriggan","Wyvern", "Scale","Claw"};
        private readonly List<string> letter = new List<string>() {"A","B","C","D","E","F","W","R","K","I","L","M" };
        public void GetDataBase()
        {
            string path = Path.Combine((Path.GetFullPath(@"..\..\..\..\") + @"Textfiles\"), "Exercise08.txt");
            Random rnd = new Random();
            using StreamWriter streamWriter = new StreamWriter(path);
            for(int i =0; i< 50000;i++)
            {
                streamWriter.WriteLine(GetCar(rnd));
            }
        }
        private string GetCar(Random rnd)
        {
            int brand = rnd.Next(0, this.brand.Count - 1);
            int modelWord = rnd.Next(0, this.model.Count - 1);
            string model = string.Format($"{this.model[modelWord]} {letter[rnd.Next(0,11)]}{letter[rnd.Next(0,11)]}{rnd.Next(0,2000)}");
            int year = 1995 + rnd.Next(0, 25);
            double price = rnd.NextDouble() * 200 + rnd.NextDouble() * 500 + rnd.NextDouble() * 700 + rnd.NextDouble() * 2000 + rnd.NextDouble() * 5000;
            string result = string.Format($"{this.brand[brand]}|{model}|{year}|{price:N0}");
            return result;
        }
        

        

    }
}
