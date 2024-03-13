using ExFixacaoSec10.Entities;

namespace ExFixacaoSec10;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter with the number of products: ");
        int nop = int.Parse(Console.ReadLine());

        List<Product> productlist = new List<Product>();
        for (int i = 1; i <= nop; i++)
        {
            Console.WriteLine($"Product #{i} data:");
            Console.Write("Common, used or imported? (c/u/i): ");
            char pType = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price:");
            double price = double.Parse(Console.ReadLine());

            switch (char.ToLower(pType))
            {
                case 'c':
                    productlist.Add(new Product(name, price));
                    break;
                case 'u':
                    Console.Write("Manufacture date (yyyy-mm-dd): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    productlist.Add(new UsedProduct(name, price, manufactureDate));
                    break;
                case 'i':
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    productlist.Add(new ImportedProduct(name, price, customsFee));
                    break;
                default:
                    Console.WriteLine("Invalid product type. Please enter 'c', 'u', or 'i'.");
                    break;
            }
        }

        Console.WriteLine("\nPRICE TAGS:");
        foreach (Product product in productlist)
        {
            Console.WriteLine(product.PriceTag());
        }
    }
}
