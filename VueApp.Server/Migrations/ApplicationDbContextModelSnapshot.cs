﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VueApp.Server.Data;

#nullable disable

namespace VueApp.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VueApp.Server.Models.Entitys.CirclesEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DataId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Diameter")
                        .HasColumnType("real");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<float>("XAxis")
                        .HasColumnType("real");

                    b.Property<float>("YAxis")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("DataId");

                    b.ToTable("Circles");
                });

            modelBuilder.Entity("VueApp.Server.Models.Entitys.DataEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Data");
                });

            modelBuilder.Entity("VueApp.Server.Models.Entitys.CirclesEntity", b =>
                {
                    b.HasOne("VueApp.Server.Models.Entitys.DataEntity", "Data")
                        .WithMany()
                        .HasForeignKey("DataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Data");
                });
#pragma warning restore 612, 618
        }
    }
}
