using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{

    public class UserService : IDataService<string>
    {
        public string GetData(int userId)
        {
            Console.WriteLine("Fetching from database...");
            return $"User {userId}";
        }
    }

    public class ProductService : IDataService<string>
    {
        public string GetData(int productId)
        {
            Console.WriteLine("Fetching from database...");
            return $"Product {productId}";
        }
    }

}
