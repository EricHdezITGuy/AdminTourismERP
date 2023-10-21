using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminTourismo.Models
{
    public class RolesUsuarios
    {
        [Key]
        public int rolID { get; set; }

        [Required]
        [MaxLength(25)] // Por "Administrador" y "Empleado"
        public required string nombreRol { get; set; }

    }
}