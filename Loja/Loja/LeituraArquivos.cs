using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Loja
{
  class LeituraArquivos
  {
    private Estoque estoque;
    private String nomeArquivoVendas;
    private String nomeArquivoProdutos;
    private Arvore arvore_produtos;

    public LeituraArquivos(String nomeArquivoProdutos, String nomeArquivoVendas)
    {
      this.nomeArquivoProdutos = nomeArquivoProdutos;
      this.nomeArquivoVendas = nomeArquivoVendas;
      estoque = new Estoque();
    }

    //lê o arquivo e retorna o Estoque
    public Estoque LeituraArquivoProduto()
    {
      String s;
      String[] aux;
      int i;

      StreamReader arquivoLeituraProdutos;

      try
      {
        arquivoLeituraProdutos = new StreamReader(nomeArquivoProdutos);

        s = arquivoLeituraProdutos.ReadLine();
        i = 0;
        this.arvore_produtos = new Arvore(null);

        while (s != null)
        {
          aux = s.Split(';');

          //switch para descobrir qual classe filha de produto instanciar
          switch (int.Parse(aux[1]))
          {
            case 1:
              this.arvore_produtos.Inserir(new Bebida(aux[0], double.Parse(aux[2]), double.Parse(aux[3]), int.Parse(aux[4]), int.Parse(aux[5])));
              break;
            case 2:
              this.arvore_produtos.Inserir(new Comida(aux[0], double.Parse(aux[2]), double.Parse(aux[3]), int.Parse(aux[4]), int.Parse(aux[5])));
              break;
            case 3:
              this.arvore_produtos.Inserir(new MaterialEscritorio(aux[0], double.Parse(aux[2]), double.Parse(aux[3]), int.Parse(aux[4]), int.Parse(aux[5])));
              break;
            case 4:
              this.arvore_produtos.Inserir(new UtensilioDomestico(aux[0], double.Parse(aux[2]), double.Parse(aux[3]), int.Parse(aux[4]), int.Parse(aux[5])));
              break;
          }

          s = arquivoLeituraProdutos.ReadLine();
          i++;
        }

        arquivoLeituraProdutos.Close();

      }

      catch (FileNotFoundException ex)
      {
        throw ex;
      }

      catch (Exception ex)
      {
        throw ex;
      }

      return estoque;
    }

    //lê o arquivo e retorna uma lista de vendas
    public List<Vendas> LeituraArquivoVendas()
    {
      List<Vendas> Lista_vendas = new List<Vendas>();

      String s;
      String[] aux, produtos;
      int i;

      StreamReader arquivoLeituraVendas;

      try
      {
        arquivoLeituraVendas = new StreamReader(nomeArquivoVendas);

        s = arquivoLeituraVendas.ReadLine();
        i = 0;

        while (s != null)
        {
          aux = s.Split(';');

          //instancia um vetor de itens com a quantidade de produtos vendidos
          Itens[] itens = new Itens[int.Parse(aux[1])];

          //leitura dos produtos da venda, lê a quantidade de linhas conforme a quantidade de produtos
          for (int c = 0; c < itens.Length; c++)
          {
            s = arquivoLeituraVendas.ReadLine();
            produtos = s.Split(';');

            Produto produto_aux = arvore_produtos.Buscar(produtos[0]);

            //instancia um item passando o produto e a quantidade
            itens[c] = new Itens(produto_aux, int.Parse(produtos[1]));

            //chama o estoque passando o indice do produto e a quantidade vendida
            estoque.Ativar(produto_aux, int.Parse(produtos[1]));
          }

          Lista_vendas.Add(new Vendas(int.Parse(aux[0]), int.Parse(aux[1]), itens));

          s = arquivoLeituraVendas.ReadLine();
          i++;
        }
      }

      catch (FileNotFoundException ex)
      {
        throw ex;
      }

      catch (Exception ex)
      {
        throw ex;
      }

      arquivoLeituraVendas.Close();

      return Lista_vendas;
    }

  }
}
