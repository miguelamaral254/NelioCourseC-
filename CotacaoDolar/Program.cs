using System;
using System.Globalization;
namespace CotacaoDolar

{

    class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("Valor da cotação: ");
            double CotValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor da compra: ");
            double BuyDol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Resultado = Conversor.Result(BuyDol, CotValue);
            Console.WriteLine("---------");

            Console.WriteLine("Valor a ser pago em R$ = " + Resultado.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}