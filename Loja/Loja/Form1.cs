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
        static LeituraArquivos leitura;
        //instancia a classe gestão passando o vetor de vendas e o estoque         

        Gestao gestao; 

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Selecione o arquivo de produtos");
            DialogResult produtos = openFileDialog1.ShowDialog();
            MessageBox.Show("Selecione o arquivo de vendas");
            DialogResult vendas = openFileDialog2.ShowDialog();

            leitura = new LeituraArquivos(openFileDialog1.FileName, openFileDialog2.FileName);
            gestao = new Gestao(leitura.LeituraArquivoProduto(), leitura.LeituraArquivoVendas());
        }    
      
        private void button1_Click(object sender, EventArgs e)
        {
            ProductList.Visible = true;
            txtrep.Visible = false;
            ProductList.Text = gestao.getEstoque().ListarPedidos();
            ProductList.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductList.Visible = false;
            txtrep.Visible = true;
            txtrep.Text = gestao.ProdutoMaisVendUnid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductList.Visible = false;
            txtrep.Visible = true;
            txtrep.Text = gestao.ProdutoMaiorFaturamento();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductList.Visible = false;
            txtrep.Visible = true;
            txtrep.Text = gestao.ProdutoMaiorLucro();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductList.Visible = false;
            txtrep.Visible = true;
            txtrep.Text = gestao.ValorLiquidoFaturado().ToString("c");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductList.Visible = false;
            txtrep.Visible = true;
            txtrep.Text = gestao.ValorBrutoFaturado().ToString("c");
        }
    }
}
