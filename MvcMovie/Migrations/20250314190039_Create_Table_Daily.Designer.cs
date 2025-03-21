﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Data;

#nullable disable

namespace MvcMovie.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250314190039_Create_Table_Daily")]
    partial class Create_Table_Daily
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("MvcMovie.Models.Daily", b =>
                {
                    b.Property<string>("MaHTPP")
                        .HasColumnType("TEXT");

                    b.Property<string>("Diachi")
                        .HasColumnType("TEXT");

                    b.Property<string>("Dienthoai")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaHTTP")
                        .HasColumnType("TEXT");

                    b.Property<string>("Madaily")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nguoidaidien")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenHTPP")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tendaily")
                        .HasColumnType("TEXT");

                    b.HasKey("MaHTPP");

                    b.ToTable("Daily");
                });

            modelBuilder.Entity("MvcMovie.Models.Person", b =>
                {
                    b.Property<string>("PersonId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fullname")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");

                    b.HasDiscriminator().HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("MvcMovie.Models.Employee", b =>
                {
                    b.HasBaseType("MvcMovie.Models.Person");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("employeID")
                        .HasColumnType("TEXT");

                    b.ToTable("Persons");

                    b.HasDiscriminator().HasValue("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
