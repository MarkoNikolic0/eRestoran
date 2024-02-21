﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

#nullable disable

namespace ERestoran.Migrations
{
    [DbContext(typeof(ERestoranContext))]
    [Migration("20230520155304_V5")]
    partial class V5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Hrana", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<double>("Cena")
                        .HasColumnType("float");

                    b.Property<string>("JedinicaMere")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Kolicina")
                        .HasColumnType("float");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RestoranID")
                        .HasColumnType("int");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("RestoranID");

                    b.ToTable("Hrana");
                });

            modelBuilder.Entity("Models.KomentarHrane", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("HranaID")
                        .HasColumnType("int");

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VremePostavljanja")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("HranaID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("KomentariHrane");
                });

            modelBuilder.Entity("Models.KomentarRestorana", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int?>("RestoranID")
                        .HasColumnType("int");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VremePostavljanja")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("RestoranID");

                    b.ToTable("KomentariRestorana");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RefreshTokenExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("Models.ObjekatSale", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Duzina")
                        .HasColumnType("float");

                    b.Property<double>("PozicijaX")
                        .HasColumnType("float");

                    b.Property<double>("PozicijaY")
                        .HasColumnType("float");

                    b.Property<int?>("SalaID")
                        .HasColumnType("int");

                    b.Property<double>("Sirina")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("SalaID");

                    b.ToTable("ObjekatSale");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ObjekatSale");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Models.OcenaHrane", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("HranaID")
                        .HasColumnType("int");

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<long>("Vrednost")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("HranaID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("OceneHrane");
                });

            modelBuilder.Entity("Models.OcenaRestorana", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int?>("RestoranID")
                        .HasColumnType("int");

                    b.Property<long>("Vrednost")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("RestoranID");

                    b.ToTable("OceneRestorana");
                });

            modelBuilder.Entity("Models.Restoran", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Restorani");
                });

            modelBuilder.Entity("Models.Rezervacija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BrojLjudi")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumRezervacije")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int?>("RestoranID")
                        .HasColumnType("int");

                    b.Property<int?>("StoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("RestoranID");

                    b.HasIndex("StoID");

                    b.ToTable("Rezervacije");
                });

            modelBuilder.Entity("Models.Sala", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<double>("Duzina")
                        .HasColumnType("float");

                    b.Property<int?>("RestoranID")
                        .HasColumnType("int");

                    b.Property<double>("Sirina")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("RestoranID");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("Models.Sto", b =>
                {
                    b.HasBaseType("Models.ObjekatSale");

                    b.Property<int>("BrojMesta")
                        .HasColumnType("int");

                    b.Property<bool>("Rezervisano")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Sto");
                });

            modelBuilder.Entity("Models.Hrana", b =>
                {
                    b.HasOne("Models.Restoran", "Restoran")
                        .WithMany("Meni")
                        .HasForeignKey("RestoranID");

                    b.Navigation("Restoran");
                });

            modelBuilder.Entity("Models.KomentarHrane", b =>
                {
                    b.HasOne("Models.Hrana", "Hrana")
                        .WithMany("Komentari")
                        .HasForeignKey("HranaID");

                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID");

                    b.Navigation("Hrana");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("Models.KomentarRestorana", b =>
                {
                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID");

                    b.HasOne("Models.Restoran", "Restoran")
                        .WithMany("Komentari")
                        .HasForeignKey("RestoranID");

                    b.Navigation("Korisnik");

                    b.Navigation("Restoran");
                });

            modelBuilder.Entity("Models.ObjekatSale", b =>
                {
                    b.HasOne("Models.Sala", "Sala")
                        .WithMany("Predmeti")
                        .HasForeignKey("SalaID");

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("Models.OcenaHrane", b =>
                {
                    b.HasOne("Models.Hrana", "Hrana")
                        .WithMany("Ocene")
                        .HasForeignKey("HranaID");

                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID");

                    b.Navigation("Hrana");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("Models.OcenaRestorana", b =>
                {
                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID");

                    b.HasOne("Models.Restoran", "Restoran")
                        .WithMany("Ocene")
                        .HasForeignKey("RestoranID");

                    b.Navigation("Korisnik");

                    b.Navigation("Restoran");
                });

            modelBuilder.Entity("Models.Rezervacija", b =>
                {
                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID");

                    b.HasOne("Models.Restoran", "Restoran")
                        .WithMany()
                        .HasForeignKey("RestoranID");

                    b.HasOne("Models.Sto", "Sto")
                        .WithMany()
                        .HasForeignKey("StoID");

                    b.Navigation("Korisnik");

                    b.Navigation("Restoran");

                    b.Navigation("Sto");
                });

            modelBuilder.Entity("Models.Sala", b =>
                {
                    b.HasOne("Models.Restoran", "Restoran")
                        .WithMany("Sale")
                        .HasForeignKey("RestoranID");

                    b.Navigation("Restoran");
                });

            modelBuilder.Entity("Models.Hrana", b =>
                {
                    b.Navigation("Komentari");

                    b.Navigation("Ocene");
                });

            modelBuilder.Entity("Models.Restoran", b =>
                {
                    b.Navigation("Komentari");

                    b.Navigation("Meni");

                    b.Navigation("Ocene");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("Models.Sala", b =>
                {
                    b.Navigation("Predmeti");
                });
#pragma warning restore 612, 618
        }
    }
}
