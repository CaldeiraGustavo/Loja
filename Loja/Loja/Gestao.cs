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

        public string ProdutoMaisVendUnid()
        {
            int maior = 0;
            string produto = "";

            IDictionary<string, int> Dic_Temp = this.Quant_Prod_Vendido();

            foreach (string key in Dic_Temp.Keys)
            {
                int val;
                Dic_Temp.TryGetValue(key, out val);

                if (val > maior)
                {
                    maior = val;
                    produto = key;
                }
            }

          return produto;
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

          //metodo para retornar um dicionario de todos os produtos contendo a quantidade vendida
        private IDictionary<string, int> Quant_Prod_Vendido()
        {

            IDictionary<string, int> Dic_Produtos = new Dictionary<string, int>();

            //percore todo o vetor de vendas
            for (int i = 0; i < venda.Length; i++)
            {
                IDictionary<string, int> Dic_Temp = venda[i].Quant_Prod_Vendido();
                foreach (string key in Dic_Temp.Keys)
                {
                    int val;
                    Dic_Temp.TryGetValue(key, out val);
                    //se existe...
                    if (Dic_Produtos.Keys.Any(x => x == key))
                    {
                      //o produto já existe no dicionário e sua quantidade será incrementada
                      int oldVal;
                      Dic_Produtos.TryGetValue(key, out oldVal);
                      Dic_Produtos[key] = oldVal + val;
                    }
                    //se não existe..
                    else
                    {
                      //o produto ainda não existe no dicionário e será adicionado
                      Dic_Produtos.Add(key, val);
                    }
                }
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
        public void setEstoque(Estoque estoque)
        {
            this.estoque = estoque;
        }
        public Estoque getEstoque()
        {
            return estoque;
        }
        //get e set para o vetor de Produtos
        public Produto [] Produtos
        {
            get { return produtos; }

            set { produtos = value; }
        }


    }
}
