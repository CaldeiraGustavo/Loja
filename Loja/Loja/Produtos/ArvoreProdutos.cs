using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Arvore
    {
        public Elemento Dado { get; private set; }
        public Arvore FilhoE { get; private set; }
        public Arvore FilhoD { get; private set; }

        public Arvore(Produto prod)
        {
            this.Dado = new Elemento(prod);
            this.FilhoE = null;
            this.FilhoD = null;
        }

        public void Inserir(Produto produto)
        {
            if (this.Dado.produto == null)
            {
                this.Dado = new Elemento(produto);
            }
            else
            {

                if (produto.getNome().CompareTo(this.Dado.produto.getNome()) < 0)
                {
                    if (this.FilhoE != null)
                    {
                        this.FilhoE.Inserir(produto);
                    }
                    else
                    {
                        this.FilhoE = new Arvore(produto);
                    }
                }

                else
                {
                    if (this.FilhoD != null)
                    {
                        this.FilhoD.Inserir(produto);
                    }
                    else
                    {
                        this.FilhoD = new Arvore(produto);
                    }
                }
            }
        }

        public Produto Buscar(string nome)
        {
            if (this.Dado.produto.getNome() == nome)
            {
                return this.Dado.produto;
            }

            if (nome.CompareTo(this.Dado.produto.getNome()) < 0)
            {
                return this.FilhoE.Buscar(nome);
            }

            else { return this.FilhoD.Buscar(nome); }

        }










    }
}
