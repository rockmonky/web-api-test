﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using web_api_test;

#nullable disable

namespace web_api_test.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241030175610_Viajefoto")]
    partial class Viajefoto
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("web_api_test.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("web_api_test.Images", b =>
                {
                    b.Property<int>("vf_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("vf_id"));

                    b.Property<DateTime>("fv_fechaini")
                        .HasColumnType("datetime2");

                    b.Property<int>("to_id")
                        .HasColumnType("int");

                    b.Property<int>("ua_idcrea")
                        .HasColumnType("int");

                    b.Property<string>("vf_location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vf_path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("vi_id")
                        .HasColumnType("int");

                    b.HasKey("vf_id");

                    b.ToTable("viajefoto");
                });
#pragma warning restore 612, 618
        }
    }
}