using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque_modelo_MPM.Models
{
    public class Pedidos
    {
        public int idpedido { get; set;  }
        
        public string nomeCliente { get; set; }

        
    }

    public class PedidosCollection : List<Pedidos> { }
}
