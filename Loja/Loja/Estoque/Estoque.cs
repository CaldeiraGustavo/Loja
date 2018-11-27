using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Estoque
    {
        private List<PedidoEstoque> Listapedidos = new List<PedidoEstoque>(); // a cada vez que é feito um pedido de reposição 
        
        /// <summary>
        /// Método inicial que recebe um produto e a quantidade vendida para prosseguir
        /// com as validações necessárias
        /// </summary>
        public void Ativar(Produto prod, int quantidade_vendida)
        {
            //faz o estoque do produto atual ser igual ao estoque antigo - a quantidade vendida
            prod.setEstoqueAtual(prod.getEstoqueAtual() - quantidade_vendida);

            //chama o metodo para verificar se é necessário repor o estoque
            this.precisaReporEstoque(prod);
        }

        /// <summary>
        /// Verifica se é necessário repor o estoque
        /// Se for, o método para repor o estoque é chamado
        /// </summary>
        public void precisaReporEstoque(Produto prod)
        {
            if (prod.getEstoqueAtual() < prod.getEstoqueMinimo())
            {
                this.reporEstoque(prod);
            }
        }

        /// <summary>
        /// O estoque do produto passado como parâmetro é reposto de acordo com a regra de negócio
        /// </summary>
        public void reporEstoque(Produto prod)
        {
            //quantidade a ser reposta (2x o estoque minimo)
            int quantidade_repor = prod.getEstoqueMinimo() * 2;
            //quantidade pedida
            int quantidade_pedido = quantidade_repor - prod.getEstoqueAtual();
            //gera o pedido de reposição
            this.GeraPedReposicaoEstoque(prod, quantidade_pedido);
            //repoe o estoque do produto
            prod.setEstoqueAtual(quantidade_repor);
        }

        /// <summary>
        /// É gerado um pedido de reposição de estoque e adicionado na lista de pedidos
        /// </summary>
        public void GeraPedReposicaoEstoque(Produto prod, int quantidade)
        {
            PedidoEstoque temp = new PedidoEstoque(prod, quantidade);
            this.Listapedidos.Add(temp);
        }

        public List<string> ListarPedidos()
        {

            List<string> lista = new List<string>();
            for (int i = 0; i < Listapedidos.Count; i++)
            {
                
                lista.Add(Listapedidos[i].ListarPedido());
                
              
            }
            return lista;
        }


    }
}
