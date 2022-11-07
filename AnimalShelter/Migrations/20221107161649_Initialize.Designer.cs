﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20221107161649_Initialize")]
    partial class Initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AnimalAge")
                        .HasColumnType("int");

                    b.Property<string>("AnimalName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AnimalSpecies")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            AnimalAge = 2,
                            AnimalName = "Fido",
                            AnimalSpecies = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            AnimalAge = 15,
                            AnimalName = "Amber",
                            AnimalSpecies = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            AnimalAge = 10,
                            AnimalName = "Tilly",
                            AnimalSpecies = "Dog"
                        },
                        new
                        {
                            AnimalId = 4,
                            AnimalAge = 10,
                            AnimalName = "Tobby",
                            AnimalSpecies = "Dog"
                        },
                        new
                        {
                            AnimalId = 5,
                            AnimalAge = 6,
                            AnimalName = "Rocky",
                            AnimalSpecies = "Dog"
                        },
                        new
                        {
                            AnimalId = 6,
                            AnimalAge = 9,
                            AnimalName = "Pudgey",
                            AnimalSpecies = "Cat"
                        },
                        new
                        {
                            AnimalId = 7,
                            AnimalAge = 1,
                            AnimalName = "Niki",
                            AnimalSpecies = "Cat"
                        },
                        new
                        {
                            AnimalId = 8,
                            AnimalAge = 2,
                            AnimalName = "Memo",
                            AnimalSpecies = "Cat"
                        },
                        new
                        {
                            AnimalId = 9,
                            AnimalAge = 3,
                            AnimalName = "Late",
                            AnimalSpecies = "Cat"
                        },
                        new
                        {
                            AnimalId = 10,
                            AnimalAge = 5,
                            AnimalName = "Jack",
                            AnimalSpecies = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
