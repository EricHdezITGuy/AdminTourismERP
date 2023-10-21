using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AdminTourismo.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminTourismo.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Se puede comentar o eliminar estas entidades en caso de que no se necesiten
        // public DbSet<RolesUsuarios> rolesUsuarios { get; set; }
        // public DbSet<Usuarios> usuarios { get; set; }

        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Guias> guias { get; set; }
        public DbSet<Capacidad> capacidad { get; set; }
        public DbSet<Tours> tours { get; set; }
        public DbSet<Descuentos> descuentos { get; set; }
        public DbSet<EstadosReserva> estadosReservas { get; set; }
        public DbSet<Reservas> reservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.SetTableName(entityType.ClrType.Name);
            }

            base.OnModelCreating(modelBuilder); // Asegúrate de llamar a la base después de tus personalizaciones
        }
    }
}
