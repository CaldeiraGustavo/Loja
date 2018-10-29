using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
  class Estoque
  {
    private Produto[] prod;
    private List<PedidoEstoque> Listapedidos = new List<PedidoEstoque>(); // a cada vez que é feito um pedido de reposição 
    
    /// <summary>
    /// Método inicial que recebe um produto e a quantidade vendida para prosseguir
    /// com as validações necessárias
    /// </summary>
    public void Ativar(int indice, int quantidade_vendida)
    {
      //faz o estoque do produto atual ser igual ao estoque antigo - a quantidade vendida
      prod[indice].setEstoqueAtual(prod[indice].getEstoqueAtual() - quantidade_vendida);

      //chama o metodo para verificar se é necessário repor o estoque
      this.precisaReporEstoque(indice);
    }

    /// <summary>
    /// Verifica se é necessário repor o estoque
    /// Se for, o método para repor o estoque é chamado
    /// </summary>
    public void precisaReporEstoque(int indice)
    {
      if (prod[indice].getEstoqueAtual() < prod[indice].getEstoqueMinimo())
      {        
        this.reporEstoque(indice);
      }
    }

    /// <summary>
    /// O estoque do produto passado como parâmetro é reposto de acordo com a regra de negócio
    /// </summary>
    public void reporEstoque(int indice) 
    {
      //quantidade a ser reposta (2x o estoque minimo)
      int quantidade_repor = prod[indice].getEstoqueMinimo() * 2;
      //quantidade pedida
      int quantidade_pedido = quantidade_repor - prod[indice].getEstoqueAtual();
      //gera o pedido de reposição
      this.GeraPedReposicaoEstoque(indice, quantidade_pedido);
      //repoe o estoque do produto
      prod[indice].setEstoqueAtual(quantidade_repor);
    }

    /// <summary>
    /// É gerado um pedido de reposição de estoque e adicionado na lista de pedidos
    /// </summary>
    public void GeraPedReposicaoEstoque(int indice, int quantidade)
    {
      PedidoEstoque temp = new PedidoEstoque(prod[indice], quantidade);
      this.Listapedidos.Add(temp);
    }      

    public string ListarPedidos()
    {
      string lista = "";
      for (int i = 0; i < Listapedidos.Count; i++)
      {
        lista += Listapedidos[i].ListarPedido();
      }
      return lista;
    }

    //set e get
    public void setProdutos(Produto[] prod)
    {
      this.prod = prod;
    }
    public Produto[] getProdutos()
    {
      return prod;
    }



  }
}
