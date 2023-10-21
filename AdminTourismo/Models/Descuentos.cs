using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminTourismo.Models
{
    public class Descuentos
    {
        [Key]
        public int descuentoID { get; set; }

        [Required]
        [MaxLength(255)]
        public required string nombreDescuento { get; set; }

        [Required]
        [Column(TypeName ="decimal 10, 2")]
        public required decimal cantidadDescuento { get; set; }

        [Required]
        [MaxLength(255)]
        public required string codigo { get; set; }
    }
}