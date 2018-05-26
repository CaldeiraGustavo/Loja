using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Bebida : Produto
    {
        private int porcentImposto = 40;
        protected override int getPorcentagemImposto()
        {
            return porcentImposto;
        }
    }
}
