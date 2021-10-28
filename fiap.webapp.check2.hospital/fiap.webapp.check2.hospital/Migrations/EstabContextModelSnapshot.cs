﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fiap.webapp.check2.hospital.Persistencias;

namespace fiap.webapp.check2.hospital.Migrations
{
    [DbContext(typeof(HospitalContext))]
    partial class EstabContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DoencaPaciente", b =>
                {
                    b.Property<int>("DoencaId")
                        .HasColumnType("int");

                    b.Property<int>("PacientesPacienteId")
                        .HasColumnType("int");

                    b.HasKey("DoencaId", "PacientesPacienteId");

                    b.HasIndex("PacientesPacienteId");

                    b.ToTable("DoencaPaciente");
                });

            modelBuilder.Entity("fiap.webapp.check2.hospital.Models.Doenca", b =>
                {
                    b.Property<int>("DoencaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sintomas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoencaId");

                    b.ToTable("Doenca");
                });

            modelBuilder.Entity("fiap.webapp.check2.hospital.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnderecoId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("fiap.webapp.check2.hospital.Models.Hospital", b =>
                {
                    b.Property<int>("HospitalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacidade")
                        .HasColumnType("int");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HospitalId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Hospital");
                });

            modelBuilder.Entity("fiap.webapp.check2.hospital.Models.Paciente", b =>
                {
                    b.Property<int>("PacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<int?>("HospitalId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PacienteId");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("HospitalId");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("DoencaPaciente", b =>
                {
                    b.HasOne("fiap.webapp.check2.hospital.Models.Doenca", null)
                        .WithMany()
                        .HasForeignKey("DoencaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fiap.webapp.check2.hospital.Models.Paciente", null)
                        .WithMany()
                        .HasForeignKey("PacientesPacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fiap.webapp.check2.hospital.Models.Hospital", b =>
                {
                    b.HasOne("fiap.webapp.check2.hospital.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("fiap.webapp.check2.hospital.Models.Paciente", b =>
                {
                    b.HasOne("fiap.webapp.check2.hospital.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.HasOne("fiap.webapp.check2.hospital.Models.Hospital", "Hospital")
                        .WithMany("Pacientes")
                        .HasForeignKey("HospitalId");

                    b.Navigation("Endereco");

                    b.Navigation("Hospital");
                });

            modelBuilder.Entity("fiap.webapp.check2.hospital.Models.Hospital", b =>
                {
                    b.Navigation("Pacientes");
                });
#pragma warning restore 612, 618
        }
    }
}
