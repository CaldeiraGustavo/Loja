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
        private int categora; // 1,2,3,4
        private double margemLucro;
        private double precoCusto;
        private int estoqueAtual;
        private int estoqueMinimo;
        
        
        public Produto(string nome, int categora, double margemLucro, double precoCusto, int estoqueAtual, int estoqueMinimo)
        {
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
            return this.precoCusto * this.margemLucro;
        }

        public string Nome
        {
            get { return nome; }

            set { nome = value; }
        }
    }
}
