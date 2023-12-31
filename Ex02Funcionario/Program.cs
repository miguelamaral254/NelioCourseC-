using System;
using System.Globalization;
namespace Ex02Funcionario

{
    class Program
{
    static void Main(string[] args)
    {
       Funcionario funcionario = new Funcionario();

       Console.WriteLine($"Entre com os dados do funcionáro:");
       Console.WriteLine("Nome: ");
       funcionario.Nome = Console.ReadLine();
       Console.WriteLine("Salário bruto: ");
       funcionario.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
       Console.WriteLine("Imposto: ");
       funcionario.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
       Console.WriteLine();

        Console.WriteLine($"Funcionário: {funcionario.Nome}, ${funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine();
        Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
        funcionario.AumentoS = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine($"Dados Atualizados: {funcionario.Nome}, ${funcionario.NovoSalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");
        
       
       
    }
}
}