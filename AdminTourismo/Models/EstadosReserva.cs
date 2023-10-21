using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminTourismo.Models
{
    public class EstadosReserva
    {
        [Key]
        public int estadoID { get; set; }

        [Required]
        [MaxLength(255)]
        public required string nombreEstado { get; set; }
    }
}