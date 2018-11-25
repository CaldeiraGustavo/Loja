using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Bebida : Produto
    {
        private int porcentImposto = 40;

        public Bebida(string nome, double margemLucro, double precoCusto, int estoqueAtual, int estoqueMinimo) : base(nome, margemLucro, precoCusto, estoqueAtual, estoqueMinimo)
        {
            if (margemLucro <= 0.15)
            {
                this.margemLucro = 0.15;
            }
            else if (margemLucro >= 0.4)
            {
                this.margemLucro = 0.4;
            }
            else
            {
                this.margemLucro = margemLucro;
            }
        }
        protected override int getPorcentagemImposto()
        {
            return porcentImposto;
        }
    }
}
