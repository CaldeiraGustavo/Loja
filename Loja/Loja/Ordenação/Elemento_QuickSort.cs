using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Elemento_QuickSort
    {
        public Produto produto { get; private set; }
        public double Faturamento_Bruto { get; private set; }

        public Elemento_QuickSort(Produto prod, double valor)
        {
            this.produto = prod;
            this.Faturamento_Bruto = valor;
        }

        /// <summary>
        /// Método para Imprimir um Produto e seu faturamento Bruto
        /// </summary>
        public string Imprimir()
        {
            return this.produto.getNome() + ":" + this.Faturamento_Bruto.ToString("c") ;
        }        

    }
}
