using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class PedidoEstoque
    {
        private Produto prod;
        private double ValorPedido;
        private int Quantidade;
        private bool concluido;   
        

        public PedidoEstoque(Produto prod, int quantidade)
        {
            this.Prod = prod;
            this.Quantidade1 = quantidade;
            this.concluido = true;
            this.ValorPedido1 = prod.PrecoCusto * quantidade;
        }

        public void ListarPedido()
        {
            Console.WriteLine("Produto: "+this.prod.getNome()+ "Quantidade: "+this.Quantidade+"Valor do Pedido: "+this.ValorPedido);
        }

        public double ValorPedido1 { get => ValorPedido; set => ValorPedido = value; }
        public int Quantidade1 { get => Quantidade; set => Quantidade = value; }
        internal Produto Prod { get => prod; set => prod = value; }
    }
}
