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
        
        public Comida(string nome, double margemLucro, double precoCusto, int estoqueAtual, int estoqueMinimo) : base(nome, margemLucro, precoCusto, estoqueAtual, estoqueMinimo)
        {
            if (margemLucro <= 0.2){
                this.margemLucro = 0.2;
            }else if(margemLucro >= 0.8){
                this.margemLucro = 0.8;
            }else{
                this.margemLucro = margemLucro;
            }
        }
        protected override int getPorcentagemImposto()
        {
            return porcentImposto;
        }
    }
}
