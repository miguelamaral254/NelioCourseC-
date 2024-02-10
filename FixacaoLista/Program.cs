using System;
using System.Collections.Generic;

namespace FixacaoLista {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantos empregados serão registrados?");
            int number = int.Parse(Console.ReadLine());

            List<Employee> employeeList = new List<Employee>();
            // Aqui eu fiz um laço para coletar as informações dos funcionários
            for (int i = 1; i <= number; i++) {
                Console.WriteLine("Employee #" + i);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                // Criei uma instância de Employee e adicionei à lista employeeList
                Employee employee = new Employee { Id = id, Name = nome, Salary = salario };

                employeeList.Add(employee);
            }

            Console.WriteLine("\nInformações dos funcionários antes do aumento de salário:");

            // Aqui eu usei um foreach para exibir informações dos employees
            foreach (Employee employee in employeeList) {
                Console.WriteLine($"ID: {employee.Id}, Nome: {employee.Name}, Salário: {employee.Salary}");
            }

            // Aqui solicito o ID do funcionário em questão e a porcentagem de seu aumento
            Console.Write("\nEntre com o ID do employee que você irá aumentar o salário: ");
            int idAumentar = int.Parse(Console.ReadLine());

            // Lambda para encontrar o funcionário que receberá o aumento
            Employee empAumentar = employeeList.Find(e => e.Id == idAumentar);

            if (empAumentar != null) {
                Console.Write($"Entre com a porcentagem do salário que irá aumentar para {empAumentar.Name}: ");
                double percentualAumento = double.Parse(Console.ReadLine());

                // Aqui chamo a função para realizar o aumento do salário do funcionário
                empAumentar.IncreaseSalary(percentualAumento);

                Console.WriteLine("\nInformações dos funcionários após o aumento de salário:");

                // Aqui usei um foreach para exibir as informações atualizadas
                foreach (Employee employee in employeeList) {
                    Console.WriteLine($"ID: {employee.Id}, Nome: {employee.Name}, Salário: {employee.Salary}");
                }
            }
            else {
                Console.WriteLine("Funcionário não encontrado.");

                foreach (Employee employee in employeeList) {
                    Console.WriteLine($"ID: {employee.Id}, Nome: {employee.Name}, Salário: {employee.Salary}");
                }
            }
        }
    }
}