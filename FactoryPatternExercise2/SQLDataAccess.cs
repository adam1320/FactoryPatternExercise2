using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> SQLProducts = new List<Product>()
       
        {
            new Product () {Name = "Computer", Price = 900.00m}
        };
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from SQLDataAccess class!");
            
            return SQLProducts;

        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to SQLDataAccess!");
        }

       
    }
}
