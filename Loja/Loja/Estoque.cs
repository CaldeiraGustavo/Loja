using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Estoque
    {

        private Itens[] itens;
        private PedidoEstoque[] pedido; // a cada vez que é feito um pedido de reposição 
        //ele é guardado nesse vetor

        public Itens[] Itens
        {
            get { return itens; }
            set { itens = value; }
        }

        public void RetirarEstoque(Itens item)
        {
            
        }

        public void GeraPedReposicaoEstoque(Produto P)
        {

        }

        public void VerificaEstoque(Produto P)
        {
            for(int i=0; i < itens.lenght; i++){
                if(itens[i].prod.descricao == P.descricao){
                    
                }
            }
        }
    }
}
