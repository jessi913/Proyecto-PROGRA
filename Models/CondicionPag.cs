﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_PROGRA.Models
{
    public class CondicionPag
    {
        [Key]

        public int CondicionPago { get; set; }

        [Required]
        [StringLength(50)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [Required]
        public bool Estado { get; set; }

        [Required]
        public int Dias { get; set; }

        [Required]

        public DateTime FechaCreacion { get; set; }
    }
}