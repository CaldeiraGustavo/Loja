using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class UtensilioDomestico : Produto
    {
        private int porcentImposto;
        protected override int getPorcentagemImposto()
        {
            return 0;
        }

    }
}
