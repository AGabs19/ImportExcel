﻿// <auto-generated />
using System;
using ImportExcel.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using AppContext = ImportExcel.DataBase.AppContext;

#nullable disable

namespace ImportExcel.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220412165717_ImportExcel")]
    partial class ImportExcel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ImportExcel.Models.Autorizacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdGerente1")
                        .HasColumnType("int");

                    b.Property<int>("IdGerente2")
                        .HasColumnType("int");

                    b.Property<string>("ObservacaoFuncionario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObservacaoGerente1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObservacaoGerente2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("StatusGerente1")
                        .HasColumnType("bit");

                    b.Property<bool>("StatusGerente2")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Autorizacao");
                });

            modelBuilder.Entity("ImportExcel.Models.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("ImportExcel.Models.Contrato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CargoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<double>("Salario")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("Contrato");
                });

            modelBuilder.Entity("ImportExcel.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CEP")
                        .HasColumnType("int");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longadouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("ImportExcel.Models.Ferias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("AdiantamentoDecimoTerceiro")
                        .HasColumnType("bit");

                    b.Property<bool>("AutorizacaoGerente1")
                        .HasColumnType("bit");

                    b.Property<bool>("AutorizacaoGerente2")
                        .HasColumnType("bit");

                    b.Property<DateTime>("AutorizacaoId")
                        .HasColumnType("datetime2");

                    b.Property<int?>("AutorizacaoId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HistoricoId")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HistoricoId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("PeriodoAquisitivoId")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PeriodoAquisitivoId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AutorizacaoId1");

                    b.HasIndex("HistoricoId1");

                    b.HasIndex("PeriodoAquisitivoId1");

                    b.ToTable("Ferias");
                });

            modelBuilder.Entity("ImportExcel.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CPF")
                        .HasColumnType("int");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TelefoneId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("TelefoneId");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("ImportExcel.Models.Historico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("QuantidadeDeDias")
                        .HasColumnType("int");

                    b.Property<DateTime>("UltimoPeriodo")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Venda")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Historico");
                });

            modelBuilder.Entity("ImportExcel.Models.PeriodoAquisitivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataDaContratacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UltimoPeriodo")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PeriodoAquisitivo");
                });

            modelBuilder.Entity("ImportExcel.Models.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("ImportExcel.Models.Contrato", b =>
                {
                    b.HasOne("ImportExcel.Models.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImportExcel.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("ImportExcel.Models.Ferias", b =>
                {
                    b.HasOne("ImportExcel.Models.Autorizacao", "Autorizacao")
                        .WithMany()
                        .HasForeignKey("AutorizacaoId1");

                    b.HasOne("ImportExcel.Models.Historico", "Historico")
                        .WithMany()
                        .HasForeignKey("HistoricoId1");

                    b.HasOne("ImportExcel.Models.PeriodoAquisitivo", "PeriodoAquisitivo")
                        .WithMany()
                        .HasForeignKey("PeriodoAquisitivoId1");

                    b.Navigation("Autorizacao");

                    b.Navigation("Historico");

                    b.Navigation("PeriodoAquisitivo");
                });

            modelBuilder.Entity("ImportExcel.Models.Funcionario", b =>
                {
                    b.HasOne("ImportExcel.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImportExcel.Models.Telefone", "Telefone")
                        .WithMany()
                        .HasForeignKey("TelefoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");

                    b.Navigation("Telefone");
                });
#pragma warning restore 612, 618
        }
    }
}
