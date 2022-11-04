using System;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess()
        {

        }

        public List<Product> LoadData()
        {
            Console.WriteLine("Reading data from the SQL Database");
            return Product.products;
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to the SQL server");
        }
    }
}

