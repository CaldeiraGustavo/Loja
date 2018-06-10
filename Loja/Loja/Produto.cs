using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    abstract class Produto
    {        
        protected string nome;        
        protected double margemLucro;
        protected double precoCusto;
        protected int estoqueAtual;
        protected int estoqueMinimo;

    public double PrecoCusto { get => precoCusto; set => precoCusto = value; }

    public Produto(string nome, double margemLucro, double precoCusto, int estoqueAtual, int estoqueMinimo)
        {
            this.nome           = nome;
            this.margemLucro    = margemLucro;
            this.estoqueAtual   = estoqueAtual;
            this.estoqueMinimo  = estoqueMinimo;
            this.PrecoCusto     = precoCusto;
        }

        protected abstract int getPorcentagemImposto();

        public double CalcularImposto()
        {
            //Imposto calculado em cima do preço de custo + valor liquido
            return (this.PrecoCusto + this.CalcularValorLiquido())*(getPorcentagemImposto()/100);
        }
        public double CalcularPrecoVendaProd()
        {
            //Preço de venda calculado em cima da soma do PrecoCustom, Imposto e Lucro
            return this.CalcularImposto() + this.CalcularValorLiquido() + this.PrecoCusto;
        }

        //metodo para calcular o valor do lucro do produto
        public double CalcularValorLiquido()
        {
            return this.PrecoCusto * this.margemLucro;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }

        public void setEstoqueAtual(int estoque)
        {
            this.estoqueAtual = estoque;
        }
        public int getEstoqueAtual()
        {
            return estoqueAtual;
        }
        public void setEstoqueMinimo(int estoque)
        {
            this.estoqueMinimo = estoque;
        }
        public int getEstoqueMinimo()
        {
            return estoqueMinimo;
        }
    }
}
