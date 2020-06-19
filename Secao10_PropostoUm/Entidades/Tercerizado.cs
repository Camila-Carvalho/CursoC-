using System;
using System.Collections.Generic;
using System.Text;

namespace Secao10_PropostoUm.Entidades
{
    class Tercerizado : Funcionario
    {
        public double Bonus { get; set; }

        //construtor generico
        public Tercerizado()
        {
        }
        //construtor com parametros próprios e da classe herdada
        public Tercerizado(double bonus, string nome, int hora, double valorHora) : base (nome, hora, valorHora)
        {
            Bonus = bonus;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * Bonus;
        }
    }
}
