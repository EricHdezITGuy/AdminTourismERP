using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminTourismo.Models
{
    public class Usuarios
    {
        [Key]
        public int usuarioID { get; set; }

        [Required]
        [MaxLength(100)]
        public required string nombreUsuario { get; set; }

        [Required]
        [MaxLength(64)]
        public required string contrasena { get; set; }

        [Required]
        [MaxLength(255)]
        [EmailAddress]
        public required string email { get; set; }

        [Required]
        [MaxLength(64)]
        public required string token { get; set; }

        [Required]
        public required DateTime expiracion { get; set; }

        // Relaciones con otras tablas
        [ForeignKey("rolID")]
        public virtual required RolesUsuarios rolID { get; set; }
    }
}