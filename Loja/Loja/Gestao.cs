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
        private Estoque estoque;
        private Produto[] produtos;

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
        
        //pesquisar como implementar um dicionário
        private IDictionary<string, int> Quant_Prod_Vendido()
        {

            IDictionary<string, int> Dic_Produtos = new Dictionary<string, int>();            

            //percore todo o vetor de vendas
            for (int i = 0; i < venda.Length; i++)
            {
                
                venda[i].Quant_Prod_Vendido;     //tirar duvida          
                                
            }

            return Dic_Produtos;
        }
        

        public void RegistrarPedidosEstoque()
        {
            //??
        }


        //get e set para o vetor de Vendas
        public Vendas[] Vendas
        {
            get{return venda;}

            set{venda = value;}
        }

        //get e set para o Estoque
        public Estoque Estoque
        {
            get{return estoque;}

            set{estoque = value;}
        }

        //get e set para o vetor de Produtos
        public Produto [] Produtos
        {
            get { return produtos; }

            set { produtos = value; }
        }


    }
}
