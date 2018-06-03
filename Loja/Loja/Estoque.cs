using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    static class Estoque
    {

        private Produto[] prod;
        private PedidoEstoque[] pedido; // a cada vez que é feito um pedido de reposição 
        private qtdPedidos=0;
        //ele é guardado nesse vetor

        public void GeraPedReposicaoEstoque(Produto P)
        {
            pedido[qtdPedidos] = new PedidoEstoque(P, false);
            qtdPedidos++;
        }
        public Produto[] Prod
        {
            get{return prod;}

            set{prod = value;}
        }

    }
}
