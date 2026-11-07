
namespace SRP;

public class Print
{

    public void PrintTransactions(List<string> transactions)
    {
        foreach (var transaction in transactions)
        {
            Console.WriteLine(transaction);
        }
    }
}



