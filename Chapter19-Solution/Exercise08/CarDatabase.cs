using System.Collections.Generic;
using System;
namespace Exercise08
{
    internal class CarDatabase
    {
        private HashSet<Car> database;
        private Dictionary<string, List<Car>> searchByBrand;
        private Dictionary<string, List<Car>> searchByModel;        
        public int Count { get { return database.Count; } }

        public CarDatabase()
        {
            database = new HashSet<Car>();
            searchByBrand = new Dictionary<string, List<Car>>();
            searchByModel = new Dictionary<string, List<Car>>();
        }

        public void Add(Car car)
        {
            if (database.Contains(car))
            {
                return;
            }
            database.Add(car);

            if (!searchByBrand.ContainsKey(car.Brand))
            {
                searchByBrand.Add(car.Brand, new List<Car>());
            }
            searchByBrand[car.Brand].Add(car);

            if (!searchByModel.ContainsKey(car.Model))
            {
                searchByModel.Add(car.Model, new List<Car>());
            }
            searchByModel[car.Model].Add(car);

            
        }

        public void Remove(Car car)
        {
            if (!database.Contains(car))
            {
                return;
            }

            database.Remove(car);
            searchByBrand[car.Brand].Remove(car);
            searchByModel[car.Model].Remove(car);
            
        }

        public void SearchByBrand(string brand)
        {
            var list = new List<Car>();
            if (!searchByBrand.TryGetValue(brand, out list))
            {
                Console.WriteLine($"No car with brand {brand} found!");
            }
            else
            {
                foreach(Car c in list)
                {
                    Console.WriteLine(c.ToString());
                }
            }
        }
        public void SearchByModel(string model)
        {
            var list = new List<Car>();
            if (!searchByModel.TryGetValue(model, out list))
            {
                Console.WriteLine($"No car with brand {model} found!");
            }
            else
            {
                foreach (Car c in list)
                {
                    Console.WriteLine(c.ToString());
                }
            }
        }
        public void SearchByYear(int min, int max)
        {
            var list = new List<Car>();
            foreach(Car c in database)
            {
                if(c.Year>=min && c.Year<=max)
                {
                    list.Add(c);
                }
            }
            list.Sort(delegate (Car c1, Car c2) { return c1.Year.CompareTo(c2.Year); });
            foreach(var c in list)
            {
                Console.WriteLine(c.ToString());
            }
        }
        public void SearchByPrice(double min, double max)
        {
            var list = new List<Car>();
            foreach (Car c in database)
            {
                if (c.Price >= min && c.Price <= max)
                {
                    list.Add(c);
                }
            }
            list.Sort(delegate (Car c1, Car c2) { return c1.Year.CompareTo(c2.Price); });
            foreach (var c in list)
            {
                Console.WriteLine(c.ToString());
            }
        }

    }
}