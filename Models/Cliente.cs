using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_PROGRA.Models
{
    
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [StringLength(15)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [ForeignKey("GrupoDescuento")]
        public int GrupoDescuentoId { get; set; }
        public virtual GrupoDescuento GrupoDescuento { get; set; }

        [ForeignKey("CondicionPago")]
        public int CondicionPagoId { get; set; } // Corregido el nombre de la propiedad

        public virtual CondicionPag CondicionPago { get; set; }

        public bool Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
     