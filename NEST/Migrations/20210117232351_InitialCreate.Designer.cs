﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NEST.Data;

namespace NEST.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210117232351_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NEST.Models.IsolationPointList", b =>
                {
                    b.Property<int>("UDC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlternateLockout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheckedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DefaultIso")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnergyPotential")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FacilityCode")
                        .HasColumnType("int");

                    b.Property<bool>("HighRiskPlant")
                        .HasColumnType("bit");

                    b.Property<bool>("IsIsolationPoint")
                        .HasColumnType("bit");

                    b.Property<int>("IsolationCat")
                        .HasColumnType("int");

                    b.Property<string>("IsolationPoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsolationType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsolationUID")
                        .HasColumnType("int");

                    b.Property<bool>("Padlockable")
                        .HasColumnType("bit");

                    b.Property<string>("ParentSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhysicalLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferredLockout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferredPadlock")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SwitchboardOrCubicle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValidationMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ValidationPoss")
                        .HasColumnType("bit");

                    b.HasKey("UDC");

                    b.ToTable("IsolationPointList");
                });

            modelBuilder.Entity("NEST.Models.IsolationPointTools", b =>
                {
                    b.Property<int>("StockCodeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartNum")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StockCodeID");

                    b.ToTable("IsolationPointTools");
                });
#pragma warning restore 612, 618
        }
    }
}
