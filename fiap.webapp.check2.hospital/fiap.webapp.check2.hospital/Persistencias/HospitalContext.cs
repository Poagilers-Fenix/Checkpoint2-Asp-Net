using fiap.webapp.check2.hospital.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiap.webapp.check2.hospital.Persistencias
{
    public class HospitalContext: DbContext
    {
        public HospitalContext(DbContextOptions options) : base(options) { }
        public DbSet<Hospital> Hospitais { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Doenca> Doencas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<PacienteDoenca> PacienteDoencas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PacienteDoenca>().HasKey(p => new { p.PacienteId, p.DoencaId });

            modelBuilder.Entity<PacienteDoenca>()
                .HasOne(p => p.Paciente)
                .WithMany(m => m.PacientesDoencas)
                .HasForeignKey(m => m.PacienteId);

            modelBuilder.Entity<PacienteDoenca>()
                .HasOne(p => p.Doenca)
                .WithMany(m => m.PacientesDoencas)
                .HasForeignKey(m => m.DoencaId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
