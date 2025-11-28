using LogicaNegocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDatos.EF
{
    public class LibreriaContext : DbContext
    {
        private IConfiguration _config;

   
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<TipoServicio> TipoServicios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Negocio> Negocios { get; set; } 
        public DbSet<Admin> Administradores { get; set; }

        public DbSet<EmpleadoTurnoServicio> EmpleadoTurnoServicios { get; set; }
        

        public LibreriaContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sucursal>()
    .OwnsMany(s => s.HorariosAtencion);



            modelBuilder.Entity<Empleado>()
                .OwnsMany(e => e.HorariosJornada);

            modelBuilder.Entity<EmpleadoTurnoServicio>()
      .HasOne(ets => ets.Reserva)
      .WithMany(r => r.EmpleadosTurnos)
      .HasForeignKey(ets => ets.ReservaId)
      .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Reserva>()
    .HasOne(r => r.Cliente)
    .WithMany()
    .HasForeignKey(r => r.ClienteId)
    .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.Negocio)
                .WithMany()
                .HasForeignKey(r => r.NegocioId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<EmpleadoTurnoServicio>()
       .HasOne(e => e.Empleado)
       .WithMany()
       .HasForeignKey(e => e.EmpleadoId)
       .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EmpleadoTurnoServicio>()
    .HasOne(e => e.Servicio)
    .WithMany()
    .HasForeignKey(e => e.ServicioId)
    .OnDelete(DeleteBehavior.NoAction);

          

            modelBuilder.Entity<Servicio>()
       .HasOne(s => s.Negocio)
       .WithMany(n => n.Servicios)
       .HasForeignKey(s => s.NegocioId)
       .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Servicio>()
                .HasOne(s => s.Tipo)
                .WithMany()
                .HasForeignKey(s => s.TipoId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Empleado>()
                .HasOne(e => e.Negocio)
                .WithMany(n => n.Empleados)
                .HasForeignKey(e => e.NegocioId)
                .OnDelete(DeleteBehavior.Restrict);
        

    }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
            _config["ConnectionStrings:LocalBD"]
            );
        }

    }
}
