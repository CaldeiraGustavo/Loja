using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Bebida : Produto
    {
        public Bebida() : base(string nome, double margemLucro, double precoCusto, int estoqueAtual, int estoqueMinimo){
            if(margemLucro <= 0.1 || margemLucro >= 0.5){
                margemLucro = 0.4;
            }               
        }
        private int porcentImposto = 40;
        protected override int getPorcentagemImposto()
        {
            return porcentImposto;
        }
    }
}
