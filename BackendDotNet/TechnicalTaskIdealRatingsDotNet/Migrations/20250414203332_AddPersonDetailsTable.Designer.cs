﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechnicalTaskIdealRatingsDotNet.Data;

#nullable disable

namespace TechnicalTaskIdealRatingsDotNet.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250414203332_AddPersonDetailsTable")]
    partial class AddPersonDetailsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TechnicalTaskIdealRatingsDotNet.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("address");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("country");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("telephone Number");

                    b.HasKey("Id");

                    b.ToTable("Person_Details");
                });
#pragma warning restore 612, 618
        }
    }
}
