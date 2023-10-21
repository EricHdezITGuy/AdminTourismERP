using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminTourismo.Models
{
    public class Capacidad
    {
        [Key] // Atributo que indica que esta propiedad es la clave principal
        public int capacidadID { get; set; }

        [Required]
        public required int capacidadTour { get; set; }

    }
}