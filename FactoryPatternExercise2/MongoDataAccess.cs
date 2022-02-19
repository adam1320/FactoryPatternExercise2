using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> MongoProducts = new List<Product>()
        
        {
            new Product () {Name = "Chainsaw", Price = 800.00m}
        };
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from MongoDataAccess class!");
          
            return MongoProducts;
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to MongoDataAccess!");
        }

       
    }
}
