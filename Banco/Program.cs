using System;
using System.Globalization;

namespace Banco

{
    class Program
    {
        private static void Main(string[] args)
        {

            Console.Write("Digite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do Titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n) ");
            char respostaDepInicial = char.Parse(Console.ReadLine());

            double depInicial = 0;
            if (respostaDepInicial == 's' || respostaDepInicial == 'S')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Conta conta = new Conta(numeroConta, titular, depInicial);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta: {conta.NumeroConta}, Titular: {conta.Titular}, Saldo: R$ {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("");

            Console.Write("Digite o valor do depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.AdicionarSaldo(valorDeposito);
            Console.WriteLine("");

            Console.WriteLine("Dados atualizados:");
            Console.WriteLine($"Conta: {conta.NumeroConta}, Titular: {conta.Titular}, Saldo: R$ {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("");

            Console.Write("Digite o valor do saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.SaqueSaldo(valorSaque);
            Console.WriteLine("");

            Console.WriteLine("Dados atualizados:");
            Console.WriteLine($"Conta: {conta.NumeroConta}, Titular: {conta.Titular}, Saldo: R$ {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");

        }

    }
}
