using System;

namespace FactoryPatternExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please enter a database type, List, SQL, or Mongo :");
            var userResponse = Console.ReadLine();
            var ProgramResponse = DataAccessFactory.GetDataAccess(userResponse);

            var ProductList = ProgramResponse.LoadData();
            ProgramResponse.SaveData();

            foreach (var product in ProductList)
            {
                Console.WriteLine($"{product.Name}, {product.Price}");
            }

           
        }
    }
}
