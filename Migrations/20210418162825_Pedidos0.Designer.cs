﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vendas.Models;

namespace Vendas.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210418162825_Pedidos0")]
    partial class Pedidos0
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vendas.Models.Pedidos", b =>
                {
                    b.Property<int>("PedidosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescricaoPedido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("mesa")
                        .HasColumnType("int");

                    b.Property<int>("telefone")
                        .HasColumnType("int");

                    b.HasKey("PedidosId");

                    b.ToTable("Pedido");
                });
#pragma warning restore 612, 618
        }
    }
}
