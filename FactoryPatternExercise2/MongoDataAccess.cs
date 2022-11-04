using System;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {

        }

        public List<Product> LoadData()
        {
            Console.WriteLine("Reading data from the Mongo data base");
            return Product.products;
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to the Mongo data base");
        }
    }
}

