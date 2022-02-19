using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> ListProducts = new List<Product>()
        {
            new Product () {Name = "Guitar", Price = 1000.00m}
        };
        

        
        
        public List<Product> LoadData()
        {
            
            Console.WriteLine($"I am reading data from ListDataAccess class!");
            
            return ListProducts;
            
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to ListDataAccess!");
        }

       
    }
}
