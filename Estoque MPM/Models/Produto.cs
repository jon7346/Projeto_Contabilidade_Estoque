using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Estoque_modelo_MPM.Models
{
    public class Produto
    {
        public int id { get; set; }

        public string nome { get; set; }

        public string detalhes { get; set; }

        public string fornecedor { get; set;  }

        public float custo { get; set; }

    }

    public class ProdutoCollection : List<Produto> { }
}
