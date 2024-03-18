using System;
using System.Collections.Generic;
using System.Globalization;
using ExPropSec10.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Pessoa> list = new List<Pessoa>();

        Console.Write("Entre como o número de pessoas: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Dados da pessoa #{i}:");
            Console.Write("Você é Pessoa Jurídica? (s/n)? ");
            char tipoDePessoa = char.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            String nome = Console.ReadLine();
            Console.Write("Renda anual: ");
            double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (tipoDePessoa == 'n')
            {
                Console.Write("Gastos com saúde: ");
                double gastosComSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new PessoaFisica(nome, rendaAnual, gastosComSaude));
            }
            else
            {
                Console.Write("Número de empregados: ");
                int numeroDeEmpregados = int.Parse(Console.ReadLine());
                list.Add(new PessoaJuridica(nome, rendaAnual, numeroDeEmpregados));
            }
        }

        double sum = 0.0;
        Console.WriteLine();
        Console.WriteLine("Impostos pagos:");
        foreach (Pessoa tp in list)
        {
            double imposto = tp.Imposto();
            Console.WriteLine(tp.Nome + ": $ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            sum += imposto;
        }

        Console.WriteLine();
        Console.WriteLine("Total de ipostos pagos: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
    }
}
