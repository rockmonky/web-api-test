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
    [Migration("20241030194529_UserApplication")]
    partial class UserApplication
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("web_api_test.AccessUserApplication", b =>
                {
                    b.Property<int>("aua_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("aua_id"));

                    b.Property<DateTime>("ac_fechafin")
                        .HasColumnType("datetime2");

                    b.Property<int>("ap_id")
                        .HasColumnType("int");

                    b.Property<int>("aua_perfil")
                        .HasColumnType("int");

                    b.Property<int>("ua_id")
                        .HasColumnType("int");

                    b.HasKey("aua_id");

                    b.ToTable("accessUserApplications");
                });

            modelBuilder.Entity("web_api_test.Contact", b =>
                {
                    b.Property<int>("co_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("co_id"));

                    b.Property<string>("co_apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("co_nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("co_id");

                    b.ToTable("contacts");
                });

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

                    b.Property<byte>("to_id")
                        .HasColumnType("tinyint");

                    b.Property<int>("ua_idcrea")
                        .HasColumnType("int");

                    b.Property<DateTime>("vf_fechaini")
                        .HasColumnType("datetime2");

                    b.Property<string>("vf_path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("vi_id")
                        .HasColumnType("int");

                    b.HasKey("vf_id");

                    b.ToTable("viajefoto");
                });

            modelBuilder.Entity("web_api_test.Installer", b =>
                {
                    b.Property<int>("in_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("in_id"));

                    b.Property<int>("co_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("in_fechafin")
                        .HasColumnType("datetime2");

                    b.HasKey("in_id");

                    b.ToTable("installers");
                });

            modelBuilder.Entity("web_api_test.UserApplication", b =>
                {
                    b.Property<int>("ua_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ua_id"));

                    b.Property<int>("co_id")
                        .HasColumnType("int");

                    b.Property<string>("ua_con")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ua_fechafin")
                        .HasColumnType("datetime2");

                    b.Property<string>("ua_usr")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ua_id");

                    b.ToTable("userApplications");
                });
#pragma warning restore 612, 618
        }
    }
}