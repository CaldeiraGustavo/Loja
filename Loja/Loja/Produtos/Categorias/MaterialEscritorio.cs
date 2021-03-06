﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
  class MaterialEscritorio : Produto
  {
    private int porcentImposto = 16;

    public MaterialEscritorio(string nome, double margemLucro, double precoCusto, int estoqueAtual, int estoqueMinimo) : base(nome, margemLucro, precoCusto, estoqueAtual, estoqueMinimo)
    {
      if (margemLucro <= 0.05)
      {
        this.margemLucro = 0.05;
      }
      else if (margemLucro >= 0.5)
      {
        this.margemLucro = 0.5;
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
