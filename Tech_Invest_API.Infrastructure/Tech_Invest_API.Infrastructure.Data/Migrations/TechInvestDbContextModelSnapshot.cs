﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tech_Invest_API.Infrastructure.Data.Data;

#nullable disable

namespace Tech_Invest_API.Infrastructure.Data.Migrations
{
    [DbContext(typeof(TechInvestDbContext))]
    partial class TechInvestDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Tech_Invest_API.Domain.Model.TipoInvestimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdUsuarioAlteracao")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuarioCriacao")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuarioAlteracao");

                    b.HasIndex("IdUsuarioCriacao");

                    b.ToTable("TiposInvestimento");
                });

            modelBuilder.Entity("Tech_Invest_API.Domain.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("SenhaHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SenhaSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Tech_Invest_API.Domain.Model.TipoInvestimento", b =>
                {
                    b.HasOne("Tech_Invest_API.Domain.Model.Usuario", "UsuarioAlteracao")
                        .WithMany()
                        .HasForeignKey("IdUsuarioAlteracao");

                    b.HasOne("Tech_Invest_API.Domain.Model.Usuario", "UsuarioCriacao")
                        .WithMany()
                        .HasForeignKey("IdUsuarioCriacao");

                    b.Navigation("UsuarioAlteracao");

                    b.Navigation("UsuarioCriacao");
                });
#pragma warning restore 612, 618
        }
    }
}
