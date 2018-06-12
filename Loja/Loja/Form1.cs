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
        static LeituraArquivos leitura = new LeituraArquivos(@"C:\Users\sarah.campos\Downloads\POO_vendas\POOprod8utos.txt", @"C:\Users\sarah.campos\Downloads\POO_vendas\POOvendas.txt");
        //instancia a classe gestão passando o vetor de vendas e o estoque         
    
        Gestao gestao = new Gestao(leitura.LeituraArquivoProduto(), leitura.LeituraArquivoVendas());

        public Form1()
        {
            InitializeComponent();           

        }    
      
        private void button1_Click(object sender, EventArgs e)
        {            
            ProductList.Text = gestao.getEstoque().ListarPedidos();
            ProductList.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductList.Text = gestao.ProdutoMaisVendUnid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductList.Text = gestao.ProdutoMaiorFaturamento();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductList.Text = gestao.ProdutoMaiorLucro();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductList.Text = gestao.ValorLiquidoFaturado().ToString("c");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductList.Text = gestao.ValorBrutoFaturado().ToString("c");
        }
    }
}
