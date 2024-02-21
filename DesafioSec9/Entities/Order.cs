using DesafioSec9.Enums;
using DesafioSec9.Orders;


namespace DesafioSec9.Entities;
internal class Order
{
    public DateTime Momment { get; set; }
    public Status Status { get; set; }
    public Client Client { get; set; }
    public List<OrderItem> OrderItems { get; set; }

    public Order() { }

    public Order(DateTime momment, Status status)
    {
        Momment = momment;
        Status = status;
        OrderItems = new List<OrderItem>();
    }
    public void AddItem(OrderItem orderItem)
    {
        OrderItems.Add(orderItem);
    }
    public void RemoveItem(OrderItem orderItem)
    {
        OrderItems.Remove(orderItem);
    }
    public double Total()
    {
        double sumTotal = 0;
        foreach (var orderItem in OrderItems)
        {
            sumTotal += orderItem.SubTotal();
        }

        return sumTotal;
    }
}
