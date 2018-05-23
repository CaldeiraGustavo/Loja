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

        public Itens(Produto produto, int quantidade_vendida)
        {
            this.prod = produto;
            this.quantidadeVendida = quantidade_vendida;
        }


        //get e set do produto
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


        //get e set da quantidade vendida
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
