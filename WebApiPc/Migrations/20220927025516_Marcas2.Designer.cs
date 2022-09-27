﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiPc;

#nullable disable

namespace WebApiPc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220927025516_Marcas2")]
    partial class Marcas2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApiPc.Entidades.Computadora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Computadoras");
                });

            modelBuilder.Entity("WebApiPc.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Almacenamiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fabricante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModeloID")
                        .HasColumnType("int");

                    b.Property<string>("Procesador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ram")
                        .HasColumnType("int");

                    b.Property<string>("SO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("computadoraId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("computadoraId");

                    b.ToTable("marcas");
                });

            modelBuilder.Entity("WebApiPc.Marca", b =>
                {
                    b.HasOne("WebApiPc.Entidades.Computadora", "computadora")
                        .WithMany("Marca")
                        .HasForeignKey("computadoraId");

                    b.Navigation("computadora");
                });

            modelBuilder.Entity("WebApiPc.Entidades.Computadora", b =>
                {
                    b.Navigation("Marca");
                });
#pragma warning restore 612, 618
        }
    }
}
