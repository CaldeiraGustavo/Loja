using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Loja
{
    static class Program
    { 
        static void Main()
        {
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());

            Gestao gestao = new Gestao();
            LeituraArquivos leitura = new LeituraArquivos();

            gestao.setEstoque(leitura.LeituraArquivoProduto());
            gestao.Vendas = leitura.LeituraArquivoVendas();

            //apenas pra mostrar o que tem que ser exibido, nao precisa ser necessariamente com console
            Console.WriteLine(gestao.ProdutoMaisVendUnid());
            Console.WriteLine(gestao.ProdutoMaiorFaturamento());
            Console.WriteLine(gestao.ProdutoMaiorLucro());
            Console.WriteLine(gestao.ValorBrutoFaturado());
            Console.WriteLine(gestao.ValorLiquidoFaturado());
            
        }
    }
}
