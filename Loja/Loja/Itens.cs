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
        private int quantidade;

        public Itens(Produto produto, int quantidade)
        {
            this.prod = produto; 
            this.quantidade = quantidade;
            //diminui a quantidade vendida do estoque atual
            if(this.prod.getEstoqueAtual() - quantidade > 0){
                this.prod.setEstoqueAtual(this.prod.getEstoqueAtual() - quantidade);
                if(this.prod.getEstoqueAtual() < this.prod.getEstoqueMinimo())
                {
                    
                }
            }
        }


        //get e set do produto
        public Produto Prod
        {
            get{return prod;}

            set{prod = value;}
        }

        //get e set da quantidade 
        public int Quantidade
        {
            get{return quantidade;}

            set{quantidade = value;}
        }
    }
}
