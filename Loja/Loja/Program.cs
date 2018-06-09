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



        }
    }
}
