using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PruebaApi.Models
{
    [Table("TablaPrueba")]
    public partial class TablaPrueba
    {
        [Key]
        [Column("idPrueba")]
        public int IdPrueba { get; set; }
        [Required]
        [Column("nombrePrueba")]
        [StringLength(30)]
        public string NombrePrueba { get; set; }
    }
}
