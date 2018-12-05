﻿// <auto-generated />
using AgendaDistribuidas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AgendaDistribuidas.Migrations
{
    [DbContext(typeof(AgendaDistribuidasContext))]
    [Migration("20181204215308_AgregarSector")]
    partial class AgregarSector
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgendaDistribuidas.Models.Contacto", b =>
                {
                    b.Property<int>("ContactoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Interno");

                    b.Property<string>("Nombre");

                    b.Property<int>("SectorId");

                    b.HasKey("ContactoId");

                    b.HasIndex("SectorId");

                    b.ToTable("Contacto");
                });

            modelBuilder.Entity("AgendaDistribuidas.Models.Sector", b =>
                {
                    b.Property<int>("SectorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.HasKey("SectorId");

                    b.ToTable("Sector");
                });

            modelBuilder.Entity("AgendaDistribuidas.Models.Contacto", b =>
                {
                    b.HasOne("AgendaDistribuidas.Models.Sector", "Sector")
                        .WithMany("Contactos")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
