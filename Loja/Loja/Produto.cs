using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    abstract class Produto
    {        
        private string nome;        
        private double margemLucro;
        private double precoCusto;
        private int estoqueAtual;
        private int estoqueMinimo;
        
        
        public Produto(string nome, double margemLucro, double precoCusto, int estoqueAtual, int estoqueMinimo)
        {
            this.nome           = nome;
            this.margemLucro    = margemLucro;
            this.estoqueAtual   = estoqueAtual;
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
            return this.CalcularImposto() + this.CalcularValorLiquido() + precoCusto;
        }

        //metodo para calcular o valor liquido do produto
        public double CalcularValorLiquido()
        {
            return this.precoCusto * this.margemLucro;
        }

        public string Nome
        {
            get { return this.nome; }

            set { this.nome = value; }
        }

        public int EstoqueAtual
        {
            get { return this.estoqueAtual; }

            set { this.estoqueAtual = value; }
        }
    }
}
