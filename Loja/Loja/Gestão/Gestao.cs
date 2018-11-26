using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Gestao
    {
        private List<Vendas> lista_Vendas;
        private Estoque estoque;
        private IDictionary<Produto, int> Dic_Temp;
        private double valorLiquidoFaturado;
        private double valorBrutoFaturado;
        private int Quantidade_Produtos;
        private Elemento_QuickSort[] elementos;

        public Gestao(Estoque estoque, List<Vendas> vendas)
        {
            this.estoque = estoque;
            this.lista_Vendas = vendas;
            this.Dic_Temp = this.Quant_Prod_Vendido();
            this.ValorFaturado();
            this.Preencher_VetorProdutos();
        }

        /// <summary>
        /// Preenche um vetor de Produtos e seu respectivo faturamento bruto
        /// </summary>
        private void Preencher_VetorProdutos()
        {
            this.elementos = new Elemento_QuickSort[this.Quantidade_Produtos];

            int cont = 0;

            //percore todo o dicionários de produtos, inserindo no vetor de elementos.
            foreach (Produto produto in this.Dic_Temp.Keys)
            {
                int quant;
                Dic_Temp.TryGetValue(produto, out quant);

                double valor_faturado = quant * produto.CalcularPrecoVendaProd();
                elementos[cont] = new Elemento_QuickSort(produto, valor_faturado);

                cont++;
            }
        }

        /// <summary>
        /// Ordena o Vetor utilizando o método QuickSort
        /// </summary>
        public void Ordenar_Produtos()
        {
            QuickSort quickSort = new QuickSort(this.elementos);
        }

        public string Listar_Produtos()
        {
            string lista = "";

            foreach (Elemento_QuickSort elem in this.elementos)
            {
                lista += elem.Imprimir();
            }

            return lista;
        }

        /// <summary>
        /// Busca qual foi o produto mais vendido em unidades
        /// </summary>
        public string ProdutoMaisVendUnid()
        {
            int maior = 0;
            string produto = "";

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

        /// <summary>
        /// Busca qual foi o produto de maior faturamento
        /// </summary>
        public string ProdutoMaiorFaturamento()
        {
            double maior = 0;
            double temp = 0;
            string produto = "";

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

        /// <summary>
        /// Busca qual foi o produto de maior lucro
        /// </summary>
        public string ProdutoMaiorLucro()
        {
            double maior = 0;
            double temp = 0;
            string produto = "";

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

        /// <summary>
        /// Percorre todas as vendas e retorna o valor bruto faturado
        /// </summary>
        private void ValorFaturado()
        {
            double soma_Bruto = 0;
            double soma_Liquido = 0;

            foreach (Vendas venda in lista_Vendas)
            {
                soma_Bruto += venda.CalcularValorVenda();
                soma_Liquido += venda.CalcularValorLiquidoVenda();
            }

            this.valorBrutoFaturado = soma_Bruto;
            this.valorLiquidoFaturado = soma_Liquido;
        }

        /// <summary>
        /// Retorna o valor Bruto Faturado
        /// </summary>
        public double ValorBrutoFaturado()
        {
            return this.valorBrutoFaturado;
        }

        /// <summary>
        /// Retorna o valor Liquido Faturado
        /// </summary>    
        public double ValorLiquidoFaturado()
        {
            return this.valorLiquidoFaturado;
        }

        /// <summary>
        /// Retorna um dicionário de todos os produtos e sua respectiva quantidade vendida
        /// </summary>     
        private IDictionary<Produto, int> Quant_Prod_Vendido()
        {
            //contador para saber a quantidade de Produtos.
            int cont = 0;

            IDictionary<Produto, int> Dic_Produtos = new Dictionary<Produto, int>();

            //percore toda a lista de vendas
            foreach (Vendas venda in lista_Vendas)
            {
                IDictionary<Produto, int> Dic_Temp = venda.Quant_Prod_Vendido();
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
                        cont++;
                    }
                }
            }

            this.Quantidade_Produtos = cont;
            return Dic_Produtos;
        }

        /// <summary>
        /// Lista os pedidos de reposição de estoque
        /// </summary> 
        public void ListarPedidosReposiçãoEstoque()
        {
            this.estoque.ListarPedidos();
        }


        //get e set para o Estoque
        public void setEstoque(Estoque estoque)
        {
            this.estoque = estoque;
        }
        public Estoque getEstoque()
        {
            return this.estoque;
        }
    }
}
