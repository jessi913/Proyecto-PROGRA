using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_PROGRA.Models
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }
        [ForeignKey("CategoriaId")]
        public int CategoriaId { get; set; }
        public virtual Categoría Categoria { get; set; }

        [ForeignKey("UnidadMedidaId")]
        public int UnidadMedidaId { get; set; }
        public virtual UnidadMedida UnidadMedida { get; set; }

        public DateTime FechaCreacion { get; set; }
        [Required]
        public bool Estado { get; set; }

        [Required]
        public decimal PrecioCompra { get; set; }

    }
}