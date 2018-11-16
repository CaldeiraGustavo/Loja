using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
  class Elemento
  {
    public Produto produto { get; set; }

    public Elemento(Produto produto)
    {
      this.produto = produto;
    }

  }
}
