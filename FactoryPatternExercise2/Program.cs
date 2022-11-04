namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database do you need? List, SQL, or Mongo?");
            var response = Console.ReadLine().ToLower();


            IDataAccess data = DataAccessFactory.GetDataAccessType(response);

            data.SaveData();
                Console.WriteLine();

            var productList = data.LoadData();

            Console.WriteLine("Here are your items: ");
            foreach(var item in productList)
            {
                Console.WriteLine($"Product Name: {item.Name}");
                Console.WriteLine($"Price: {item.Price}");
            }
        }
    }
}
