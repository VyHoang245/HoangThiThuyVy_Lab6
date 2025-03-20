using Exercise5;

class Program
{
    static void Main()
    {
        IDataService<string> userService = new CachingDecorator<string>(new UserService());
        IDataService<string> productService = new CachingDecorator<string>(new ProductService());

        Console.WriteLine(userService.GetData(1)); // Fetches from DB
        Console.WriteLine(userService.GetData(1)); // Fetches from cache

        Console.WriteLine(productService.GetData(101)); // Fetches from DB
        Console.WriteLine(productService.GetData(101)); // Fetches from cache
    }
}
