﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SheepFit6.Models;
using System;

namespace SheepFit6.Migrations
{
    [DbContext(typeof(SheepContext))]
    [Migration("20180418193310_InitialCreate2")]
    partial class InitialCreate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("SheepFit6.Models.Animal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Booster");

                    b.Property<string>("Comment");

                    b.Property<DateTime>("DOB");

                    b.Property<string>("Gender");

                    b.Property<DateTime>("Pneumonia");

                    b.Property<DateTime>("Rabies");

                    b.Property<DateTime>("Tetanus");

                    b.Property<DateTime>("Wormer");

                    b.Property<string>("sheepID");

                    b.HasKey("ID");

                    b.ToTable("Animal");
                });
#pragma warning restore 612, 618
        }
    }
}