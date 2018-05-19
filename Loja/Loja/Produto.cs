using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    abstract class Produto
    {
        private double margemLucro;
        private string descricao;
        private int id;
        private int estoqueMinimo;
        private double precoCusto;

        protected abstract int getPorcentagemImposto();

        public double CalcularImposto()
        {
            return 0;
        }
        public double CalcularPrecoVendaProd()
        {
            return 0;
        }

        //metodo para calcular o valor liquido do produto
        public double CalcularValorLiquido()
        {
            double valor = this.CalcularPrecoVendaProd() - this.CalcularImposto();

            return valor;
        }
    }
}
