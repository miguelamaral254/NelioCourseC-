using ExRevSec10.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace ExRevSec10
{
    internal class Program
    {


        static void Main(string[] args)
        {
            List<Employees> employeeList = new List<Employees>();

            Console.Write("Enter the number of employees:");
            int noe = int.Parse(Console.ReadLine());

            for (int i = 0; i < noe; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("Outsourced (y/n): ");
                char ib = Console.ReadKey().KeyChar;
                bool isOutsourced = IsBool(ib);

                Console.Write("\nName: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (isOutsourced)
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employeeList.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employeeList.Add(new Employees(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employees employee in employeeList)
            {
                Console.WriteLine(employee.Name + " - $ " + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }

        static bool IsBool(char ib)
        {
            char ibToLower = char.ToLower(ib);
            if (ibToLower == 'y')
            {
                return true;
            }
            else if (ibToLower == 'n')
            {
                return false;
            }
            else
            {
                throw new ArgumentException("Invalid input. Enter 'y' for yes or 'n' for no.");
            }

        }
    }
}
