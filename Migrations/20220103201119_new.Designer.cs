﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using airline;

namespace airline.Migrations
{
    [DbContext(typeof(connect))]
    [Migration("20220103201119_new")]
    partial class @new
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("airline.Customer", b =>
                {
                    b.Property<int>("Customer_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Family")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numericid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Customer_id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("airline.Customer_Fly", b =>
                {
                    b.Property<int>("C_F_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Customer_id")
                        .HasColumnType("int");

                    b.Property<int>("Fly_Id")
                        .HasColumnType("int");

                    b.HasKey("C_F_Id");

                    b.ToTable("Customer_flys");
                });

            modelBuilder.Entity("airline.Fly_List", b =>
                {
                    b.Property<int>("Fly_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Airline_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_Fly")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("capcity")
                        .HasColumnType("int");

                    b.HasKey("Fly_Id");

                    b.ToTable("Fly_Lists");
                });

            modelBuilder.Entity("airline.Fly_Type", b =>
                {
                    b.Property<int>("Type_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Type_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Type_Id");

                    b.ToTable("Fly_Types");
                });
#pragma warning restore 612, 618
        }
    }
}