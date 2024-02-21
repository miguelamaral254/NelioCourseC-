using DesafioSec9.Entities;
using DesafioSec9.Enums;
using DesafioSec9.Orders;
using System;
using System.Globalization;

namespace DesafioSec9;

internal class Program
{

    static void Main(string[] args)
    {


        {
            Console.WriteLine("Enter client data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Order data:");
            var orderMoment = DateTime.Now;
            var status = Status.Processing;
            Console.WriteLine($"Status: {status}");
            Console.Write("How many items to this order? ");
            int qItemsOrder = int.Parse(Console.ReadLine());

            Order order = new Order(orderMoment, status);

            for (int i = 1; i <= qItemsOrder; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");

                Console.Write("Product name: ");
                string pName = Console.ReadLine();

                Console.Write("Product price: ");
                double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Parsing com CultureInfo.InvariantCulture para evitar problemas com vírgula ou ponto como separador decimal

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(pName, pPrice, quantity);
                order.AddItem(orderItem); 
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Order summary:");

            Console.WriteLine($"Order moment: {orderMoment}");
            Console.WriteLine($"Order status: {status}");
            Console.WriteLine(client.GetClientInformation());

            Console.WriteLine("Order Items:");
            foreach (var orderItem in order.OrderItems)
            {
                Console.WriteLine(orderItem);
            }

            Console.WriteLine($"Total price: {order.Total().ToString("F2", CultureInfo.InvariantCulture)}"); 
        }
    }
}

/*
Console.WriteLine("Enter client data: ");

Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth Date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());

Client client = new Client(name, email, birthDate);

Console.WriteLine("Order data:");
var orderMomment = DateTime.Now;
var status = Status.Processing;
Console.WriteLine(status);
Console.Write("How many items to this order? ");
int qItemsOrder = int.Parse(Console.ReadLine());

// List<OrderItem> orderItems = new List<OrderItem>();
for (int i = 1; i <= qItemsOrder; i++)
{
    Console.WriteLine($"Enter #{i} item data: ");

    Console.Write("Product name: ");
    string pName = Console.ReadLine();

    Console.Write("Product price: ");
    double pPrice = double.Parse(Console.ReadLine());

    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    OrderItem orderItem = new OrderItem(pName, pPrice, quantity);

    Order ord = new Order(); 

    ord.AddItem(orderItem);
}


Console.WriteLine("Order summary:");

Console.WriteLine($"Order momment:{orderMomment}");
Console.WriteLine(status);
Console.WriteLine(client.GetClientInformation());

Console.WriteLine("Order Items:");
foreach (var orderItem in ord)
{
    Console.WriteLine(orderItem);


}
Order order = new Order(orderMomment, status);
foreach (var item in orderItems)
{

    order.OrderItems = orderItems;
    Console.WriteLine($"Total price: {order.Total().ToString("F2", CultureInfo.InvariantCulture)}");

}
    order.AddOrder(item);

}
}
*/