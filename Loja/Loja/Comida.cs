using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Comida : Produto
    {
        private int porcentImposto = 18;
        protected override int getPorcentagemImposto()
        {
            return porcentImposto;
        }
    }
}
