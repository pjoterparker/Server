﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PjoterParker.Api.Database;

namespace PjoterParker.Api.Database.Migrations
{
    [DbContext(typeof(ApiDatabaseContext))]
    [Migration("20191021124423_Add_Column_IsDisabled_Location")]
    partial class Add_Column_IsDisabled_Location
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PjoterParker.Api.Database.Entities.Location", b =>
                {
                    b.Property<Guid>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<bool>("IsDisabled");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("PjoterParker.Api.Database.Entities.Spot", b =>
                {
                    b.Property<Guid>("SpotId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("LocationId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<Guid?>("UserId");

                    b.HasKey("SpotId");

                    b.HasIndex("LocationId");

                    b.ToTable("Spot");
                });

            modelBuilder.Entity("PjoterParker.Api.Database.Entities.Spot", b =>
                {
                    b.HasOne("PjoterParker.Api.Database.Entities.Location", "Location")
                        .WithMany("Spots")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}