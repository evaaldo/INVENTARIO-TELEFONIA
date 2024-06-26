﻿// <auto-generated />
using System;
using InventarioTelefonia.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InventarioTelefonia.Migrations
{
    [DbContext(typeof(InventarioTelefoniaContext))]
    [Migration("20240409193624_AdicionarTabelaNotaFiscal")]
    partial class AdicionarTabelaNotaFiscal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("InventarioTelefonia.Models.CentroCusto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("ClasseValor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("CentrosCusto");
                });

            modelBuilder.Entity("InventarioTelefonia.Models.NotaFiscal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNF")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fornecedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroNF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Soma")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("NotasFiscais");
                });

            modelBuilder.Entity("InventarioTelefonia.Models.UsuarioTelefonia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicial")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartamentoPessoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ICCID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InventarioAparelho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Operadora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pessoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("UsuariosTelefonia");
                });
#pragma warning restore 612, 618
        }
    }
}
