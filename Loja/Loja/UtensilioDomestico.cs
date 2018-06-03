using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class UtensilioDomestico : Produto
    {
        public UtensilioDomestico() : base(string nome, double margemLucro, double precoCusto, int estoqueAtual, int estoqueMinimo){
            if(margemLucro <= 0.1 || margemLucro >= 0.2){
                margemLucro = 0.15;
            }
        }
        private int porcentImposto = 25;
        protected override int getPorcentagemImposto()
        {
            return porcentImposto;
        }
    }
}
