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

        public Produto(string nome, double margemLucro, double precoCusto, int estoqueAtual, int estoqueMinimo)
        {
            this.nome = nome;
            this.margemLucro = margemLucro;
            this.estoqueAtual = estoqueAtual;
            this.estoqueMinimo = estoqueMinimo;
            this.precoCusto = precoCusto;
        }

        protected abstract int getPorcentagemImposto();

        /// <summary>
        /// Calcula o valor do Imposto
        /// </summary>   
        public double CalcularImposto()
        {
            //Imposto calculado em cima do preço de custo + valor liquido
            return (this.precoCusto + this.CalcularValorLiquido()) * (getPorcentagemImposto() / 100);
        }

        /// <summary>
        /// Calcula o preço de venda do Produto
        /// </summary>   
        public double CalcularPrecoVendaProd()
        {
            //Preço de venda calculado em cima da soma do PrecoCustom, Imposto e Lucro
            return this.CalcularImposto() + this.CalcularValorLiquido() + this.precoCusto;
        }

        /// <summary>
        /// Calcula o valor liquido (lucro)
        /// </summary> 
        public double CalcularValorLiquido()
        {
            return this.precoCusto * this.margemLucro;
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
        public void setPrecoCusto(double precoCusto)
        {
            this.precoCusto = precoCusto;
        }
        public double getPrecoCusto()
        {
            return precoCusto;
        }
    }
}
