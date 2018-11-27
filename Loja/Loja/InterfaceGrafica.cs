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
  public partial class InterfaceGrafica : Form
  {
    static LeituraArquivos leitura;

    //instancia a classe gestão passando o vetor de vendas e o estoque      
    Gestao gestao;

    int pagina = 1;

    public InterfaceGrafica()
    {
      InitializeComponent();
      //MessageBox.Show("Selecione o arquivo de produtos");
      //DialogResult produtos = openFileDialog1.ShowDialog();
      //MessageBox.Show("Selecione o arquivo de vendas");
      //DialogResult vendas = openFileDialog2.ShowDialog();

      leitura = new LeituraArquivos("AEDprodutos.txt", "AEDvendas.txt");
      gestao = new Gestao(leitura.LeituraArquivoProduto(), leitura.LeituraArquivoVendas());
    }

    //Botão Listar Pedidos de Estoque
    private void button1_Click(object sender, EventArgs e)
    {
      button10.Visible = true;
      button9.Visible = false;
      
      txtrep.Visible = false;
      List<PedidoEstoque> listaPedidos = gestao.getEstoque().ListarPedidos(pagina);
      dtvReposicao.Visible = true;
      dtvListarProdutos.Visible = false;
      listarPedidosGrid(listaPedidos);

    }

    private void button4_Click(object sender, EventArgs e)
    {
      dtvListarProdutos.Visible = false;
      dtvReposicao.Visible = false;
      button10.Visible = false;
      button9.Visible = false;

      txtrep.Visible = true;
      txtrep.Text = gestao.ProdutoMaisVendUnid();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      dtvListarProdutos.Visible = false;
      dtvReposicao.Visible = false;
      button10.Visible = false;
      button9.Visible = false;

      txtrep.Visible = true;
      txtrep.Text = gestao.ProdutoMaiorFaturamento();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      dtvListarProdutos.Visible = false;
      dtvReposicao.Visible = false;
      button10.Visible = false;
      button9.Visible = false;

      txtrep.Visible = true;
      txtrep.Text = gestao.ProdutoMaiorLucro();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      dtvListarProdutos.Visible = false;
      dtvReposicao.Visible = false;
      button10.Visible = false;
      button9.Visible = false;

      txtrep.Visible = true;
      txtrep.Text = gestao.ValorLiquidoFaturado().ToString("c");
    }

    //Botão Valor Bruto Faturado
    private void button6_Click(object sender, EventArgs e)
    {
      dtvListarProdutos.Visible = false;
      dtvReposicao.Visible = false;
      button10.Visible = false;
      button9.Visible = false;

      txtrep.Visible = true;
      txtrep.Text = gestao.ValorBrutoFaturado().ToString("c");
    }

    //Botão Listar Produtos
    private void button7_Click(object sender, EventArgs e)
    {
      button10.Visible = false;
      button9.Visible = false;      
      txtrep.Visible = false;

      List<Elemento_QuickSort> lista = gestao.Listar_Produtos();
      dtvListarProdutos.Visible = true;
      dtvReposicao.Visible = false;
      listarProdutosGrid(lista);
    }

    //Botão Ordenar
    private void button8_Click(object sender, EventArgs e)
    {
      button10.Visible = false;
      button9.Visible = false;
      txtrep.Visible = false;

      gestao.Ordenar_Produtos();
      List<Elemento_QuickSort> lista = gestao.Listar_Produtos();
      dtvListarProdutos.Visible = true;
      dtvReposicao.Visible = false;
      listarProdutosGrid(lista);
    }
    private void listarPedidosGrid(List<PedidoEstoque> pedido)
    {
      dtvReposicao.Rows.Clear();
      for (int i = 0; i < pedido.Count; i++)
      {
        string linha = pedido[i].ToString();
        string[] dados = linha.Split(':');
        dtvReposicao.Rows.Add(dados[0], dados[1], dados[2], dados[3]);
      }

    }
    private void listarProdutosGrid(List<Elemento_QuickSort> lista)
    {
      dtvListarProdutos.Rows.Clear();
      for (int i = 0; i < lista.Count; i++)
      {
        string linha = lista[i].ToString();
        string[] dados = linha.Split(':');
        dtvListarProdutos.Rows.Add(dados[0], dados[1]);
      }

    }

    //Botão Proximo
    private void button10_Click(object sender, EventArgs e)
    {
      button10.Visible = true;
      button9.Visible = true;
      txtrep.Visible = false;

      pagina ++;

      List<PedidoEstoque> listaPedidos = gestao.getEstoque().ListarPedidos(pagina);
      dtvReposicao.Visible = true;
      dtvListarProdutos.Visible = false;
      listarPedidosGrid(listaPedidos);
    }

    //Botão anterior
    private void button9_Click(object sender, EventArgs e)
    {
      pagina--;

      if (pagina <= 1)
      {
        button9.Visible = false;
      }
      else { button9.Visible = true; }

      button10.Visible = true;      
      txtrep.Visible = false;      

      List<PedidoEstoque> listaPedidos = gestao.getEstoque().ListarPedidos(pagina);
      dtvReposicao.Visible = true;
      dtvListarProdutos.Visible = false;
      listarPedidosGrid(listaPedidos);
    }
  }
}
