using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class PedidoEstoque
    {
        private Produto prod;
        private bool concluido;

        public PedidoEstoque(Produto prod, bool concluido){
            this.prod = prod;
            this.concluido = concluido;
        }
        public bool getConcluido()
        {
            return concluido;
        }

        public void AlterarStatus()
        {
            if (concluido)
            {
                concluido = false;
            }else
            {
                concluido = true;
            }
        }
    }
}
