using System;
using System.IO;

namespace Exercise08
{
    /// <summary>
    /// Imagine you develop a search engine, which gathers all the advertisements for used cars in ten websites for the last few years. 
    /// After that the search engine allows a quick search by one or several criteria: a brand, model, color, year of production and price. 
    /// You are not allowed to use database management system (like SQL Server, MySQL or MongoDB) and you must implement your own indexing in the memory, 
    /// without storing it to the hard disk and without using LINQ. When one searches by price minimal and maximal price is given. 
    /// When one searches by year of production a starting and ending years are given. What data structures would you use in order to ensure fast searching by one or several criteria?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            
            //CarGenerate carGenerate = new CarGenerate();
            //carGenerate.GetDataBase();           

            CarDatabase database = new CarDatabase();
            string path = Path.Combine((Path.GetFullPath(@"..\..\..\..\") + @"Textfiles\"), "Exercise08.txt");
            using StreamReader streamReader = new StreamReader(path);
            string line;
            while((line = streamReader.ReadLine())!=null)
            {
                database.Add(GetCar(line));                
            }
            Console.WriteLine($"{database.Count} cars found and added to the database");
            database.SearchByBrand("Audi");
            database.SearchByModel("AR439");
            database.SearchByPrice(1900, 2000);
            database.SearchByYear(1999, 2000);

        }
        private static Car GetCar(string line)
        {
            string[] car = line.Split('|', StringSplitOptions.RemoveEmptyEntries);
            string brand = car[0];
            string model = car[1];
            int year = int.Parse(car[2]);
            double price = double.Parse(car[3]);
            var result = new Car(brand, model, year, price);
            return result;
        }
        
    }
}
