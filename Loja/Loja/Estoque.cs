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

        public Produto[] Prod
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

        public void RetirarEstoque(Produto P, int quantidade)
        {

        }

        public void GeraPedReposicaoEstoque(Produto P)
        {

        }

        public void VerificaEstoque()
        {

        }
    }
}
