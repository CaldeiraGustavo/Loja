using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
  class UtensilioDomestico : Produto
  {
    private int porcentImposto = 25;

    public UtensilioDomestico(string nome, double margemLucro, double precoCusto, int estoqueAtual, int estoqueMinimo) : base(nome, margemLucro, precoCusto, estoqueAtual, estoqueMinimo)
    {
      if (margemLucro <= 0.1)
      {
        this.margemLucro = 0.1;
      }
      else if (margemLucro >= 0.2)
      {
        this.margemLucro = 0.2;
      }
      else
      {
        this.margemLucro = margemLucro;
      }
    }
    protected override int getPorcentagemImposto()
    {
      return porcentImposto;
    }
  }
}
