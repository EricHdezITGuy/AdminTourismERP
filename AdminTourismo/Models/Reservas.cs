using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminTourismo.Models
{
    public class Reservas
    {
        [Key] // Atributo que indica que esta propiedad es la clave principal
        public int reservaID { get; set; }

        [Required] // Atributo que indica que esta propiedad es obligatoria
        public required int clienteID { get; set; }

        [Required] 
        public required int tourID { get; set; }

        [Required] 
        public required int numeroPersonas { get; set; }

        [Required]
        public required Boolean pagado { get; set; }

        // Relaciones con otras tablas
        [ForeignKey("clienteID")]
        public virtual required Clientes clientes { get; set; }

        [ForeignKey("tourID")]
        public virtual required Tours tours { get; set; }

        [ForeignKey("descuentoID")]
        public virtual required Descuentos descuentoID { get; set; }

        [ForeignKey("estadoID")]
        public virtual required EstadosReserva estadoID { get; set; }
    }
}