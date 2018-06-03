using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Comida : Produto
    {
        public Comida() : base(string nome, double margemLucro, double precoCusto, int estoqueAtual, int estoqueMinimo){
            if(margemLucro <= 0.2 || margemLucro >= 0.8){
                margemLucro = 0.6;
            }
        }
        private int porcentImposto = 18;
        protected override int getPorcentagemImposto()
        {
            return porcentImposto;
        }
    }
}
