﻿using System;
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

    public Gestao(Estoque estoque, List<Vendas> vendas)
    {
      this.estoque = estoque;
      this.lista_Vendas = vendas;
      this.Dic_Temp = Quant_Prod_Vendido();
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
    public double ValorBrutoFaturado()
    {
      double soma = 0;

      foreach (Vendas venda in lista_Vendas)
      {
        soma += venda.CalcularValorVenda();
      }      

      return soma;
    }

    /// <summary>
    /// Percorre todas as vendas e retorna o valor liquido faturado
    /// </summary>    
    public double ValorLiquidoFaturado()
    {
      double soma = 0;
      
      foreach (Vendas venda in lista_Vendas)
      {
        soma += venda.CalcularValorLiquidoVenda();
      }

      return soma;
    }

    /// <summary>
    /// Retorna um dicionário de todos os produtos e sua respectiva quantidade vendida
    /// </summary>     
    private IDictionary<Produto, int> Quant_Prod_Vendido()
    {
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
          }
        }
      }

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
