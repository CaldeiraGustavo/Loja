using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
  class QuickSort
  {
    public Elemento_QuickSort[] elementos { get; private set; }

    public QuickSort(Elemento_QuickSort[] elementos)
    {
      this.elementos = elementos;
      this.Quicksort(0, elementos.Length - 1);
    }

    /// <summary>
    /// Método que implementa o Quicksort recursivamente
    /// </summary>
    private void Quicksort(int inicio, int final)
    {
      if (inicio >= final) return;

      int pivo = Particao(inicio, final);

      Quicksort(inicio, pivo - 1);
      Quicksort(pivo + 1, final);
    }

    /// <summary>
    /// Método que implementa o Quicksort recursivamente
    /// </summary>
    private int Particao(int inicio, int final)
    {
      int i = inicio;

      for (int j = inicio; j < final; j++)
      {
        /* Elemento atual menor ou igual ao pivô? */
        if (elementos[j].Faturamento_Bruto <= elementos[final].Faturamento_Bruto)
        {
          Trocar(i++, j);
        }
      }
      Trocar(i, final);

      return i;
    }

    /// <summary>
    /// Método para fazer a troca de dados entre duas posições no vetor
    /// </summary>
    private void Trocar(int i, int j)
    {
      Elemento_QuickSort k = elementos[i];
      elementos[i] = elementos[j];
      elementos[j] = k;
    }




  }



}
