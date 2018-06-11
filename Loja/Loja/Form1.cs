using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class Form1 : Form
    {
          public Form1()
          {
          InitializeComponent();
          }    
      
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
      
        }

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LeituraArquivos leitura = new LeituraArquivos(@"C:\Users\1094820\Downloads\Produtos.txt", @"C:\Users\1094820\Downloads\Vendas.txt");
            //instancia a classe gestão passando o vetor de vendas e o estoque
            Gestao gestao = new Gestao(leitura.LeituraArquivoProduto(), leitura.LeituraArquivoVendas());
            
            ProductList.Text = gestao.getEstoque().ListarPedidos();
            ProductList.Refresh();
        }
    }
}
