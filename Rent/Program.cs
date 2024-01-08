using System;

namespace Rent
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Quantos quartos serão alugados?");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 10)
            {
                Console.WriteLine("Número inválido. Por favor escolha o número de 1 a 10.");
            }

            RentRoom[] rooms = new RentRoom[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}:");
                Console.WriteLine("Nome: ");
                string name = Console.ReadLine();

                Console.WriteLine("Email: ");
                string email = Console.ReadLine();

                int roomNumber;
                do
                {
                    Console.WriteLine("Quarto (0 à 9): ");
                    if (!int.TryParse(Console.ReadLine(), out roomNumber) || roomNumber < 0 || roomNumber > 9)
                    {
                        Console.WriteLine("Quarto inexistente, tente novamente");
                    }
                    else if (rooms[roomNumber] != null)
                    {
                        Console.WriteLine("Quarto já em uso, tente novamente");
                    }
                } while (roomNumber < 0 || roomNumber > 9 || rooms[roomNumber] != null);

                rooms[roomNumber] = new RentRoom { Name = name, Email = email };
            }


            Console.WriteLine("\nOccupied Rooms:");
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"{i}: {rooms[i]}");
                }
            }
        }
    }

}
