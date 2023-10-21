using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminTourismo.Models
{
    public class Clientes
    {
        [Key]
        public int clienteID { get; set; }

        [Required]
        [MaxLength(255)]
        public required string nombre { get; set; }

        [Required]
        [MaxLength(255)]
        [EmailAddress]
        public required string correoElectronico { get; set; }

        public required long telefono { get; set; }

        public required string comentarios { get; set; }
    }
}