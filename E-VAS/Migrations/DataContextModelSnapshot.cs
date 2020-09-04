﻿// <auto-generated />
using System;
using E_VAS.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_VAS.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("E_VAS.Data.Models.GveLocationModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GveId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<float>("Latitude")
                        .HasColumnType("float");

                    b.Property<float>("Longitude")
                        .HasColumnType("float");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("GveId");

                    b.ToTable("GveLocationModel");
                });

            modelBuilder.Entity("E_VAS.Data.Models.GveModel", b =>
                {
                    b.Property<string>("GveId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TvdId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("GveId");

                    b.HasIndex("TvdId");

                    b.ToTable("GveModel");
                });

            modelBuilder.Entity("E_VAS.Data.Models.TvdModel", b =>
                {
                    b.Property<string>("TvdId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("TvdName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("TvdId");

                    b.ToTable("TvdModel");
                });

            modelBuilder.Entity("E_VAS.Data.Models.GveLocationModel", b =>
                {
                    b.HasOne("E_VAS.Data.Models.GveModel", "Gve")
                        .WithMany()
                        .HasForeignKey("GveId");
                });

            modelBuilder.Entity("E_VAS.Data.Models.GveModel", b =>
                {
                    b.HasOne("E_VAS.Data.Models.TvdModel", "Tvd")
                        .WithMany()
                        .HasForeignKey("TvdId");
                });
#pragma warning restore 612, 618
        }
    }
}
