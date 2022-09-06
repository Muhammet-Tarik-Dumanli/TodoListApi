﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoListApi.Data;

#nullable disable

namespace TodoListApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220905092649_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TodoListApi.Data.TodoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TodoItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDone = false,
                            Title = "Go shopping"
                        },
                        new
                        {
                            Id = 2,
                            IsDone = false,
                            Title = "Do your homework"
                        },
                        new
                        {
                            Id = 3,
                            IsDone = true,
                            Title = "Wash your car"
                        },
                        new
                        {
                            Id = 4,
                            IsDone = true,
                            Title = "Watch Netflix"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
