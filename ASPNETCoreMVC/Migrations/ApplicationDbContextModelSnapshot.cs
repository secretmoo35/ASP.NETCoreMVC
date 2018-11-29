﻿// <auto-generated />
using ASPNETCoreMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASPNETCoreMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASPNETCoreMVC.Models.AddressModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detail")
                        .HasMaxLength(120);

                    b.Property<string>("District")
                        .HasMaxLength(30);

                    b.Property<string>("Postcode")
                        .HasMaxLength(5);

                    b.Property<string>("Province")
                        .HasMaxLength(30);

                    b.Property<string>("Subdistrict")
                        .HasMaxLength(30);

                    b.HasKey("ID");

                    b.ToTable("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
