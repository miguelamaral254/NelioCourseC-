namespace ExFixacaoSec10.Entities;
internal class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    
    public  Product() { }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public virtual string PriceTag()
    {
        return $"{Name} - $ {Price:F2}";
    }

    public override bool Equals(object? obj)
    {
        return obj is Product product &&
               Name == product.Name &&
               Price == product.Price;
    }
}
