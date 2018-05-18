using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Itens
    {
        private Produto prod;
        private int quantidadeVendida;

        public Produto Prod
        {
            get
            {
                return prod;
            }

            set
            {
                prod = value;
            }
        }

        public int QuantidadeVendida
        {
            get
            {
                return quantidadeVendida;
            }

            set
            {
                quantidadeVendida = value;
            }
        }
    }
}
