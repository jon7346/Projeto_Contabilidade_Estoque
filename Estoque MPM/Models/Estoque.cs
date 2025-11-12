using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque_modelo_MPM.Models
{
    public class Estoque
    {
        public int idproduto { get; set; }

        public string operacao { get; set; }

        public int quantidade { get; set; }
        

    }
    public class EstoqueCollection : List<Estoque> { }
}
