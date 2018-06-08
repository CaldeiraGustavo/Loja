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
        private Produto[] prod; // olhar depois
        private int quantidade_vendas = 380;
        private int quantidade_produtos = 40;
        private String nomeArquivoVendas = @"Vendas.txt";
        private String nomeArquivoProdutos = @"Produtos.txt";

        //lê o arquivo e retorna um vetor de produtos
        public Produto[] LeituraArquivoProduto()
        {
            Produto[] produtos = new Produto[quantidade_produtos];

            String s;
            String[] aux;
            int i;                      

            StreamReader arquivoLeituraProdutos;
            
            if (File.Exists(nomeArquivoProdutos))
            {
                arquivoLeituraProdutos = new StreamReader(nomeArquivoProdutos);
                
                s = arquivoLeituraProdutos.ReadLine();
                i = 0;
               
                while (s != null)
                {
                    aux = s.Split(';');

                    //switch para descobrir qual classe filha de produto instanciar
                    switch (int.Parse(aux[1]))
                    {
                        case 1:
                            produtos[i] = new Bebida(aux[0], double.Parse(aux[2]), double.Parse(aux[3]), int.Parse(aux[4]), int.Parse(aux[5]));
                            break;
                        case 2:
                            produtos[i] = new Comida(aux[0], double.Parse(aux[2]), double.Parse(aux[3]), int.Parse(aux[4]), int.Parse(aux[5]));
                            break;
                        case 3:
                            produtos[i] = new MaterialEscritorio(aux[0], double.Parse(aux[2]), double.Parse(aux[3]), int.Parse(aux[4]), int.Parse(aux[5]));
                            break;
                        case 4:
                            produtos[i] = new UtensilioDomestico(aux[0], double.Parse(aux[2]), double.Parse(aux[3]), int.Parse(aux[4]), int.Parse(aux[5]));
                            break;
                    }              
                                      
                    s = arquivoLeituraProdutos.ReadLine();
                    i++;
                }
               
                arquivoLeituraProdutos.Close();

            }
            this.prod = produtos;
            return produtos;
        }

        //lê o arquivo e retorna um vetor de vendas
        public Vendas[] LeituraArquivoVendas()
        {
            Vendas[] vendas = new Vendas[quantidade_vendas];

            String s;
            String[] aux, produtos;
            int i;          
            
            StreamReader arquivoLeituraVendas;

            if (File.Exists(nomeArquivoVendas))
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
                    for (int c = 0; c < int.Parse(aux[1]); c++)
                    {
                        s = arquivoLeituraVendas.ReadLine();
                        produtos = s.Split(';');

                        //instancia um item passando o produto e a quantidade
                        itens[c] = new Itens(this.Produto(produtos[0]), int.Parse(produtos[1]));
                    }                    

                    vendas[i] = new Vendas(int.Parse(aux[0]), int.Parse(aux[1]), itens);

                    s = arquivoLeituraVendas.ReadLine();
                    i++;
                }

                arquivoLeituraVendas.Close();

            }

            return vendas;

        }
        
        //metodo que recebe como parametro o nome e retorna o produto
        private Produto Produto(string nome)
        {          
            //percore o vetor de produtos procurando pelo nome correspondente
            for (int i = 0; i < prod.Length; i++)
            {
                if (nome == prod[i].getNome())
                {
                    return prod[i];
                }
            }

            return prod[100];
        }

    }
}
