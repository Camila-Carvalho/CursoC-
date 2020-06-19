using System;
using System.Collections.Generic;
using Secao10_PropostoUm.Entidades;

namespace Secao10_PropostoUm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();

            Console.Write("Quantos funcionários precisa cadastrar?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do funcionário nº {i}:");
                Console.Write("Tercerizado (s/n)?");
                char resp = char.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valor = double.Parse(Console.ReadLine());
                if (resp == 's' || resp == 'S')
                {
                    Console.Write("Valor adicional: ");
                    double adicional = double.Parse(Console.ReadLine());
                    lista.Add(new Tercerizado(adicional, nome, horas, valor));
                }
                else
                {
                    lista.Add(new Funcionario(nome, horas, valor));
                }
            }

            Console.WriteLine("Pagamentos: ");
            foreach (Funcionario emp in lista)
            {
                Console.WriteLine($"{emp.Nome} - ${emp.Pagamento()}");
            }
        }
    }
}
