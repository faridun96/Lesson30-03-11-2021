﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEBAPI.Db;

namespace WEBAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("WEBAPI.Models.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Quotes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "-''_|_/-",
                            InsertDate = new DateTime(2021, 11, 6, 2, 10, 40, 541, DateTimeKind.Local).AddTicks(40),
                            Text = "Если ты устал, то присядь"
                        },
                        new
                        {
                            Id = 2,
                            Author = "-''_|_/-",
                            InsertDate = new DateTime(2021, 11, 6, 2, 10, 40, 543, DateTimeKind.Local).AddTicks(41),
                            Text = "Если ты покушал, то делай свое дело"
                        },
                        new
                        {
                            Id = 3,
                            Author = "-''_|_/-",
                            InsertDate = new DateTime(2021, 11, 6, 2, 10, 40, 543, DateTimeKind.Local).AddTicks(41),
                            Text = "Если ты не хочешь работать, то не работай"
                        },
                        new
                        {
                            Id = 4,
                            Author = "-''_|_/-",
                            InsertDate = new DateTime(2021, 11, 6, 2, 10, 40, 543, DateTimeKind.Local).AddTicks(41),
                            Text = "Если ты хочешь пить, то открой кран и выпей"
                        },
                        new
                        {
                            Id = 5,
                            Author = "-''_|_/-",
                            InsertDate = new DateTime(2021, 11, 6, 2, 10, 40, 543, DateTimeKind.Local).AddTicks(41),
                            Text = "Если ты хочешь есть, то открой холодильник"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
