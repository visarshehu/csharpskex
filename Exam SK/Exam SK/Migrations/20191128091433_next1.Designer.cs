﻿// <auto-generated />
using System;
using Exam_SK.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExamSK.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20191128091433_next1")]
    partial class next1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Exam_SK.Models.Car", b =>
                {
                    b.Property<string>("LicencePlate")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataRegistered")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FuelType");

                    b.Property<string>("Manufacturer")
                        .IsRequired();

                    b.Property<string>("Model");

                    b.Property<DateTime>("YearOfProduction");

                    b.HasKey("LicencePlate");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Exam_SK.Models.Rented", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfRent")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateofReturn");

                    b.Property<int>("KilometersOnRent");

                    b.Property<int>("KilometersOnReturn");

                    b.Property<string>("UserUname");

                    b.Property<string>("carLicencePlate");

                    b.HasKey("Id");

                    b.HasIndex("UserUname");

                    b.HasIndex("carLicencePlate");

                    b.ToTable("Renteds");
                });

            modelBuilder.Entity("Exam_SK.Models.User", b =>
                {
                    b.Property<string>("Uname")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthdate");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<bool>("HasDriverLicence");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Uname");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Exam_SK.Models.Rented", b =>
                {
                    b.HasOne("Exam_SK.Models.User", "User")
                        .WithMany("Renteds")
                        .HasForeignKey("UserUname");

                    b.HasOne("Exam_SK.Models.Car", "car")
                        .WithMany("Renteds")
                        .HasForeignKey("carLicencePlate");
                });
#pragma warning restore 612, 618
        }
    }
}
