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
    [Migration("20191128093851_cyberTrucksss")]
    partial class cyberTrucksss
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Exam_SK.Models.CyberTruck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .IsRequired();

                    b.Property<DateTime>("EstimatedDelivery");

                    b.Property<string>("Model")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("cyberTrucks");
                });

            modelBuilder.Entity("Exam_SK.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bid");

                    b.Property<int>("CyberId");

                    b.Property<DateTime>("DateofOrder");

                    b.Property<string>("UserUName");

                    b.Property<string>("Username");

                    b.Property<int?>("cyberTruckId");

                    b.HasKey("Id");

                    b.HasIndex("UserUName");

                    b.HasIndex("cyberTruckId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("Exam_SK.Models.User", b =>
                {
                    b.Property<string>("UName")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("UName");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Exam_SK.Models.Order", b =>
                {
                    b.HasOne("Exam_SK.Models.User", "User")
                        .WithMany("orders")
                        .HasForeignKey("UserUName");

                    b.HasOne("Exam_SK.Models.CyberTruck", "cyberTruck")
                        .WithMany("order")
                        .HasForeignKey("cyberTruckId");
                });
#pragma warning restore 612, 618
        }
    }
}
