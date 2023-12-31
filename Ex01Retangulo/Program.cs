using System;
using System.Globalization;

namespace Ex01Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a Largura e Altura do retangulo: ");
                        retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            Console.WriteLine($"Área = {retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"Perímetro = {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
