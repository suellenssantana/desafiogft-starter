using System;
using Desafio1;
using Desafio2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== menu ===");
        Console.WriteLine("1 - lista de contatos");
        Console.WriteLine("2 - caixa eletronico");
        Console.Write("Escolha uma opção: ");

        string opcao = Console.ReadLine() ?? "";

        switch (opcao)
        {
            case "1":
                ExecutarDesafio1();
                break;

            case "2":
                ExecutarDesafio2();
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }

    static void ExecutarDesafio1()
    {
        Console.WriteLine("\n--- Desafio 1 ---");
        var contatos = new System.Collections.Generic.List<Desafio1.Contato>
        {
            new Desafio1.Contato("Ana", "11999999999"),
            new Desafio1.Contato("João", "11888888888")
        };

        Console.WriteLine("Lista de Contatos:");
        foreach (var contato in contatos)
        {
            contato.Exibir();
        }
    }

    static void ExecutarDesafio2()
    {
        Console.WriteLine("\n--- Desafio 2 ---");
        var conta = new Desafio2.ContaBancaria(1000);

        conta.Depositar(500);
        conta.Sacar(300);

        Console.WriteLine($"Saldo final: {conta.Saldo:C}");
    }
}
