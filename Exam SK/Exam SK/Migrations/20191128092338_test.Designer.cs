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
    [Migration("20191128092338_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
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

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.ToTable("CyberTrucks");
                });

            modelBuilder.Entity("Exam_SK.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bid");

                    b.Property<int?>("CyberTrucksId");

                    b.Property<DateTime>("DateOfOrder")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UsersUname");

                    b.HasKey("Id");

                    b.HasIndex("CyberTrucksId");

                    b.HasIndex("UsersUname");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Exam_SK.Models.User", b =>
                {
                    b.Property<string>("Uname")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Uname");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Exam_SK.Models.Order", b =>
                {
                    b.HasOne("Exam_SK.Models.CyberTruck", "CyberTrucks")
                        .WithMany("Orders")
                        .HasForeignKey("CyberTrucksId");

                    b.HasOne("Exam_SK.Models.User", "Users")
                        .WithMany("Orders")
                        .HasForeignKey("UsersUname");
                });
#pragma warning restore 612, 618
        }
    }
}
