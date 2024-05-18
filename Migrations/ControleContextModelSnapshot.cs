﻿// <auto-generated />
using System;
using ControleDeValidades.Databases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleDeValidades.Migrations
{
    [DbContext(typeof(ControleContext))]
    partial class ControleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ControleDeValidades.Models.Produto", b =>
                {
                    b.Property<int>("PRONID_PRO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PRONID_PRO"));

                    b.Property<string>("PROCCODINT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PROCDESCR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PROCFOR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PROCNNUMNF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PROCREF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PROCSTAT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PROCUSRALT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PROCUSRCAD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PRODDATALT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PRODDATCAD")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PRODDATVAL")
                        .HasColumnType("datetime2");

                    b.Property<int>("PRONQUANT")
                        .HasColumnType("int");

                    b.HasKey("PRONID_PRO");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("ControleDeValidades.Models.Usuarios", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}