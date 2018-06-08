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
        private PedidoEstoque[] pedido; // a cada vez que é feito um pedido de reposição 
    private int qtdPedidos; //ele é guardado nesse vetor

    public PedidoEstoque[] Pedido { get => pedido; set => pedido = value; }

    public Estoque()
    {
      this.qtdPedidos = 0;
    }
        public void GeraPedReposicaoEstoque(Produto P, int quantidade)
        {
            Pedido[qtdPedidos] = new PedidoEstoque(P, quantidade);
            qtdPedidos++;
        }
        public void reporEstoque(int indice) // produto na posição do parametro vai ter seu estoque igual ao dobro do minimo
        {
      int quantidade_repor = prod[indice].getEstoqueMinimo() * 2;

      int quantidade_pedido = quantidade_repor - prod[indice].getEstoqueAtual();

            prod[indice].setEstoqueAtual(prod[indice].getEstoqueMinimo()*2);

      this.GeraPedReposicaoEstoque(prod[indice], quantidade_pedido );
            
        }
        public bool precisaReporEstoque(Produto p) // verifica se precisa repor o estoque
        {
            if (p.getEstoqueAtual() < p.getEstoqueMinimo())
            {       

                  return true;
            }else
            {
                return false;
            }
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
