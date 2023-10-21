using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminTourismo.Models
{
    public class Guias
    {
        [Key]
        public int guiaID { get; set; }

        [Required]
        [MaxLength(255)]
        public required string nombre { get; set; }

    }
}