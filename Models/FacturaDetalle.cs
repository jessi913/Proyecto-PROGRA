using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_PROGRA.Models
{
    [Table("FacturaDetalle")]
    public class FacturaDetalle
    {
        public int FacturaDetalleId { get; set; }

        [ForeignKey("FacturaId")]
        public int FacturaId { get; set; }
        public virtual Factura Factura { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int ProductoId { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
    }
}