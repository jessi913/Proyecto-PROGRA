using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_PROGRA.Models
{
    public class PedidoDetalle
    {
        public int Pedidodetalle { get; set; }
        [ForeignKey("PedidoId")]
        public int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
        public DateTime FechaCreacion { get; set; }
        [ForeignKey("ProductoId")]
        public int ProductoId { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
    }
}