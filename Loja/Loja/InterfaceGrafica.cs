﻿using System;
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

        public InterfaceGrafica()
        {
            InitializeComponent();
            //MessageBox.Show("Selecione o arquivo de produtos");
            //DialogResult produtos = openFileDialog1.ShowDialog();
            //MessageBox.Show("Selecione o arquivo de vendas");
            //DialogResult vendas = openFileDialog2.ShowDialog();

            leitura = new LeituraArquivos("POOprodutos.txt", "POOvendas.txt");
            gestao = new Gestao(leitura.LeituraArquivoProduto(), leitura.LeituraArquivoVendas());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ProductList.Visible = true;
            txtrep.Visible = false;
            List<string> listaPedidos = gestao.getEstoque().ListarPedidos();
            dtvReposicao.Visible = true;
            dtvListarProdutos.Visible = false;
            listarPedidosGrid(listaPedidos);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dtvListarProdutos.Visible = false;
            dtvReposicao.Visible = false;
           
            txtrep.Visible = true;
            txtrep.Text = gestao.ProdutoMaisVendUnid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtvListarProdutos.Visible = false;
            dtvReposicao.Visible = false;
            
            txtrep.Visible = true;
            txtrep.Text = gestao.ProdutoMaiorFaturamento();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtvListarProdutos.Visible = false;
            dtvReposicao.Visible = false;
            
            txtrep.Visible = true;
            txtrep.Text = gestao.ProdutoMaiorLucro();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dtvListarProdutos.Visible = false;
            dtvReposicao.Visible = false;
       
            txtrep.Visible = true;
            txtrep.Text = gestao.ValorLiquidoFaturado().ToString("c");
        }

        //Botão Valor Bruto Faturado
        private void button6_Click(object sender, EventArgs e)
        {
            dtvListarProdutos.Visible = false;
            dtvReposicao.Visible = false;
            
            txtrep.Visible = true;
            txtrep.Text = gestao.ValorBrutoFaturado().ToString("c");
        }

        //Botão Listar Produtos
        private void button7_Click(object sender, EventArgs e)
        {
            //ProductList.Visible = true;
            txtrep.Visible = false;            
            List<string> lista = gestao.Listar_Produtos();
            dtvListarProdutos.Visible = true;
            dtvReposicao.Visible = false;
            listarProdutosGrid(lista);
        }

        //Botão Ordenar
        private void button8_Click(object sender, EventArgs e)
        {
           // ProductList.Visible = true;
            txtrep.Visible = false;
            gestao.Ordenar_Produtos();
            List<string> lista = gestao.Listar_Produtos();
            dtvListarProdutos.Visible = true;
            dtvReposicao.Visible = false;
            listarProdutosGrid(lista);
        }
        private  void listarPedidosGrid(List<string> pedido)
        {
            
            for(int i = 0; i < pedido.Count; i++)
            {
                string linha = pedido[i];
                string[] dados = linha.Split(':');
                dtvReposicao.Rows.Add(dados[0], dados[1], dados[2], dados[3]);
            }
            
        }
        private void listarProdutosGrid(List<string> lista)
        {
            dtvListarProdutos.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                string linha = lista[i];
                string[] dados = linha.Split(':');
                dtvListarProdutos.Rows.Add(dados[0], dados[1]);
            }

        }
    }
}
