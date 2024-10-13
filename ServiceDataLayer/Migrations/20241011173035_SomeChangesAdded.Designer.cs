﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServiceDataLayer.Models;

#nullable disable

namespace ServiceDataLayer.Migrations
{
    [DbContext(typeof(ServiceDBContext))]
    [Migration("20241011173035_SomeChangesAdded")]
    partial class SomeChangesAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ServiceDataLayer.Models.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("RoleId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("ServiceDataLayer.Models.CarStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("StatusName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CarStatuses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("54063478-b0f8-40c2-8a94-8964b26f0292"),
                            StatusName = 1
                        },
                        new
                        {
                            Id = new Guid("b7c0609f-c5f6-422b-a493-d61456d57cab"),
                            StatusName = 2
                        },
                        new
                        {
                            Id = new Guid("99d7790c-34ee-472b-beea-4a364b77fa7b"),
                            StatusName = 0
                        },
                        new
                        {
                            Id = new Guid("ce6f0c96-e0ca-4be8-9e40-9a37faaba044"),
                            StatusName = 3
                        });
                });

            modelBuilder.Entity("ServiceDataLayer.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c66d7158-1ef8-41ac-b552-e44992208c87"),
                            Name = 0
                        },
                        new
                        {
                            Id = new Guid("575f0f68-d1ed-458f-ba0c-36aa9a3b4e15"),
                            Name = 1
                        },
                        new
                        {
                            Id = new Guid("dd89b50e-8d1c-43f7-90c6-c50d397714f5"),
                            Name = 2
                        });
                });

            modelBuilder.Entity("ServiceDataLayer.Models.ServiceType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<decimal>("ServicePrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("ServiceTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0a4bc55c-fd9c-4989-a4a2-f9b0d615c6d9"),
                            Name = 3,
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = new Guid("49022463-7571-44d1-a527-09c719fc8447"),
                            Name = 5,
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = new Guid("e603d3cb-c539-4eec-976b-cc733c874993"),
                            Name = 3,
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = new Guid("2324d67e-0855-45f0-b46e-30982b47e40d"),
                            Name = 2,
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = new Guid("04a9da98-89a7-4dfc-996a-6b80e9698f9d"),
                            Name = 7,
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = new Guid("df59427d-e3d1-44fa-9890-1ae653483994"),
                            Name = 1,
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = new Guid("7e7f2190-6223-4f28-b560-cca3254535fd"),
                            Name = 4,
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = new Guid("a83470d3-82b0-42f9-afed-aca2dfc9045a"),
                            Name = 0,
                            ServicePrice = 0m
                        });
                });

            modelBuilder.Entity("ServiceDataLayer.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ServiceDataLayer.Models.Car", b =>
                {
                    b.HasOne("ServiceDataLayer.Models.Car", null)
                        .WithMany("Cars")
                        .HasForeignKey("CarId");

                    b.HasOne("ServiceDataLayer.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServiceDataLayer.Models.CarStatus", "Status")
                        .WithMany("Cars")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServiceDataLayer.Models.User", "User")
                        .WithMany("Cars")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ServiceDataLayer.Models.User", b =>
                {
                    b.HasOne("ServiceDataLayer.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ServiceDataLayer.Models.Car", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("ServiceDataLayer.Models.CarStatus", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("ServiceDataLayer.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ServiceDataLayer.Models.User", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}