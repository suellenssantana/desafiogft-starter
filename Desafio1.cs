using System;
using System.Collections.Generic;

namespace Desafio1
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Contato(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome}, Telefone: {Telefone}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Contato> contatos = new List<Contato>();

            
            contatos.Add(new Contato("Maria", "11999999999"));
            contatos.Add(new Contato("João", "11888888888"));

            Console.WriteLine("Lista de Contatos:");
            foreach (var contato in contatos)
            {
                contato.Exibir();
            }
        }
    }
}
