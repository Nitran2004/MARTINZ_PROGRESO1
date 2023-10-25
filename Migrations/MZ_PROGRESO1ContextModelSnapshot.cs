﻿// <auto-generated />
using System;
using MZ_PROGRESO1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MZ_PROGRESO1.Migrations
{
    [DbContext(typeof(MZ_PROGRESO1Context))]
    partial class MZ_PROGRESO1ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MZ_PROGRESO1.Models.ZUMARRAGA", b =>
                {
                    b.Property<int>("mzCodigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("mzCodigo"), 1L, 1);

                    b.Property<string>("mzApellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("mzCalificacionFinal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("mzCodigoPostal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mzCorreo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("mzEstudianteNuevo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("mzFechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("mzNombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("mzPromedioConducta")
                        .HasColumnType("real");

                    b.HasKey("mzCodigo");

                    b.ToTable("ZUMARRAGA");
                });
#pragma warning restore 612, 618
        }
    }
}
