﻿// <auto-generated />
using CarrinhoCompraAPI.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MinhaAPI.Migrations
{
    [DbContext(typeof(SqlServerContext))]
    [Migration("20240401170144_AtributosDeProduto-Em-CompraProduto")]
    partial class AtributosDeProdutoEmCompraProduto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CarrinhoCompraAPI.Domain.Models.CarrinhoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("QtdProduto")
                        .HasColumnType("int");

                    b.Property<double>("ValorTotalProduto")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Carrinho");
                });

            modelBuilder.Entity("CarrinhoCompraAPI.Domain.Models.CompraModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("QtdParcelas")
                        .HasColumnType("int");

                    b.Property<int>("QtdParcelasAtual")
                        .HasColumnType("int");

                    b.Property<double>("ValorAbatido")
                        .HasColumnType("float");

                    b.Property<double>("ValorParcelaAuxiliar")
                        .HasColumnType("float");

                    b.Property<double>("ValorParcelas")
                        .HasColumnType("float");

                    b.Property<double>("ValorRestante")
                        .HasColumnType("float");

                    b.Property<double>("ValorTotalCompra")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("CarrinhoCompraAPI.Domain.Models.CompraProdutoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("QtdParcelas")
                        .HasColumnType("int");

                    b.Property<int>("QtdParcelasAtual")
                        .HasColumnType("int");

                    b.Property<int>("QtdProduto")
                        .HasColumnType("int");

                    b.Property<double>("ValorAbatidoProduto")
                        .HasColumnType("float");

                    b.Property<double>("ValorParcelaAuxiliarProduto")
                        .HasColumnType("float");

                    b.Property<double>("ValorParcelasProduto")
                        .HasColumnType("float");

                    b.Property<double>("ValorRestanteProduto")
                        .HasColumnType("float");

                    b.Property<double>("ValorTotalProduto")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("CompraProduto");
                });

            modelBuilder.Entity("CarrinhoCompraAPI.Domain.Models.ProdutoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NomeProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrecoUnitarioProduto")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("CarrinhoCompraAPI.Domain.Models.CarrinhoModel", b =>
                {
                    b.HasOne("CarrinhoCompraAPI.Domain.Models.ProdutoModel", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("CarrinhoCompraAPI.Domain.Models.CompraProdutoModel", b =>
                {
                    b.HasOne("CarrinhoCompraAPI.Domain.Models.CompraModel", "Compra")
                        .WithMany("ComprasProduto")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarrinhoCompraAPI.Domain.Models.ProdutoModel", "Produto")
                        .WithMany("ComprasProduto")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compra");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("CarrinhoCompraAPI.Domain.Models.CompraModel", b =>
                {
                    b.Navigation("ComprasProduto");
                });

            modelBuilder.Entity("CarrinhoCompraAPI.Domain.Models.ProdutoModel", b =>
                {
                    b.Navigation("ComprasProduto");
                });
#pragma warning restore 612, 618
        }
    }
}
