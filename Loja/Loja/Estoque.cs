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
        private int qtdPedidos;
        //ele é guardado nesse vetor

        public void GeraPedReposicaoEstoque(Produto P)
        {
            pedido[qtdPedidos] = new PedidoEstoque(P, false);
            qtdPedidos++;
        }
        public void setProduto(Produto[] prod)
        {
            this.prod = prod;
        }
        public Produto[] getProduto()
        {
            return prod;
        }

    }
}
