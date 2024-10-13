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
    [Migration("20241013095153_AddedControllers")]
    partial class AddedControllers
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

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

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
                            Id = new Guid("fc8b6cec-db3c-4ee2-94fc-9ed17ea441c4"),
                            StatusName = 1
                        },
                        new
                        {
                            Id = new Guid("9f3a5565-6309-43dd-9da1-71c11114ce00"),
                            StatusName = 2
                        },
                        new
                        {
                            Id = new Guid("ef788967-e426-46ef-b5e8-f3aea49f50a4"),
                            StatusName = 0
                        },
                        new
                        {
                            Id = new Guid("94f0559f-d923-4873-809f-59b373dd4ddc"),
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
                            Id = new Guid("ec9b6652-1ff5-4d1b-81c2-6ca3a61ea39d"),
                            Name = 0
                        },
                        new
                        {
                            Id = new Guid("4cb29782-9531-4a4b-97e0-77737f043c01"),
                            Name = 1
                        },
                        new
                        {
                            Id = new Guid("4560f276-e2bd-4783-b7c4-bdbb86800dce"),
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
                            Id = new Guid("3a2044ac-bd57-4101-87bb-3b0433839662"),
                            Name = 3,
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = new Guid("34dc2cb3-037d-4231-b962-dcfad91e9169"),
                            Name = 5,
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = new Guid("6d3e850b-e320-46f5-b166-99c01f5e0584"),
                            Name = 3,
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = new Guid("9b7b2104-f8c5-4dd7-9b1e-5614ecc0fb43"),
                            Name = 2,
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = new Guid("387bf946-d1ce-4fde-892c-c9497df904bb"),
                            Name = 7,
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = new Guid("8b398794-9d2b-492f-ac1b-bb28b3374c82"),
                            Name = 1,
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = new Guid("3b0a4c42-e6c9-47bf-90be-d05e8df17a39"),
                            Name = 4,
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = new Guid("b7795d96-8bf0-473e-abaa-ab58280ecac1"),
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
