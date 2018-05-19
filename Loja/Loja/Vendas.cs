using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Vendas
    {
        Itens[] itens;

        //metodo para calcular o valor total da venda
        public double CalcularValorVenda()
        {
            double soma = 0;

            //percore todo o vetor de itens buscando pelo preço do produto e a quantidade
            for (int i = 0; i < itens.Length; i++)
            {               
                Produto produto = itens[i].Prod;               

                soma += produto.CalcularPrecoVendaProd() * itens[i].QuantidadeVendida;        
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

                soma += produto.CalcularValorLiquido() * itens[i].QuantidadeVendida;
            }

            return soma;

        }




        //construtor da classe recebe como parametro um vetor de itens
        public Vendas(Itens [] itens)
        {
            this.itens = itens;
        }


        //get e set para o vetor de Itens
        public Itens[] Itens
        {
            get
            {
                return itens;
            }

            set
            {
                itens = value;
            }
        }
    }
}
