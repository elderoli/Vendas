using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Vendas.Models
{
    public class Pedidos
    {
        public int Mesa { get; set; }
        public string Cliente { get; set; }
        public int telefone { get; set; }
        public string DescricaoPedido { get; set; }
        public int PedidosId { get; set; }
    }
}
