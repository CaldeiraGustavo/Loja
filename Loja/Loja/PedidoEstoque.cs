using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class PedidoEstoque
    {
        private Itens item;
        private bool concluido;

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
