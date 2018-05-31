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
        
        public Produto(double margemLucro, string descricao, int id, int estoqueMinimo, double precoCusto){
            this.double         = double;             
            this.margemLucro    = margemLucro;
            this.descricao      = descricao;
            this.id             = id;
            this.estoqueMinimo  = estoqueMinimo;
            this.precoCusto     = precoCusto;
        }

        protected abstract int getPorcentagemImposto();

        public double CalcularImposto()
        {
            return precoCusto * (getPorcentagemImposto()/100);
        }
        public double CalcularPrecoVendaProd()
        {
            return this.CalcularImposto() + precoCusto;
        }
        //metodo para calcular o valor liquido do produto
        public double CalcularValorLiquido()
        {
            return this.CalcularPrecoVendaProd() - this.CalcularImposto();
        }
    }
}
