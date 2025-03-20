
using Exercise1_Lab6_CSE422;

public class Program
{
    public static void Main()
    {
        Logger logger = new Logger();

        UserAction userAction = new UserAction { Username = "Hoang", Action = "Login" };
        logger.Log(userAction);

        Transaction transaction = new Transaction { TransactionId = 1, Amount = 99.98 };
        logger.Log(transaction);

        Error error = new Error { ErrorMessage = "NullReferenceException", Timestamp = DateTime.Now };
        logger.Log(error);
    }
}