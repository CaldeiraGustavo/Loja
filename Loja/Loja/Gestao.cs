using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Gestao
    {
        private Vendas[] venda;
        private Estoque[] estoque;       


        public int ProdutoMaisVendUnid()
        {
            return 0;
        }

        public int ProdutoMaiorFaturamento()
        {
            return 0;
        }

        public int ProdutoMaiorLucro()
        {
            return 0;
        }

        public double ValorBrutoFaturado()
        {
            double soma = 0;

            //percore todo o vetor de vendas, somando o valor bruto da venda de cada um
            for (int i = 0; i < venda.Length; i++)
            {
                soma += venda[i].CalcularValorVenda();
            }

            return soma;
        }


        //metodo para retornar o total do valor liquido faturado
        public double ValorLiquidoFaturado()
        {
            double soma = 0;
            
            //percore todo o vetor de vendas, somando o valor liquido da venda de cada um
            for (int i = 0; i < venda.Length; i++)
            {
                soma += venda[i].CalcularValorLiquidoVenda();                
            }

            return soma;
        }
        
        //metodo que retorna um vetor de quantidades vendidas de cada produto
        private int[] Quant_Prod_Vendido()
        {
            //??

            return 0;
        }

        public void RealizarVenda(Itens[] itens)
        {
            //instancia a classe vendas, passando o vetor de itens em seu construtor
            Vendas vendas = new Vendas(itens);

           estoque[1].VerificaEstoque();
            //olhar isso ????



            //vetor de vendas da classe gestão recebe a nova venda
            venda[9] = vendas; // não sei ainda em qual posição passar      ????      
        }

        public void RegistrarPedidosEstoque()
        {
            //??
        }


        //get e set para o vetor de Vendas
        public Vendas[] Vendas
        {
            get
            {
                return venda;
            }

            set
            {
                venda = value;
            }
        }

        //get e set para o vetor de Estoque
        public Estoque[] Estoque
        {
            get
            {
                return estoque;
            }

            set
            {
                estoque = value;
            }
        }


    }
}
