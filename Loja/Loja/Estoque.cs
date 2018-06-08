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

        public void GeraPedReposicaoEstoque(Produto P)
        {
            pedido[qtdPedidos] = new PedidoEstoque(P, true);
            qtdPedidos++;
        }
        public void reporEstoque(int indice) // produto na posição do parametro vai ter seu estoque igual ao dobro do minimo
        { 
            prod[indice].setEstoqueAtual(prod[indice].getEstoqueMinimo()*2);
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
