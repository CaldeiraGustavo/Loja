using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class MaterialEscritorio : Produto
    {
        public MaterialEscritorio() : base(string nome, double margemLucro, double precoCusto, int estoqueAtual, int estoqueMinimo){
            if(margemLucro <= 0.05 || margemLucro >= 0.5){
                margemLucro = 0.4;
            }   
        }
        private int porcentImposto = 16;
        protected override int getPorcentagemImposto()
        {
            return porcentImposto;
        }
    }
}
