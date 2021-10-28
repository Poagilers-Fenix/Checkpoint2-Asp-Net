﻿using fiap.webapp.check2.hospital.Models;
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
    }
}