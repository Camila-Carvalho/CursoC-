using System;
using System.Collections.Generic;
using System.Text;

namespace Secao10_PropostoUm.Entidades
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int Hora { get; set; }
        public double ValorHora { get; set; }
        //construtor generico
        public Funcionario()
        {
        }
        //construtor com parametros
        public Funcionario(string nome, int hora, double valorHora)
        {
            Nome = nome;
            Hora = hora;
            ValorHora = valorHora;
        }

        public virtual double Pagamento()
        {
            return Hora * ValorHora;
        }
    }
}
