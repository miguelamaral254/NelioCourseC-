using DesafioSec9.Entities;
using System.Globalization;

namespace DesafioSec9.Orders
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }
        public OrderItem(string pName, double pPrice, int quantity)
        {
            Product = new Product(pName, pPrice);
            Quantity = quantity;
            Price = pPrice;
        }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
            Price = product.Price; 
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Product.Name}, $ {Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {Quantity}, Subtotal: $ {SubTotal().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}

