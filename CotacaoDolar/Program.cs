namespace CotacaoDolar
{

class Program
{
static void Main(string[] args)
    {
    



    
    double CotValue = double.Parse(Console.ReadLine());
    double BuyDol = double.Parse(Console.ReadLine());

    double Resultado = Conversor.Result(BuyDol, CotValue);

    Console.WriteLine($"{Resultado}");
        
     
    }
}
}