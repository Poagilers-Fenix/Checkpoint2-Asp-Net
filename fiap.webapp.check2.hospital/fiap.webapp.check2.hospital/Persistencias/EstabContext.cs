using fiap.webapp.check2.hospital.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiap.webapp.check2.hospital.Persistencias
{
    public class EstabContext: DbContext
    {
        public EstabContext(DbContextOptions options) : base(options) { }
        public DbSet<Hospital> Hospital { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Doenca> Doenca { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
    }
}
