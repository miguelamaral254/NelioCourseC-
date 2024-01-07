using System;
using System.Globalization;
namespace Estoque;
class Program
{
    static void Main(string[] args)
    {

        Produto p = new Produto("Tv", 500.00, 10);

        p.Nome = "TV 4k";
        Console.WriteLine($"{p.Nome} , {p.Preco}, {p.Quantidade}");








        /*

        Console.WriteLine("Entre com os dados do produto:");

        Console.Write("Nome: ");
        string Nome = Console.ReadLine();

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

        */

        /*
        Console.WriteLine($"Dados do produto: {p}");

        Console.WriteLine();
        Console.Write("Digite o número de produtos a ser adcionado no estoque: ");
        int qte = int.Parse(Console.ReadLine());
        p.AdcionarProdutos(qte);

        Console.WriteLine();
        Console.WriteLine($"Dados atualizados: {p}");

        Console.WriteLine();
        Console.Write("Digite o número de produtos a ser removido do estoque: ");
        qte = int.Parse(Console.ReadLine());
        p.RemoverProdutos(qte);

        Console.WriteLine();
        Console.WriteLine($"Dados atualizados: {p}");
        */
    }
}