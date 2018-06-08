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
        private Estoque estoque = new Estoque(); // dentro do estoque está o vetor de produtos

        public string ProdutoMaisVendUnid()
        {
            int maior = 0;
            string produto = "";

            IDictionary<Produto, int> Dic_Temp = this.Quant_Prod_Vendido();

            foreach (Produto key in Dic_Temp.Keys)
            {
                int val;
                Dic_Temp.TryGetValue(key, out val);

                if (val > maior)
                {
                    maior = val;
                    produto = key.getNome();
                }
            }

          return produto;
        }

        public string ProdutoMaiorFaturamento()
        {
            double  maior = 0;
            double temp = 0;
            string produto = "";

            IDictionary<Produto, int> Dic_Temp = this.Quant_Prod_Vendido();

            foreach (Produto key in Dic_Temp.Keys)
            {
                int val;
                Dic_Temp.TryGetValue(key, out val);

                temp = val * key.CalcularPrecoVendaProd();

                if (temp > maior)
                {
                    maior = temp;
                    produto = key.getNome();
                }
            }

            return produto;     
        }

        public string ProdutoMaiorLucro()
        {      
            double maior = 0;
            double temp = 0;
            string produto = "";

            IDictionary<Produto, int> Dic_Temp = this.Quant_Prod_Vendido();

            foreach (Produto key in Dic_Temp.Keys)
            {
                int val;
                Dic_Temp.TryGetValue(key, out val);

                temp = val * key.CalcularValorLiquido();

                if (temp > maior)
                {
                  maior = temp;
                  produto = key.getNome();
                }
            }        

            return produto;

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
        private IDictionary<Produto, int> Quant_Prod_Vendido()
        {

            IDictionary<Produto, int> Dic_Produtos = new Dictionary<Produto, int>();

            //percore todo o vetor de vendas
            for (int i = 0; i < venda.Length; i++)
            {
                IDictionary<Produto, int> Dic_Temp = venda[i].Quant_Prod_Vendido();
                foreach (Produto key in Dic_Temp.Keys)
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


    public void ListarPedidosReposiçãoEstoque()
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
    }
}
