﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using job_data;

#nullable disable

namespace data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RecruiterLogin.recruiterlogin", b =>
                {
                    b.Property<string>("companyname")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("companyname");

                    b.ToTable("Recruiterlogin");
                });

            modelBuilder.Entity("jobportal.emplogin", b =>
                {
                    b.Property<string>("username")
                        .HasColumnType("text");

                    b.Property<string>("department")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("experience")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phonenumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("username");

                    b.ToTable("Emplogin");
                });
#pragma warning restore 612, 618
        }
    }
}
