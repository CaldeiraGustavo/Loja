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

        public Produto [] LeituraArquivoProduto()
        {
            Produto[] produtos = new Produto[40];

            String s;
            String[] aux;
            int i;

            String nomeArquivoProdutos = @"Produtos.txt";            

            StreamReader arquivoLeituraProdutos;
            
            if (File.Exists(nomeArquivoProdutos))
            {
                arquivoLeituraProdutos = new StreamReader(nomeArquivoProdutos);
                
                s = arquivoLeituraProdutos.ReadLine();
                i = 0;
               
                while (s != null)
                {
                    aux = s.Split(';');
                   
                    produtos[i] = new Comida(aux[0], int.Parse(aux[1]), double.Parse(aux[2]), double.Parse(aux[3]), int.Parse(aux[4]), int.Parse(aux[5]));
                  
                    s = arquivoLeituraProdutos.ReadLine();
                    i++;
                }
               
                arquivoLeituraProdutos.Close();

            }

            return produtos;

        }

        public Vendas[] LeituraArquivoVendas()
        {
            Vendas[] vendas = new Vendas[380];

            String s;
            String[] aux;
            int i;
            
            String nomeArquivoVendas = @"Vendas.txt";

            StreamReader arquivoLeituraVendas;

            if (File.Exists(nomeArquivoVendas))
            {
                arquivoLeituraVendas = new StreamReader(nomeArquivoVendas);

                s = arquivoLeituraVendas.ReadLine();
                i = 0;

                while (s != null)
                {
                    aux = s.Split(';');

                    Itens item = new Itens(aux[2], int.Parse(aux[3]));

                    vendas[i] = new Vendas(int.Parse(aux[0]), int.Parse(aux[1]), item);

                    s = arquivoLeituraVendas.ReadLine();
                    i++;
                }

                arquivoLeituraVendas.Close();

            }

            return vendas;

        }
        
    }
}
