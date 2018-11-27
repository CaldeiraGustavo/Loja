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

    public Vendas(int codigo_venda, int quantidade_produtos, Itens[] item)
    {
      this.CodigoVenda = codigo_venda;
      this.Quantidade_Produtos = quantidade_produtos;
      this.itens = item;
    }

    /// <summary>
    /// Calcula o valor total bruto da venda
    /// </summary>         
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

    /// <summary>
    /// Calcula o valor total liquido da venda
    /// </summary> 
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

    /// <summary>
    /// Retorna um dicionario de produtos contendo a quantidade vendida de cada
    /// </summary> 
    public IDictionary<Produto, int> Quant_Prod_Vendido()
    {
      IDictionary<Produto, int> Dic_Produtos = new Dictionary<Produto, int>();

      //percore todo o vetor de itens adiconando ao dicionario o produto e a quantidade vendida
      for (int i = 0; i < itens.Length; i++)
      {
        int val = itens[i].Quantidade;

        //verifica se ja não existe o produto no dicionário
        if (Dic_Produtos.Keys.Any(x => x == itens[i].Prod))
        {
          //o produto já existe no dicionário e sua quantidade será incrementada
          int oldVal;
          Dic_Produtos.TryGetValue(itens[i].Prod, out oldVal);
          Dic_Produtos[itens[i].Prod] = oldVal + val;
        }
        //se não existe..
        else
        {
          //o produto ainda não existe no dicionário e será adicionado
          Dic_Produtos.Add(itens[i].Prod, val);          
        }       
      }

      return Dic_Produtos;
    }

    //get e set para o vetor de Itens
    public Itens[] Itens
    {
      get { return this.itens; }

      set { this.itens = value; }
    }


    //get e set para o codigo da venda
    public int codigoVenda
    {
      get { return this.CodigoVenda; }

      set { this.CodigoVenda = value; }
    }

    //get e set para a quantidade produtos
    public int quantidade_produtos
    {
      get { return this.Quantidade_Produtos; }

      set { this.Quantidade_Produtos = value; }
    }

  }
}
