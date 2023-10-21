using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminTourismo.Models
{
    public class Tours
    {
        [Key]
        public int tourID { get; set; }

        [Required]
        [MaxLength(255)]
        public required string nombreTour { get; set; }

        [Required]
        public required DateTime fecha { get; set; }

        [Required]
        public required decimal costo { get; set; }

        [Required]
        public required int capacidadMaxima { get; set; }

        [Required]
        public required TimeSpan horario { get; set; }

        [ForeignKey("guiaID")]
        public virtual required Guias guiaID { get; set; }

        [ForeignKey("capacidadID")]
        public virtual required Capacidad capacidadID { get; set; }
    }
}