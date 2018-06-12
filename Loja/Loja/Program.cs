using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Loja
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new Form1());
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Arquivo não encontrado!");

            }
            catch (Exception)
            {
                MessageBox.Show("Algo de errado ocorreu com a leitura dos arquivos!");
            }


      //LeituraArquivos leitura = new LeituraArquivos(@"C:\Users\sarah.campos\Downloads\POO_vendas\POOprodutos.txt", @"C:\Users\sarah.campos\Downloads\POO_vendas\POOvendas.txt");

      //instancia a classe gestão passando o vetor de vendas e o estoque
      //Gestao gestao = new Gestao(leitura.LeituraArquivoProduto(), leitura.LeituraArquivoVendas());



    }
    }
}
