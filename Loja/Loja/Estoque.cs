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
        private List<PedidoEstoque> Listapedidos = new List<PedidoEstoque>(); // a cada vez que é feito um pedido de reposição 
                

        public void Ativar(int indice, int quantidade_vendida)
        {
            //faz o estoque do produto atual ser igual ao estoque antigo - a quantidade vendida
            prod[indice].setEstoqueAtual(prod[indice].getEstoqueAtual() - quantidade_vendida);

            //chama o metodo para verificar o estoque
            this.precisaReporEstoque(indice);
        }

        public void GeraPedReposicaoEstoque(int indice, int quantidade)
        {
            PedidoEstoque temp = new PedidoEstoque(prod[indice], quantidade);
            this.Listapedidos.Add(temp);
        }

        public void reporEstoque(int indice) // produto na posição do parametro vai ter seu estoque igual ao dobro do minimo
        {
            //quantidade a ser reposta (2x o estoque minimo)
            int quantidade_repor = prod[indice].getEstoqueMinimo() * 2;
            //quantidade pedida
            int quantidade_pedido = quantidade_repor - prod[indice].getEstoqueAtual();
            //gera o pedido de reposição
            this.GeraPedReposicaoEstoque(indice, quantidade_pedido);
            //repoe o estoque do produto
            prod[indice].setEstoqueAtual(quantidade_repor);           
            
        }

        public void precisaReporEstoque(int indice) // verifica se precisa repor o estoque
        {
            if (prod[indice].getEstoqueAtual() < prod[indice].getEstoqueMinimo())
            {
                //se precisar, gera o pedido de reposição
                this.reporEstoque(indice);                
            }
        }
        
        public string ListarPedidos()
        {
            string lista = "";
            for (int i = 0; i < Listapedidos.Count; i++)
            {
                lista += Listapedidos[i].ListarPedido();
            }
            return lista;
        }

        //set e get
        public void setProdutos(Produto[] prod)
        {
            this.prod = prod;
        }
        public Produto[] getProdutos()
        {
            return prod;
        }

        

    }
}
