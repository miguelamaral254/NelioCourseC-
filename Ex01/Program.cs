using System;
using Ex01;
using Ex01.services; 
class Program
{
    static void Main(string[] args)
    {
        Pessoa[] pessoas = {
            new Pessoa("Maria", 17,1),
            new Pessoa("João", 16, 0),
            new Pessoa("Flay",20,3)
        };
        for (int i = 0; i < pessoas.Length ;i++)
        {
            Console.WriteLine($"Pessoa {i+1}:");
            Console.WriteLine($"Nome: {pessoas[i].Nome}");
            Console.WriteLine();
            Console.WriteLine($"Idade: {pessoas[i].Idade}");
            Console.WriteLine("----------------------------");

        }
        MaisVelha.EncontrarMaisVelha(pessoas);
        

        
        


    }
    
}