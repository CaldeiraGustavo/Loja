using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Vendas
    {
        int CodigoVenda;
        int Quantidade_Produtos;
        Itens[] itens;

        //metodo para calcular o valor total da venda
        public double CalcularValorVenda()
        {
            double soma = 0;

            //percore todo o vetor de itens buscando pelo preço do produto e a quantidade
            for (int i = 0; i < itens.Length; i++)
            {               
                Produto produto = itens[i].Prod;               

                soma += produto.CalcularPrecoVendaProd() * itens[i].Quantidade;        
            }

            return soma;     
                       
        }

        //metodo para calcular o valor liquido da venda
        public double CalcularValorLiquidoVenda()
        {
            double soma = 0;

            //percore todo o vetor de itens buscando pelo valor liquido de cada produto
            //em seguida, multiplica pela quantidade vendida
            for (int i = 0; i < itens.Length; i++)
            {
                Produto produto = itens[i].Prod;

                soma += produto.CalcularValorLiquido() * itens[i].Quantidade;
            }

            return soma;

        }

        //metodo para retornar um dicionario de produtos contendo a quantidade vendida
        public IDictionary<string, int> Quant_Prod_Vendido()
        {

            IDictionary<string, int> Dic_Produtos = new Dictionary<string, int>();            

            //percore todo o vetor de itens adiconando ao dicionario o nome do produto e a quantidade vendida
            for (int i = 0; i < itens.Length; i++)
            {                
                Dic_Produtos.Add(itens[i].Prod.Nome, itens[i].Quantidade);
            }

            return Dic_Produtos;

        }


            //construtor da classe 
            public Vendas(int codigo_venda, int quantidade_produtos, Itens [] item)
        {
            this.CodigoVenda = codigo_venda;
            this.Quantidade_Produtos = quantidade_produtos;
            this.itens = item;            
        }


        //get e set para o vetor de Itens
        public Itens[] Itens
        {
            get{return itens;}

            set{itens = value;}
        }


        //get e set para o codigo da venda
        public int codigoVenda
        {
            get{return this.CodigoVenda;}

            set{this.CodigoVenda = value;}
        }

        //get e set para a quantidade produtos
        public int quantidade_produtos
        {
            get{return this.Quantidade_Produtos;}

            set{this.Quantidade_Produtos = value;}
        }

    }
}
