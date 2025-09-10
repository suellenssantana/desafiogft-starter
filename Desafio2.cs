using System;
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Desafio2
#pragma warning restore IDE0130 // Namespace does not match folder structure
{
    public class ContaBancaria
    {
        public decimal Saldo { get; private set; }

        public ContaBancaria(decimal saldoInicial = 0)
        {
            Saldo = saldoInicial;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
                return;
            }
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado com sucesso. Saldo atual: {Saldo:C}");
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser positivo.");
                return;
            }
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque.");
                return;
            }
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Saldo atual: {Saldo:C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria(1000);

            // depósito
            conta.Depositar(500);

            // saque
            conta.Sacar(300);

            // saldo final
            Console.WriteLine($"Saldo final: {conta.Saldo:C}");
        }
    }
}
