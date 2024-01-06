namespace CotacaoDolar
{


class Conversor
{

   public static double Iof = 6.0;
    
 public static double  Result(double CotValue, double BuyDol) {
    double total = CotValue * BuyDol;
    return total + total * (Iof / 100.0);
}
}

}
